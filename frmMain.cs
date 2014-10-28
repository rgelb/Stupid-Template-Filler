using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TemplateFiller
{
    public partial class frmMain : Form
    {
        private const string FILE_CONNECTIONS = "Connections.txt";
        private List<string> connectionStrings = new List<string>();

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                StringBuilder results = new StringBuilder();

                DataTable dt = ExecuteDataTable(cboConnections.Text, txtQuery.Text);
                foreach (DataRow row in dt.Rows)
                {
                    string singleRowResult = txtTemplate.Text;
                    for (int i = 0; i < dt.Columns.Count; i++)
                        singleRowResult = singleRowResult.Replace("{" + i.ToString() + "}", Convert.ToString(row.ItemArray[i]));

                    results.Append(singleRowResult);
                }

                txtResults.Text = results.ToString();

                // add to connection string collection
                if (!connectionStrings.Contains(cboConnections.Text))
                    connectionStrings.Add(cboConnections.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Retrieving Data: " + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        protected DataTable ExecuteDataTable(string connectionString, string commandText)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = commandText;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandTimeout = 120;

                    using (var da = new SqlDataAdapter(cmd))
                    {
                        var dt = new DataTable();
                        da.Fill(dt);

                        return dt;
                    }
                }
            }
        }

        private void btnCopyAll_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtResults.Text);
        }

        private void txtResults_DoubleClick(object sender, EventArgs e)
        {
            txtResults.Text = "";
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadConnections();
            PopulateConnections();
        }

        private void PopulateConnections()
        {
            foreach (string item in connectionStrings)
                cboConnections.Items.Add(item);
        }

        private void LoadConnections()
        {
            string fileConnections = Path.Combine(Application.LocalUserAppDataPath, FILE_CONNECTIONS);

            try
            {
                if (!File.Exists(fileConnections)) return;

                connectionStrings = File.ReadLines(fileConnections).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Connection Strings: " + ex.Message);
            }
        }

        private void SaveConnections()
        {
            string fileConnections = Path.Combine(Application.LocalUserAppDataPath, FILE_CONNECTIONS);

            try
            {
                File.WriteAllLines(fileConnections, connectionStrings);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Saving Connection Strings: " + ex.Message);
            }

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveConnections();
        }
    }
}

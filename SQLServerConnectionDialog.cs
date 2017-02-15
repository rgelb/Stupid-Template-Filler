using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace TemplateFiller
{
    public partial class SQLServerConnectionDialog: Form
    {
        private readonly SqlConnectionStringBuilder conn = new SqlConnectionStringBuilder();

        public string RootPath = "";

        private void SQLServerConnectionDialog_Load(Object sender, EventArgs e)
        {
            cbServer.Text = conn.DataSource;
            cbDataBase.Text = conn.InitialCatalog;

            if (conn.IntegratedSecurity == false)
            {
                txtUser.Enabled = true;
                txtPassword.Enabled = true;
                rbAuthenticationWin.Checked = false;
                rbAuthenticationSql.Checked = true;
                txtUser.Text = conn.UserID;
                txtPassword.Text = conn.Password;
            }

        }

        private void btnRefresh_Click(Object sender, EventArgs e)
        {
            SqlInstances();
        }

        public void ContructConnection()
        {
            conn.DataSource = cbServer.Text;
            conn.IntegratedSecurity = true;
            conn.UserID = "";
            conn.Password = "";
            conn.InitialCatalog = "";

            if (rbAuthenticationSql.Checked)
            {
                conn.IntegratedSecurity = false;
                conn.UserID = txtUser.Text;
                conn.Password = txtPassword.Text;
            }
            if (!string.IsNullOrEmpty(cbDataBase.Text))
            {
                conn.InitialCatalog = cbDataBase.Text;
            }
        }

        public void SqlInstances()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                cbServer.Items.Clear();

                DataTable sqlSources = SqlDataSourceEnumerator.Instance.GetDataSources();
                foreach (DataRow datarow in sqlSources.Rows)
                {
                    string datasource = datarow["ServerName"].ToString();
                    if ((!ReferenceEquals(datarow["InstanceName"], DBNull.Value)))
                    {
                        datasource += string.Format("\\{0}", datarow["InstanceName"]);
                    }
                    cbServer.Items.Add(datasource);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;
        }


        public void SqlDatabaseNames()
        {
            ContructConnection();
            Cursor.Current = Cursors.WaitCursor;
            string connString = null;
            connString = conn.ConnectionString;
            cbDataBase.Items.Clear();
            try
            {
                using (var cn = new SqlConnection(connString))
                {
                    cn.Open();
                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "sp_databases";

                        using (SqlDataReader myReader = cmd.ExecuteReader())
                        {
                            while ((myReader.Read()))
                            {
                                cbDataBase.Items.Add(myReader.GetString(0));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;
        }


        public void TestDB()
        {
            ContructConnection();
            try
            {
                var objConn = new SqlConnection(conn.ConnectionString);
                objConn.Open();
                objConn.Close();
                MessageBox.Show("Successful connection!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cbServer_DropDown(Object sender, EventArgs e)
        {
            if (cbServer.Items.Count == 0)
            {
                SqlInstances();
            }
        }

        private void cbDataBase_DropDown(Object sender, EventArgs e)
        {
            SqlDatabaseNames();
        }

        private void rbAuthenticationWin_CheckedChanged(Object sender, EventArgs e)
        {
            txtUser.Enabled = false;
            txtPassword.Enabled = false;
        }

        private void rbAuthenticationSql_CheckedChanged(Object sender, EventArgs e)
        {
            txtUser.Enabled = true;
            txtPassword.Enabled = true;
        }


        private void btnTest_Click(Object sender, EventArgs e)
        {
            TestDB();
        }

        private void btnOK_Click(Object sender, EventArgs e)
        {
            ContructConnection();
            this.Close();
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(Object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }

        public string ConnectionString
        {
            get { return conn.ConnectionString; }
            set { conn.ConnectionString = value; }
        }

        public SQLServerConnectionDialog()
        {
            InitializeComponent();
        }

        private void cbServer_TextChanged(object sender, EventArgs e)
        {
            cbDataBase.Text = "";
        }
    }
}
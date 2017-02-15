
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace TemplateFiller
{
    partial class SQLServerConnectionDialog
    {
        private System.ComponentModel.IContainer components;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SQLServerConnectionDialog));
            this.lbServidor = new System.Windows.Forms.Label();
            this.cbServer = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.rbAuthenticationWin = new System.Windows.Forms.RadioButton();
            this.rbAuthenticationSql = new System.Windows.Forms.RadioButton();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbClave = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.cbDataBase = new System.Windows.Forms.ComboBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lbBase = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbServidor
            // 
            this.lbServidor.AutoSize = true;
            this.lbServidor.Location = new System.Drawing.Point(7, 6);
            this.lbServidor.Name = "lbServidor";
            this.lbServidor.Size = new System.Drawing.Size(69, 13);
            this.lbServidor.TabIndex = 0;
            this.lbServidor.Text = "Server Name";
            // 
            // cbServer
            // 
            this.cbServer.FormattingEnabled = true;
            this.cbServer.Location = new System.Drawing.Point(10, 23);
            this.cbServer.Name = "cbServer";
            this.cbServer.Size = new System.Drawing.Size(232, 21);
            this.cbServer.TabIndex = 1;
            this.cbServer.DropDown += new System.EventHandler(this.cbServer_DropDown);
            this.cbServer.TextChanged += new System.EventHandler(this.cbServer_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(248, 21);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(82, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // rbAuthenticationWin
            // 
            this.rbAuthenticationWin.AutoSize = true;
            this.rbAuthenticationWin.Checked = true;
            this.rbAuthenticationWin.Location = new System.Drawing.Point(13, 20);
            this.rbAuthenticationWin.Name = "rbAuthenticationWin";
            this.rbAuthenticationWin.Size = new System.Drawing.Size(162, 17);
            this.rbAuthenticationWin.TabIndex = 3;
            this.rbAuthenticationWin.TabStop = true;
            this.rbAuthenticationWin.Text = "Use Windows Authentication";
            this.rbAuthenticationWin.UseVisualStyleBackColor = true;
            this.rbAuthenticationWin.CheckedChanged += new System.EventHandler(this.rbAuthenticationWin_CheckedChanged);
            // 
            // rbAuthenticationSql
            // 
            this.rbAuthenticationSql.AutoSize = true;
            this.rbAuthenticationSql.Location = new System.Drawing.Point(13, 42);
            this.rbAuthenticationSql.Name = "rbAuthenticationSql";
            this.rbAuthenticationSql.Size = new System.Drawing.Size(173, 17);
            this.rbAuthenticationSql.TabIndex = 4;
            this.rbAuthenticationSql.Text = "Use SQL Server Authentication";
            this.rbAuthenticationSql.CheckedChanged += new System.EventHandler(this.rbAuthenticationSql_CheckedChanged);
            // 
            // txtUser
            // 
            this.txtUser.Enabled = false;
            this.txtUser.Location = new System.Drawing.Point(81, 72);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(212, 20);
            this.txtUser.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(81, 98);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(212, 20);
            this.txtPassword.TabIndex = 8;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(22, 75);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(29, 13);
            this.lbUsuario.TabIndex = 9;
            this.lbUsuario.Text = "User";
            // 
            // lbClave
            // 
            this.lbClave.AutoSize = true;
            this.lbClave.Location = new System.Drawing.Point(22, 101);
            this.lbClave.Name = "lbClave";
            this.lbClave.Size = new System.Drawing.Size(53, 13);
            this.lbClave.TabIndex = 10;
            this.lbClave.Text = "Password";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(6, 322);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(82, 23);
            this.btnOK.TabIndex = 25;
            this.btnOK.Tag = "";
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCancel.Location = new System.Drawing.Point(94, 322);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 23);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnTest
            // 
            this.btnTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTest.Location = new System.Drawing.Point(248, 322);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(82, 23);
            this.btnTest.TabIndex = 26;
            this.btnTest.Text = "Test";
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // cbDataBase
            // 
            this.cbDataBase.FormattingEnabled = true;
            this.cbDataBase.Location = new System.Drawing.Point(25, 45);
            this.cbDataBase.Name = "cbDataBase";
            this.cbDataBase.Size = new System.Drawing.Size(268, 21);
            this.cbDataBase.TabIndex = 27;
            this.cbDataBase.DropDown += new System.EventHandler(this.cbDataBase_DropDown);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.lbBase);
            this.GroupBox1.Controls.Add(this.cbDataBase);
            this.GroupBox1.Location = new System.Drawing.Point(13, 195);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(317, 108);
            this.GroupBox1.TabIndex = 33;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Connect to database";
            // 
            // lbBase
            // 
            this.lbBase.AutoSize = true;
            this.lbBase.Location = new System.Drawing.Point(3, 29);
            this.lbBase.Name = "lbBase";
            this.lbBase.Size = new System.Drawing.Size(161, 13);
            this.lbBase.TabIndex = 36;
            this.lbBase.Text = "Select or enter a database name";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.txtPassword);
            this.GroupBox2.Controls.Add(this.txtUser);
            this.GroupBox2.Controls.Add(this.rbAuthenticationWin);
            this.GroupBox2.Controls.Add(this.lbUsuario);
            this.GroupBox2.Controls.Add(this.lbClave);
            this.GroupBox2.Controls.Add(this.rbAuthenticationSql);
            this.GroupBox2.Location = new System.Drawing.Point(13, 50);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(317, 128);
            this.GroupBox2.TabIndex = 34;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Log on to the server";
            // 
            // SQLServerConnectionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 357);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cbServer);
            this.Controls.Add(this.lbServidor);
            this.Controls.Add(this.GroupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SQLServerConnectionDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL Server Connection Dialog";
            this.Load += new System.EventHandler(this.SQLServerConnectionDialog_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal System.Windows.Forms.Label lbServidor;
        internal System.Windows.Forms.ComboBox cbServer;
        internal System.Windows.Forms.Button btnRefresh;
        internal System.Windows.Forms.RadioButton rbAuthenticationWin;
        internal System.Windows.Forms.RadioButton rbAuthenticationSql;
        internal System.Windows.Forms.TextBox txtUser;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.Label lbUsuario;
        internal System.Windows.Forms.Label lbClave;
        internal System.Windows.Forms.Button btnOK;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnTest;
        internal System.Windows.Forms.ComboBox cbDataBase;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label lbBase;
    }
}
﻿namespace TemplateFiller
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.cboConnections = new System.Windows.Forms.ComboBox();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTemplate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnCopyAll = new System.Windows.Forms.Button();
            this.btnConnectionBuilder = new System.Windows.Forms.Button();
            this.llblTemplateClear = new System.Windows.Forms.LinkLabel();
            this.llblResultsClear = new System.Windows.Forms.LinkLabel();
            this.llblQueryClear = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connection String";
            // 
            // cboConnections
            // 
            this.cboConnections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboConnections.FormattingEnabled = true;
            this.cboConnections.Location = new System.Drawing.Point(19, 28);
            this.cboConnections.Name = "cboConnections";
            this.cboConnections.Size = new System.Drawing.Size(873, 21);
            this.cboConnections.TabIndex = 2;
            this.cboConnections.Text = "data source=lani-vprcsh;initial catalog=ICMCentral;user id=svc_fusion;password=sv" +
    "c_fusion";
            // 
            // txtQuery
            // 
            this.txtQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuery.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuery.Location = new System.Drawing.Point(16, 70);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtQuery.Size = new System.Drawing.Size(909, 104);
            this.txtQuery.TabIndex = 3;
            this.txtQuery.Text = "SELECT name, Value, Description FROM dbo.Config";
            this.txtQuery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleSelectAll_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Query";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Template";
            // 
            // txtTemplate
            // 
            this.txtTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTemplate.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemplate.Location = new System.Drawing.Point(19, 202);
            this.txtTemplate.Multiline = true;
            this.txtTemplate.Name = "txtTemplate";
            this.txtTemplate.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTemplate.Size = new System.Drawing.Size(906, 104);
            this.txtTemplate.TabIndex = 5;
            this.txtTemplate.Text = "IF NOT EXISTS ( SELECT 1 FROM dbo.Config WHERE Name = \'{0}\') \r\nBEGIN\r\n    INSERT " +
    " dbo.Config (Name, Value, Description)\r\n    VALUES  (N\'{0}\', N\'{1}\', N\'{2}\')\r\nEN" +
    "D\r\n\r\n";
            this.txtTemplate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleSelectAll_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Results";
            // 
            // txtResults
            // 
            this.txtResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResults.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResults.Location = new System.Drawing.Point(19, 342);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResults.Size = new System.Drawing.Size(906, 314);
            this.txtResults.TabIndex = 7;
            this.txtResults.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleSelectAll_KeyDown);
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Location = new System.Drawing.Point(850, 662);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 9;
            this.btnGo.Text = "Go, Baby!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnCopyAll
            // 
            this.btnCopyAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCopyAll.Location = new System.Drawing.Point(19, 662);
            this.btnCopyAll.Name = "btnCopyAll";
            this.btnCopyAll.Size = new System.Drawing.Size(75, 23);
            this.btnCopyAll.TabIndex = 10;
            this.btnCopyAll.Text = "Copy All";
            this.btnCopyAll.UseVisualStyleBackColor = true;
            this.btnCopyAll.Click += new System.EventHandler(this.btnCopyAll_Click);
            // 
            // btnConnectionBuilder
            // 
            this.btnConnectionBuilder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnectionBuilder.Location = new System.Drawing.Point(898, 28);
            this.btnConnectionBuilder.Name = "btnConnectionBuilder";
            this.btnConnectionBuilder.Size = new System.Drawing.Size(27, 23);
            this.btnConnectionBuilder.TabIndex = 11;
            this.btnConnectionBuilder.Text = "...";
            this.btnConnectionBuilder.UseVisualStyleBackColor = true;
            this.btnConnectionBuilder.Click += new System.EventHandler(this.btnConnectionBuilder_Click);
            // 
            // llblTemplateClear
            // 
            this.llblTemplateClear.AutoSize = true;
            this.llblTemplateClear.Location = new System.Drawing.Point(71, 185);
            this.llblTemplateClear.Name = "llblTemplateClear";
            this.llblTemplateClear.Size = new System.Drawing.Size(31, 13);
            this.llblTemplateClear.TabIndex = 12;
            this.llblTemplateClear.TabStop = true;
            this.llblTemplateClear.Text = "Clear";
            this.llblTemplateClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblTemplateClear_LinkClicked);
            // 
            // llblResultsClear
            // 
            this.llblResultsClear.AutoSize = true;
            this.llblResultsClear.Location = new System.Drawing.Point(71, 326);
            this.llblResultsClear.Name = "llblResultsClear";
            this.llblResultsClear.Size = new System.Drawing.Size(31, 13);
            this.llblResultsClear.TabIndex = 13;
            this.llblResultsClear.TabStop = true;
            this.llblResultsClear.Text = "Clear";
            this.llblResultsClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblResultsClear_LinkClicked);
            // 
            // llblQueryClear
            // 
            this.llblQueryClear.AutoSize = true;
            this.llblQueryClear.Location = new System.Drawing.Point(71, 54);
            this.llblQueryClear.Name = "llblQueryClear";
            this.llblQueryClear.Size = new System.Drawing.Size(31, 13);
            this.llblQueryClear.TabIndex = 14;
            this.llblQueryClear.TabStop = true;
            this.llblQueryClear.Text = "Clear";
            this.llblQueryClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblQueryClear_LinkClicked);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 697);
            this.Controls.Add(this.llblQueryClear);
            this.Controls.Add(this.llblResultsClear);
            this.Controls.Add(this.llblTemplateClear);
            this.Controls.Add(this.btnConnectionBuilder);
            this.Controls.Add(this.btnCopyAll);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTemplate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.cboConnections);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stupid Template FIller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboConnections;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTemplate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnCopyAll;
        private System.Windows.Forms.Button btnConnectionBuilder;
        private System.Windows.Forms.LinkLabel llblTemplateClear;
        private System.Windows.Forms.LinkLabel llblResultsClear;
        private System.Windows.Forms.LinkLabel llblQueryClear;
    }
}


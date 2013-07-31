﻿namespace Tools
{
    partial class ToolDbScriptsForm
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
            this.btnViewDbInfo = new System.Windows.Forms.Button();
            this.listResult = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDbType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTableComment = new System.Windows.Forms.Button();
            this.btnColumns = new System.Windows.Forms.Button();
            this.cbTables = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnViewDbInfo
            // 
            this.btnViewDbInfo.Location = new System.Drawing.Point(35, 43);
            this.btnViewDbInfo.Name = "btnViewDbInfo";
            this.btnViewDbInfo.Size = new System.Drawing.Size(89, 23);
            this.btnViewDbInfo.TabIndex = 0;
            this.btnViewDbInfo.Text = "所有表名";
            this.btnViewDbInfo.UseVisualStyleBackColor = true;
            this.btnViewDbInfo.Click += new System.EventHandler(this.btnViewDbInfo_Click);
            // 
            // listResult
            // 
            this.listResult.FormattingEnabled = true;
            this.listResult.ItemHeight = 12;
            this.listResult.Location = new System.Drawing.Point(35, 217);
            this.listResult.Name = "listResult";
            this.listResult.Size = new System.Drawing.Size(816, 304);
            this.listResult.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "结果显示";
            // 
            // cbDbType
            // 
            this.cbDbType.FormattingEnabled = true;
            this.cbDbType.Items.AddRange(new object[] {
            "SQL Server",
            "Mysql"});
            this.cbDbType.Location = new System.Drawing.Point(258, 6);
            this.cbDbType.Name = "cbDbType";
            this.cbDbType.Size = new System.Drawing.Size(191, 20);
            this.cbDbType.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "数据库类型";
            // 
            // btnTableComment
            // 
            this.btnTableComment.Location = new System.Drawing.Point(130, 43);
            this.btnTableComment.Name = "btnTableComment";
            this.btnTableComment.Size = new System.Drawing.Size(89, 23);
            this.btnTableComment.TabIndex = 5;
            this.btnTableComment.Text = "所有表评论";
            this.btnTableComment.UseVisualStyleBackColor = true;
            this.btnTableComment.Click += new System.EventHandler(this.btnTableComment_Click);
            // 
            // btnColumns
            // 
            this.btnColumns.Location = new System.Drawing.Point(374, 46);
            this.btnColumns.Name = "btnColumns";
            this.btnColumns.Size = new System.Drawing.Size(75, 23);
            this.btnColumns.TabIndex = 6;
            this.btnColumns.Text = "所有列名";
            this.btnColumns.UseVisualStyleBackColor = true;
            this.btnColumns.Click += new System.EventHandler(this.btnColumns_Click);
            // 
            // cbTables
            // 
            this.cbTables.FormattingEnabled = true;
            this.cbTables.Location = new System.Drawing.Point(238, 46);
            this.cbTables.Name = "cbTables";
            this.cbTables.Size = new System.Drawing.Size(121, 20);
            this.cbTables.TabIndex = 7;
            this.cbTables.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbTables_MouseClick);
            // 
            // ToolDbScriptsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 552);
            this.Controls.Add(this.cbTables);
            this.Controls.Add(this.btnColumns);
            this.Controls.Add(this.btnTableComment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbDbType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listResult);
            this.Controls.Add(this.btnViewDbInfo);
            this.Name = "ToolDbScriptsForm";
            this.Text = "显示数据库信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewDbInfo;
        private System.Windows.Forms.ListBox listResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDbType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTableComment;
        private System.Windows.Forms.Button btnColumns;
        private System.Windows.Forms.ComboBox cbTables;
    }
}
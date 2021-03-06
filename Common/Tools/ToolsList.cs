﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tools
{
    public partial class ToolsList : Form
    {
        private ToolModifyFileForm modifyFileForm;
        private ToolDbScriptsForm dbScriptForm;
        public ToolsList()
        {
            InitializeComponent();
        }

        private void btnModifyFile_Click(object sender, EventArgs e)
        {
             modifyFileForm = new ToolModifyFileForm();
             modifyFileForm.Show();
             this.Hide();

        }

        private void showDbInfo_Click(object sender, EventArgs e)
        {
            dbScriptForm = new ToolDbScriptsForm();
            dbScriptForm.Show();
            this.Hide();
        }
    }
}

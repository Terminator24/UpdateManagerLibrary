﻿using System;
using System.Windows.Forms;

namespace UpdaterManagerLibrary
{
    internal partial class UpdateForm : Form
    {
        private string versionHistory;

        public UpdateForm(string versionHistory)
        {
            InitializeComponent();

            this.versionHistory = versionHistory;
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            richTextBoxChangelog.Rtf = (@"{\rtf1\ansi " + versionHistory.Replace("\n", @"\line") + @"}");
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            Close();
        }
    }
}

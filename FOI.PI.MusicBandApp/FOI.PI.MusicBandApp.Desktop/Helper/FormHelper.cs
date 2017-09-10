using System;
using System.Drawing;
using System.Windows.Forms;

namespace FOI.PI.MusicBandApp.Desktop.Helper
{
    public class FormHelper : Form
    {
        public FormHelper()
        {
            this.BackColor = Color.PapayaWhip;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public string GetHelpFilePath()
        {
            string ExecutingPath = AppDomain.CurrentDomain.BaseDirectory;
            return ExecutingPath + "MusicBandApp.chm";
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                Help.ShowHelp(this, GetHelpFilePath());
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}

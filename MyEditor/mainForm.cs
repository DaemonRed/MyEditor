using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewApp
{
    public partial class mainForm : Form
    {
        int wordCount, lineCount = 0;
        public mainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rtbTextArea_TextChanged(object sender, EventArgs e)
        {
            if (rtbTextArea.Text.Length == 0)
            {
                lblLineCount.Text = "Lines: 1";
                lblWordCount.Text = "Words: 0";
                return;
            }
                

            lineCount = rtbTextArea.Lines.Length;
            String[] textData = rtbTextArea.Text.Split(' ');
            lblLineCount.Text = "Lines: " + lineCount;
            lblWordCount.Text = "Words: " + textData.Length;
        }

        

    }
}

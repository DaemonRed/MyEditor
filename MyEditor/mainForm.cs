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
        int lineCount = 0;
        const String Title = "MyEditor v0.1";
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

        private void menuItemCopy_Click(object sender, EventArgs e)
        {
            rtbTextArea.Copy();
        }

        private void menuItemCut_Click(object sender, EventArgs e)
        {
            rtbTextArea.Cut();
        }

        private void menuItemPaste_Click(object sender, EventArgs e)
        {
            rtbTextArea.Paste();
        }

        private void menuItemDate_Click(object sender, EventArgs e)
        {
            rtbTextArea.Text = rtbTextArea.Text + DateTime.Now.ToString();
        }

        private void menuItemSelectAll_Click(object sender, EventArgs e)
        {
            rtbTextArea.SelectAll();
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusBar.Visible = (statusBar.Visible == true ? false : true);
             
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTextArea.SelectionFont = new Font(rtbTextArea.Font, FontStyle.Bold);
        }

        private void italicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTextArea.SelectionFont = new Font(rtbTextArea.Font, FontStyle.Italic);
        }

        private void fontMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = rtbTextArea.Font;
            fd.ShowColor = true;
            fd.Color = rtbTextArea.ForeColor;
            

            if (fd.ShowDialog() == DialogResult.OK)
            {
                rtbTextArea.Font = fd.Font;
                rtbTextArea.ForeColor = fd.Color;
            }
        }

        private void BGColourMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = rtbTextArea.BackColor;

            if (cd.ShowDialog() == DialogResult.OK)
                rtbTextArea.BackColor = cd.Color;
        }


        

    }
}

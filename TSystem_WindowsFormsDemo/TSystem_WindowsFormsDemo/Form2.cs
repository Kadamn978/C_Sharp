using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TSystem_WindowsFormsDemo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void notepadHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbNotePad.Cut();
        }


        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbNotePad.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbNotePad.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbNotePad.Clear();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbNotePad.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbNotePad.Redo();
        }

        private void selectALLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbNotePad.SelectAll();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sd = new SaveFileDialog();
                sd.DefaultExt = "*.txt";
                DialogResult dresult= sd.ShowDialog();
                if (dresult==DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(sd.FileName);
                    sw.WriteLine(rtbNotePad.Text);
                    sw.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog od = new OpenFileDialog();
                od.Filter = "Text FIle|*.txt|All Files| *.*|Doc File|*.docx";
                DialogResult dresult = od.ShowDialog();
                if (dresult == DialogResult.OK)
                {
                    StreamReader  sr = new StreamReader(od.FileName);
                    rtbNotePad.Text = sr.ReadToEnd();
                    sr.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}

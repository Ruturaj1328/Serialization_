using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog= new SaveFileDialog();
                saveFileDialog.Filter = "(*.txt )|*.txt |(*.docx ) |*.docx |(*.* All Files)|*.*";
                saveFileDialog.DefaultExt = "(*.txt )|*.txt |(*.docx ) |*.docx |(*.* All Files)|*.*";
                saveFileDialog.FileName = "myfile";
                DialogResult result= saveFileDialog.ShowDialog();
                if(result == DialogResult.OK)
                {
                    StreamWriter sw= new StreamWriter(saveFileDialog.FileName);
                    sw.WriteLine(richTextBox1.Text);
                    sw.Close();
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "(*.txt )|*.txt |(*.docx ) |*.docx |(*.* All Files)|*.*";
                openFileDialog.DefaultExt = "(*.txt )|*.txt |(*.docx ) |*.docx |(*.* All Files)|*.*";
                openFileDialog.FileName = "myfile";
                DialogResult result = openFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    StreamReader sr = new StreamReader(openFileDialog.FileName);
                    richTextBox1.Text = sr.ReadToEnd();
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }
    }
    }


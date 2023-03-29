using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCreatefolder_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"F:\New folder\Projectd ata";
                if (Directory.Exists(path))
                {
                    MessageBox.Show("Directory is already exist");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Directory is created");
                }
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
                

            
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {

            try
            {
                string path = @"F:\New folder\Projectd ata";
                if (File.Exists(path))
                {
                    MessageBox.Show("File is already exist");
                }
                else
                {
                    File.Create(path);
                    MessageBox.Show("File is created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnwrite_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"F:\New folder\Projectd ata";
                FileStream fs= new FileStream(path, FileMode.Create,FileAccess.Write);
                BinaryWriter bw= new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(txtDeptid.Text));
                bw.Write(txtDeptname.Text);
                bw.Write(txtLoaction.Text);
                bw.Close();
                fs.Close();
                MessageBox.Show("Data added to file");

            }
            catch( Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"F:\New folder\Projectd ata";
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
               txtDeptid.Text=br.ReadInt32().ToString();
                txtDeptname.Text = br.ReadString();
                txtLoaction.Text = br.ReadString();
                br.Close();
                fs.Close();
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

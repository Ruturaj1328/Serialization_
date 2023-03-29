using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnBinarywrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"F:\New folder\test\deptBinary.dat", FileMode.Create, FileAccess.Write);
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtDeptid.Text);
                dept.Name = txtDeptname.Text;
                dept.location = txtLoaction.Text;
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fs, dept);
                MessageBox.Show("Data Saved");
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBinaryread_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"F:\New folder\test\deptBinary.dat", FileMode.Open, FileAccess.Read);
                Department dept = new Department();
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                dept = (Department)binaryFormatter.Deserialize(fs);
                txtDeptid.Text = dept.Id.ToString();
                txtDeptname.Text = dept.Name;
                txtLoaction.Text = dept.location;
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnxmlwrite_Click(object sender, EventArgs e)
        {

            try
            {
                FileStream fs = new FileStream(@"F:\New folder\test\deptxml.xml", FileMode.Create, FileAccess.Write);
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtDeptid.Text);
                dept.Name = txtDeptname.Text;
                dept.location = txtLoaction.Text;
               XmlSerializer xmlSerializer= new XmlSerializer(typeof(Department));
                xmlSerializer.Serialize(fs, dept);
                MessageBox.Show("Data Saved");
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnxmlread_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"F:\New folder\test\deptxml.xml", FileMode.Open, FileAccess.Read);
                Department dept = new Department();
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Department));
                dept = (Department)xmlSerializer.Deserialize(fs);
                txtDeptid.Text = dept.Id.ToString();
                txtDeptname.Text = dept.Name;
                txtLoaction.Text = dept.location;
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnsoapwrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"F:\New folder\test\deptsoap.soap", FileMode.Create, FileAccess.Write);
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtDeptid.Text);
                dept.Name = txtDeptname.Text;
                dept.location = txtLoaction.Text;
                SoapFormatter soapFormatter=new SoapFormatter();
                soapFormatter.Serialize(fs, dept);
                MessageBox.Show("Data Saved");
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnsoapread_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"F:\New folder\test\deptsoap.soap", FileMode.Open, FileAccess.Read);
                Department dept = new Department();
                SoapFormatter soapFormatter = new SoapFormatter();
                dept = (Department)soapFormatter.Deserialize(fs);
                txtDeptid.Text = dept.Id.ToString();
                txtDeptname.Text = dept.Name;
                txtLoaction.Text = dept.location;
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnjsonwrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"F:\New folder\test\deptJson.json", FileMode.Create, FileAccess.Write);
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtDeptid.Text);
                dept.Name = txtDeptname.Text;
                dept.location = txtLoaction.Text;
               
                JsonSerializer.Serialize<Department>(fs, dept);
                MessageBox.Show("Data Saved");
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnjsonread_Click(object sender, EventArgs e)
        {

            try
            {
                FileStream fs = new FileStream(@"F:\New folder\test\deptJson.json", FileMode.Open, FileAccess.Read);
                Department dept = new Department();
              
                dept = JsonSerializer.Deserialize<Department>(fs);
                txtDeptid.Text = dept.Id.ToString();
                txtDeptname.Text = dept.Name;
                txtLoaction.Text = dept.location;
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

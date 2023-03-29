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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnBinarywrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"F:\New folder\Employee\empBinary.dat", FileMode.Create, FileAccess.Write);
               Employee emp= new Employee();
               emp.empid = Convert.ToInt32(txtempid.Text);
               emp.empname = txtempname.Text;
                emp.empdept = txtempdept.Text;
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fs, emp);
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
                FileStream fs = new FileStream(@"F:\New folder\Employee\empBinary.dat", FileMode.Open, FileAccess.Read);
                Employee emp = new Employee();
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                emp = (Employee)binaryFormatter.Deserialize(fs);
                txtempid.Text = emp.empid.ToString();
                txtempname.Text = emp.empname;
                txtempdept.Text = emp.empdept;
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
                FileStream fs = new FileStream(@"F:\New folder\Employee\empxml.xml", FileMode.Create, FileAccess.Write);
                Employee emp = new Employee();
                emp.empid = Convert.ToInt32(txtempid.Text);
                emp.empname = txtempname.Text;
                emp.empdept = txtempdept.Text;
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));
                xmlSerializer.Serialize(fs, emp);
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
                FileStream fs = new FileStream(@"F:\New folder\Employee\empxml.xml", FileMode.Open, FileAccess.Read);
                Employee emp = new Employee();
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));
                emp = (Employee)xmlSerializer.Deserialize(fs);
                txtempid.Text = emp.empid.ToString();
                txtempname.Text = emp.empname;
                txtempdept.Text = emp.empdept;
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
                FileStream fs = new FileStream(@"F:\New folder\Employee\empsoap.soap", FileMode.Create, FileAccess.Write);
                Employee emp = new Employee();
                emp.empid = Convert.ToInt32(txtempid.Text);
                emp.empname = txtempname.Text;
                emp.empdept = txtempdept.Text;
                SoapFormatter soapFormatter = new SoapFormatter();
                soapFormatter.Serialize(fs, emp);
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
                FileStream fs = new FileStream(@"F:\New folder\Employee\empsoap.soap", FileMode.Open, FileAccess.Read);
                Employee emp = new Employee();
                SoapFormatter soapFormatter = new SoapFormatter();
                emp = (Employee)soapFormatter.Deserialize(fs);
                txtempid.Text = emp.empid.ToString();
                txtempname.Text = emp.empname;
                txtempdept.Text = emp.empdept;
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
                FileStream fs = new FileStream(@"F:\New folder\Employee\empJson.json", FileMode.Create, FileAccess.Write);
                Employee emp = new Employee();
                emp.empid = Convert.ToInt32(txtempid.Text);
                emp.empname = txtempname.Text;
                emp.empdept = txtempdept.Text;
                JsonSerializer.Serialize<Employee>(fs, emp);
              
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
                FileStream fs = new FileStream(@"F:\New folder\Employee\empJson.json", FileMode.Open, FileAccess.Read);
                Employee emp = new Employee();
                emp = JsonSerializer.Deserialize<Employee>(fs);
              
                txtempid.Text = emp.empid.ToString();
                txtempname.Text = emp.empname;
                txtempdept.Text = emp.empdept;
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

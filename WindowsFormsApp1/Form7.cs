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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btnBinarywrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"F:\New folder\Student\studBinary.dat", FileMode.Create, FileAccess.Write);
               Student stud= new Student();
                stud.rollno= Convert.ToInt32(txtrollno.Text);
                stud.Name = txtname.Text;
               stud.Percentage = Convert.ToDouble(txtpercentage.Text);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fs, stud);
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
                FileStream fs = new FileStream(@"F:\New folder\Student\studBinary.dat", FileMode.Open, FileAccess.Read);
                Student stud = new Student();
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                stud = (Student)binaryFormatter.Deserialize(fs);
                txtrollno.Text = stud.rollno.ToString();
                txtname.Text = stud.Name;
                txtpercentage.Text = stud.Percentage.ToString();
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
                FileStream fs = new FileStream(@"F:\New folder\Student\studxml.xml", FileMode.Create, FileAccess.Write);
                Student stud = new Student();
                stud.rollno = Convert.ToInt32(txtrollno.Text);
                stud.Name = txtname.Text;
                stud.Percentage = Convert.ToDouble(txtpercentage.Text);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
                xmlSerializer.Serialize(fs, stud);
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
                FileStream fs = new FileStream(@"F:\New folder\Student\studxml.xml", FileMode.Open, FileAccess.Read);
                Student stud = new Student();
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
                stud = (Student)xmlSerializer.Deserialize(fs);
                txtrollno.Text = stud.rollno.ToString();
                txtname.Text = stud.Name;
                txtpercentage.Text = stud.Percentage.ToString();
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
                FileStream fs = new FileStream(@"F:\New folder\Student\studsoap.soap", FileMode.Create, FileAccess.Write);
                Student stud = new Student();
                stud.rollno = Convert.ToInt32(txtrollno.Text);
                stud.Name = txtname.Text;
                stud.Percentage = Convert.ToDouble(txtpercentage.Text);
                SoapFormatter soapFormatter = new SoapFormatter();
                soapFormatter.Serialize(fs, stud);
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
                FileStream fs = new FileStream(@"F:\New folder\Student\studsoap.soap", FileMode.Open, FileAccess.Read);
                Student stud = new Student();
                SoapFormatter soapFormatter = new SoapFormatter();
                stud = (Student)soapFormatter.Deserialize(fs);
                txtrollno.Text = stud.rollno.ToString();
                txtname.Text = stud.Name;
                txtpercentage.Text = stud.Percentage.ToString();
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
                FileStream fs = new FileStream(@"F:\New folder\Student\studJson.json", FileMode.Create, FileAccess.Write);
                Student stud = new Student();
                stud.rollno = Convert.ToInt32(txtrollno.Text);
                stud.Name = txtname.Text;
                stud.Percentage = Convert.ToDouble(txtpercentage.Text);
                JsonSerializer.Serialize<Student>(fs, stud);
              
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
                FileStream fs = new FileStream(@"F:\New folder\Student\studJson.json", FileMode.Open, FileAccess.Read);
                Student stud = new Student();
                stud = JsonSerializer.Deserialize<Student>(fs);

                txtrollno.Text = stud.rollno.ToString();
                txtname.Text = stud.Name;
                txtpercentage.Text = stud.Percentage.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

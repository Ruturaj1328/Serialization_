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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnBinarywrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"F:\New folder\Product\prodBinary.dat", FileMode.Create, FileAccess.Write);
                Product prod= new Product();
                prod.Id = Convert.ToInt32(txtproductid.Text);
                prod.Name = txtproductname.Text;
                prod.Price = Convert.ToInt32(txtprice.Text);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fs, prod);
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
                FileStream fs = new FileStream(@"F:\New folder\Product\prodBinary.dat", FileMode.Open, FileAccess.Read);
                Product prod = new Product();
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                prod = (Product)binaryFormatter.Deserialize(fs);
                txtproductid.Text = prod.Id.ToString();
                txtproductname.Text = prod.Name;
                txtprice.Text = prod.Price.ToString();
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
                FileStream fs = new FileStream(@"F:\New folder\Product\prodxml.xml", FileMode.Create, FileAccess.Write);
                Product prod = new Product();
                prod.Id = Convert.ToInt32(txtproductid.Text);
                prod.Name = txtproductname.Text;
                prod.Price = Convert.ToInt32(txtprice.Text);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Product));
                xmlSerializer.Serialize(fs, prod);
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
                FileStream fs = new FileStream(@"F:\New folder\Product\prodxml.xml", FileMode.Open, FileAccess.Read);
                Product prod = new Product();
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Product));
                prod = (Product)xmlSerializer.Deserialize(fs);
                txtproductid.Text = prod.Id.ToString();
                txtproductname.Text = prod.Name;
                txtprice.Text = prod.Price.ToString();
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
                FileStream fs = new FileStream(@"F:\New folder\Product\prodsoap.soap", FileMode.Create, FileAccess.Write);
                Product prod = new Product();
                prod.Id = Convert.ToInt32(txtproductid.Text);
                prod.Name = txtproductname.Text;
                prod.Price = Convert.ToInt32(txtprice.Text);
                SoapFormatter soapFormatter = new SoapFormatter();
                soapFormatter.Serialize(fs, prod);
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
                FileStream fs = new FileStream(@"F:\New folder\Product\prodsoap.soap", FileMode.Open, FileAccess.Read);
                Product prod = new Product();
                SoapFormatter soapFormatter = new SoapFormatter();
                prod = (Product)soapFormatter.Deserialize(fs);
                txtproductid.Text = prod.Id.ToString();
                txtproductname.Text = prod.Name;
                txtprice.Text = prod.Price.ToString();
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
                FileStream fs = new FileStream(@"F:\New folder\Product\prodJson.json", FileMode.Create, FileAccess.Write);
                Product prod = new Product();
                prod.Id = Convert.ToInt32(txtproductid.Text);
                prod.Name = txtproductname.Text;
                prod.Price = Convert.ToInt32(txtprice.Text);
                JsonSerializer.Serialize<Product>(fs, prod);
             
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
                FileStream fs = new FileStream(@"F:\New folder\Product\prodJson.json", FileMode.Open, FileAccess.Read);
                Product prod = new Product();

                prod = JsonSerializer.Deserialize<Product>(fs);

                txtproductid.Text = prod.Id.ToString();
                txtproductname.Text = prod.Name;
                txtprice.Text = prod.Price.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

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

namespace project
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
            
            string path = "mobiels.txt";

private void Form6_Load(object sender, EventArgs e)
        {
            if (!File.Exists(path))
            {
                MessageBox.Show("No Data");
                return;
            }

            StreamReader reader = new StreamReader(path);

            string allData = "";

            while (!reader.EndOfStream)
            {
                string id = reader.ReadLine();
                string name = reader.ReadLine();
                string brand = reader.ReadLine();
                string price = reader.ReadLine();
                reader.ReadLine(); // -----

                allData += "ID: " + id +
                           "\r\nName: " + name +
                           "\r\nBrand: " + brand +
                           "\r\nPrice: " + price +
                           "\r\n-----------------\r\n";
            }

            reader.Close();

            richTextBox1.Text = allData;
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

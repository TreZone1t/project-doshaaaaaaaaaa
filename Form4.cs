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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }


            string path = "mobiels.txt";
        
private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtId2.Text == "")
            {
                MessageBox.Show("ادخل ID");
                return;
            }

            if (!File.Exists(path))
            {
                MessageBox.Show("No Data");
                return;
            }

            StreamReader reader = new StreamReader(path);

            while (!reader.EndOfStream)
            {
                string id = reader.ReadLine();
                string name = reader.ReadLine();
                string brand = reader.ReadLine();
                string price = reader.ReadLine();
                reader.ReadLine(); // -----

                if (id == txtId2.Text)
                {
                    MessageBox.Show(
                        "Name: " + name +
                        "\nBrand: " + brand +
                        "\nPrice: " + price
                    );
                    reader.Close();
                    return;
                }
            }

            reader.Close();
            MessageBox.Show("Not Found");
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }
    }
    }


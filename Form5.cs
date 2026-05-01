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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

            string path = "mobiles.txt";

private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (txtid3.Text == "")
            {
                MessageBox.Show("ادخل ID");
                return;
            }

            if (!File.Exists(path))
            {
                MessageBox.Show("No Data");
                return;
            }

            List<string> newData = new List<string>();

            StreamReader reader = new StreamReader(path);

            bool found = false;

            while (!reader.EndOfStream)
            {
                string id = reader.ReadLine();
                string name = reader.ReadLine();
                string brand = reader.ReadLine();
                string price = reader.ReadLine();
                reader.ReadLine(); // -----

                if (id == txtid3.Text)
                {
                    found = true; // متحذفش السطر
                    continue;
                }

                // ضيف البيانات الجديدة
                newData.Add(id);
                newData.Add(name);
                newData.Add(brand);
                newData.Add(price);
                newData.Add("-----");
            }

            reader.Close();

            // إعادة كتابة الملف
            StreamWriter writer = new StreamWriter(path, false);

            foreach (var line in newData)
            {
                writer.WriteLine(line);
            }

            writer.Close();

            if (found)
                MessageBox.Show("تم الحذف");
            else
                MessageBox.Show("ID مش موجود");
        }

        private void textBoxEnterID_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }


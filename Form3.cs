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
using System.Xml.Linq;

namespace project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        // السطر ده بيخلي الملف يتحفظ في فولدر الـ Documents الخاص بالمستخدم
        string path = "mobiels.txt";

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // ✅ تحقق من البيانات
            if (txtId.Text == "" || txtName.Text == "" || txtprice.Text == "" || txtBrand.Text == "")
            {
                MessageBox.Show("املى كل البيانات");
                return;
            }

            // ✅ حفظ في الملف
            StreamWriter writer = new StreamWriter(path, true);

            writer.WriteLine(txtId.Text);
            writer.WriteLine(txtName.Text);
            writer.WriteLine(txtBrand.Text);
            writer.WriteLine(txtprice.Text);
            writer.WriteLine("-----");

            writer.Close();

            MessageBox.Show("تم الحفظ");

            // تفريغ الحقول
            txtId.Clear();
            txtName.Clear();
            txtBrand.Clear();
            txtprice.Clear();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form2 f2  = new Form2();  // يفتح شاشة الاختيارات
            f2.Show();
            this.Hide();              // يخفي الفورم الحالي
        }
    }
    }
    


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textboxUsername.Text;
            string password = textboxPassword.Text;

            // لو فاضي
            if (username == "" || password == "")
            {
                MessageBox.Show("Enter Username and Password");
                return;
            }

            // تحقق من البيانات
            if (username == "admin" && password == "1911")
            {
                MessageBox.Show("Login Success");

                Form2 f2 = new Form2();
                f2.Show();

                this.Hide(); // يخفي اللوجين
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
        }
    }
}

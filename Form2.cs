using System;
using System.IO;
using System.Windows.Forms;

namespace project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string path = "mobiels.txt";

        private void buttonSearchMobile_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
            this.Hide();
        }

        private void buttonDeleteMobile_Click(object sender, EventArgs e)
        {

            { 
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }// فورم الحذف
        }

        private void buttonAddMobile_Click(object sender, EventArgs e)
        {
            // فورم الإضافة
        }

        private void buttonViewMobiles_Click(object sender, EventArgs e)
        {
            
        
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }
    }
    }

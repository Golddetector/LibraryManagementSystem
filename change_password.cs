using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Mangment_System
{
    public partial class change_password : Form
    {
        public change_password()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();
            Staff staff = databaseHelper.search_staff(databaseHelper.currently_logged());
            if (staff.password == textBox1.Text && textBox2.Text == textBox3.Text && staff.password != textBox2.Text)
            {
                databaseHelper.change_password(databaseHelper.currently_logged(), textBox2.Text);
                MessageBox.Show("Change");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            else if (staff.password == textBox2.Text)
            {
                MessageBox.Show("Previous password and new password have to be different");

            }
            else if(textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("New password and Confirm password have to be the same");
            }
            else
            {
                MessageBox.Show("Current password incorrect");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            

        }
    }
}

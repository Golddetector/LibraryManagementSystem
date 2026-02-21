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
    public partial class viewprofile : Form
    {
        public viewprofile()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void viewprofile_Load(object sender, EventArgs e)
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();
            int i = databaseHelper.currently_logged();
            Staff staff = databaseHelper.search_staff(i);
            label9.Text = (staff.id).ToString();
            label10.Text = staff.fname;
            label11.Text = staff.lname;
            label12.Text = staff.email;
            label13.Text = (staff.salary).ToString();
            label14.Text = (staff.date_of_birth).ToString();
            label15.Text = staff.username;
            label16.Text = (staff.admin).ToString();
            if (staff.admin != true)
            {
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            change_password ch = new change_password();
            ch.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_staff add_Staff = new Add_staff();
            add_Staff.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            update_staff update_Staff = new update_staff();
            update_Staff.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            view_staff view_staff = new view_staff();
            view_staff.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

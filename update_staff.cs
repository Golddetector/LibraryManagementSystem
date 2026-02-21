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
    public partial class update_staff : Form
    {
        public update_staff()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox7.Text))
            {
                MessageBox.Show("Book ID Can't Be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DatabaseHelper databaseHelper = new DatabaseHelper();
                    Staff student = databaseHelper.search_staff(int.Parse(textBox7.Text));
                    textBox1.Text = student.fname;
                    textBox2.Text = student.lname;
                    textBox3.Text = student.email;
                    textBox4.Text = (student.salary).ToString();
                    dateTimePicker1.Value = student.date_of_birth;
                    checkBox1.Checked = student.admin;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("id not found");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox7.Text = string.Empty;
            checkBox1.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
               string.IsNullOrWhiteSpace(textBox2.Text) ||
               string.IsNullOrWhiteSpace(textBox3.Text) ||
               string.IsNullOrWhiteSpace(textBox4.Text) ||
               string.IsNullOrWhiteSpace(textBox7.Text))
            {
                MessageBox.Show("INPUT IN ALL VALUES", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DatabaseHelper databaseHelper = new DatabaseHelper();
                    databaseHelper.update_staff(int.Parse(textBox7.Text), textBox1.Text, textBox2.Text, textBox3.Text, int.Parse(textBox4.Text), Convert.ToDateTime(dateTimePicker1.Value), checkBox1.Checked);
                    button2_Click(sender, e);
                    MessageBox.Show("Completed");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter valid inputs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
               string.IsNullOrWhiteSpace(textBox2.Text) ||
               string.IsNullOrWhiteSpace(textBox3.Text) ||
               string.IsNullOrWhiteSpace(textBox4.Text) ||
               string.IsNullOrWhiteSpace(textBox7.Text))
            {
                MessageBox.Show("INPUT IN ALL VALUES", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DatabaseHelper databaseHelper = new DatabaseHelper();
                    databaseHelper.delete_staff(int.Parse(textBox7.Text));
                    button2_Click(sender, e);
                    MessageBox.Show("Completed");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter valid inputs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void update_staff_Load(object sender, EventArgs e)
        {

        }
    }
}

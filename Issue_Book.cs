using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_Mangment_System
{
    public partial class Issue_Book : Form
    {
        public Issue_Book()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox7.Text))
            {
                MessageBox.Show("INPUT IN ALL VALUES", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DateTime currenttime = DateTime.UtcNow.AddHours(3);
                    Book book = new Book(int.Parse(textBox5.Text), currenttime, dateTimePicker2.Value);
                    book.issuee_book(int.Parse(textBox7.Text));
                    button2_Click(sender, e);
                    confirmation_page();
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

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox7.Text = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox7.Text))
            {
                MessageBox.Show("ID Number Can't Be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DatabaseHelper databaseHelper = new DatabaseHelper();
                    Student student = databaseHelper.search_student(int.Parse(textBox7.Text));
                    textBox1.Text = student.name;
                    textBox2.Text = student.department;
                    textBox3.Text = student.phone_number;
                    textBox4.Text = student.email;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void confirmation_page()
        {
            MessageBox.Show("Complete");
        }
    }
}

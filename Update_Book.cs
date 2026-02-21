using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_Mangment_System
{
    public partial class Update_Book : Form
    {
        public Update_Book()
        {
            InitializeComponent();
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
                    Book book = databaseHelper.search_book(int.Parse(textBox7.Text));
                    textBox1.Text = book.name;
                    textBox2.Text = book.author_name;
                    dateTimePicker2.Value = book.publication;
                    dateTimePicker1.Value = book.purchase_date;
                    textBox5.Text = book.price.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Id not found");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text) ||
                string.IsNullOrWhiteSpace(textBox7.Text))
            {
                MessageBox.Show("INPUT IN ALL VALUES", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Book book = new Book(textBox1.Text, textBox2.Text, dateTimePicker2.Value, dateTimePicker1.Value, Double.Parse(textBox5.Text), default, int.Parse(textBox7.Text));
                    book.update_book();
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
            textBox5.Text = string.Empty;
            textBox7.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
               string.IsNullOrWhiteSpace(textBox2.Text) ||
               string.IsNullOrWhiteSpace(textBox5.Text) ||
               string.IsNullOrWhiteSpace(textBox7.Text))
            {
                MessageBox.Show("INPUT IN ALL VALUES", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Book book = new Book(textBox1.Text, textBox2.Text, dateTimePicker2.Value, dateTimePicker1.Value, Double.Parse(textBox5.Text), default, int.Parse(textBox7.Text));
                    book.delete_book();
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
        private void confirmation_page()
        {
            MessageBox.Show("Complete");
        }
    }
}

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
    public partial class ViewBooks : Form
    {
        public ViewBooks()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                if (string.IsNullOrEmpty(textBox1.Text) || int.Parse(textBox1.Text) <= 0) i = -1;
                else i = int.Parse(textBox1.Text);
                DatabaseHelper databaseHelper = new DatabaseHelper();
                DataTable dt = databaseHelper.display_book_table(i);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

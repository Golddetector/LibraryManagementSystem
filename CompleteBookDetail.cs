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
    public partial class CompleteBookDetail : Form
    {
        public CompleteBookDetail()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();
            DataTable dt = databaseHelper.display_issued_table();
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();
            DataTable dt = databaseHelper.display_returned_table();
            dataGridView2.DataSource = dt;
        }
    }
}

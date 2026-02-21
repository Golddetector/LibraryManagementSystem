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
    public partial class Dashbord : Form
    {
        public Dashbord()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Clear the panel before loading a new form
            panelContainer.Controls.Clear();

            // Create an instance of the Add_books form
            Add_books book = new Add_books();

            // Set the form properties to embed it inside the panel
            book.TopLevel = false;
            book.FormBorderStyle = FormBorderStyle.None;
            book.Dock = DockStyle.Fill;

            // Add the form to the panel and display it
            panelContainer.Controls.Add(book);
            book.Show();
        }

        private void viewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            ViewBooks viewbook = new ViewBooks();
            viewbook.TopLevel = false;
            viewbook.FormBorderStyle = FormBorderStyle.None;
            viewbook.Dock = DockStyle.None;
            panelContainer.Controls.Add((viewbook));
            viewbook.Show();
        }

        private void updateBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            Update_Book update_book = new Update_Book();
            update_book.TopLevel = false;
            update_book.FormBorderStyle = FormBorderStyle.None;
            update_book.Dock = DockStyle.None;
            panelContainer.Controls.Add(update_book);
            update_book.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            Add_Student student = new Add_Student();
            student.TopLevel = false;
            student.FormBorderStyle = FormBorderStyle.None;
            student.Dock = DockStyle.None;
            panelContainer.Controls.Add(student);
            student.Show();
        }

        private void viewStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            Student_Info student = new Student_Info();
            student.TopLevel = false;
            student.FormBorderStyle = FormBorderStyle.None;
            student.Dock = DockStyle.None;
            panelContainer.Controls.Add(student);
            student.Show();
        }

        private void issueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            Issue_Book issuebook = new Issue_Book();
            issuebook.TopLevel = false;
            issuebook.FormBorderStyle = FormBorderStyle.None;
            issuebook.Dock = DockStyle.None;
            panelContainer.Controls.Add(issuebook);
            issuebook.Show();
        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            Return_Book returnbook = new Return_Book();
            returnbook.TopLevel = false;
            returnbook.FormBorderStyle = FormBorderStyle.None;
            returnbook.Dock = DockStyle.None;
            panelContainer.Controls.Add(returnbook);
            returnbook.Show();
        }

        private void completeBookDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            CompleteBookDetail book_detail = new CompleteBookDetail();
            book_detail.TopLevel = false;
            book_detail.FormBorderStyle = FormBorderStyle.None;
            book_detail.Dock = DockStyle.None;
            panelContainer.Controls.Add(book_detail);
            book_detail.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            Update_Student update_student = new Update_Student();
            update_student.TopLevel = false;
            update_student.FormBorderStyle = FormBorderStyle.None;
            update_student.Dock = DockStyle.None;
            panelContainer.Controls.Add(update_student);
            update_student.Show();
        }

        private void Dashbord_FormClosing(object sender, FormClosingEventArgs e)
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();
            databaseHelper.log_out();
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            viewprofile update_student = new viewprofile();
            update_student.TopLevel = false;
            update_student.FormBorderStyle = FormBorderStyle.None;
            update_student.Dock = DockStyle.None;
            panelContainer.Controls.Add(update_student);
            update_student.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        bool bookmenuExpand = false;

        private void BookMenuTransition_Tick(object sender, EventArgs e)
        {
            if (!bookmenuExpand)
            {
                BookMenuContainer.Height += 10;
                if (BookMenuContainer.Height >= 389)
                {
                    BookMenuTransition.Stop();
                    bookmenuExpand = true; // Set to true when fully expanded
                }
            }
            else
            {
                BookMenuContainer.Height -= 10;
                if (BookMenuContainer.Height <= 57)
                {
                    BookMenuTransition.Stop();
                    bookmenuExpand = false; // Set to false when fully collapsed
                }
            }
        }

        private void Book_menu_Click(object sender, EventArgs e)
        {
            BookMenuTransition.Start();
        }

        bool StudentmenuExpand = false;

        private void StudentMenuTransition_Tick(object sender, EventArgs e)
        {
            if (!StudentmenuExpand)
            {
                // Expand the menu
                StudentMenuContainer.Height += 10;
                if (StudentMenuContainer.Height >= 227)
                {
                    StudentMenuTransition.Stop();
                    StudentmenuExpand = true; // Set to true when fully expanded
                }
            }
            else
            {
                // Collapse the menu
                StudentMenuContainer.Height -= 10;
                if (StudentMenuContainer.Height <= 57)
                {
                    StudentMenuTransition.Stop();
                    StudentmenuExpand = false; // Set to false when fully collapsed
                }
            }
        }

        private void student_Menu_Click(object sender, EventArgs e)
        {
            // Toggle the expand/collapse state

            StudentMenuTransition.Start();
        }

        bool sidebarExpand = false;

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                DasboardPanel.Width -= 10;
                if (DasboardPanel.Width <= 84)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                DasboardPanel.Width += 10;
                if (DasboardPanel.Width >= 272)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void btn_dasboard_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contain_menu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

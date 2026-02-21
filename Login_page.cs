using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Library_Mangment_System
{
    public partial class Login_page : Form
    {
        public Login_page()
        {
            InitializeComponent();
        }

        private void Login_page_Load(object sender, EventArgs e)
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();
            databaseHelper.check_if_staff_is_empty();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(password_box.Text))
                MessageBox.Show("Password is empty");
            else if (string.IsNullOrEmpty(username_box.Text))
                MessageBox.Show("Username is empty");
            else
            {
                DatabaseHelper databaseHelper = new DatabaseHelper();
                int i = databaseHelper.check_user(username_box.Text, password_box.Text);
                if (i == 1)
                {
                    Dashbord dashbord = new Dashbord();
                    this.Hide();  
                    dashbord.ShowDialog();  
                    this.Show();  
                }
                else
                {
                    MessageBox.Show("Incorrect username and password");
                }
            }
        }





    }
}

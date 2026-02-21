namespace Library_Mangment_System
{
    partial class Dashbord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            panelContainer = new Panel();
            StudentMenuContainer = new FlowLayoutPanel();
            student_Menu = new Button();
            button9 = new Button();
            BookMenuContainer = new FlowLayoutPanel();
            Book_menu = new Button();
            button10 = new Button();
            panel1 = new Panel();
            label2 = new Label();
            btn_dasboard = new PictureBox();
            BookMenuTransition = new System.Windows.Forms.Timer(components);
            StudentMenuTransition = new System.Windows.Forms.Timer(components);
            DasboardPanel = new Panel();
            contain_menu = new FlowLayoutPanel();
            btn_logout = new Button();
            label1 = new Label();
            sidebarTransition = new System.Windows.Forms.Timer(components);
            StudentMenuContainer.SuspendLayout();
            BookMenuContainer.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_dasboard).BeginInit();
            DasboardPanel.SuspendLayout();
            contain_menu.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.AntiqueWhite;
            button1.Image = Properties.Resources.icons8_add_50;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 57);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(178, 57);
            button1.TabIndex = 1;
            button1.Text = "Add Books";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += addNewBookToolStripMenuItem_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.AntiqueWhite;
            button2.Image = Properties.Resources.icons8_view_50;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 114);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(178, 57);
            button2.TabIndex = 2;
            button2.Text = "View Books";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += viewBookToolStripMenuItem_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.AntiqueWhite;
            button3.Image = Properties.Resources.icons8_update_50;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 171);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(178, 57);
            button3.TabIndex = 3;
            button3.Text = "   Update Book";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            button3.Click += updateBookToolStripMenuItem_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.AntiqueWhite;
            button4.Image = Properties.Resources.icons8_student_registration_50;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 57);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(178, 57);
            button4.TabIndex = 4;
            button4.Text = "Add Student";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = false;
            button4.Click += addStudentToolStripMenuItem_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.AntiqueWhite;
            button5.Image = Properties.Resources.icons8_info_50;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 171);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(178, 57);
            button5.TabIndex = 5;
            button5.Text = "View Student Info";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.UseVisualStyleBackColor = false;
            button5.Click += viewStudentInfoToolStripMenuItem_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.AntiqueWhite;
            button6.Image = Properties.Resources.icons8_buy_50;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(0, 228);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Size = new Size(178, 57);
            button6.TabIndex = 6;
            button6.Text = "Issue Book";
            button6.TextAlign = ContentAlignment.MiddleRight;
            button6.UseVisualStyleBackColor = false;
            button6.Click += issueBooksToolStripMenuItem_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.AntiqueWhite;
            button7.Image = Properties.Resources.icons8_return_50;
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(0, 342);
            button7.Margin = new Padding(0);
            button7.Name = "button7";
            button7.Size = new Size(178, 57);
            button7.TabIndex = 7;
            button7.Text = "   Return Books";
            button7.TextAlign = ContentAlignment.MiddleRight;
            button7.UseVisualStyleBackColor = false;
            button7.Click += returnBooksToolStripMenuItem_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.AntiqueWhite;
            button8.Image = Properties.Resources.icons8_details_50;
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(0, 285);
            button8.Margin = new Padding(0);
            button8.Name = "button8";
            button8.Size = new Size(178, 57);
            button8.TabIndex = 8;
            button8.Text = "   Book Details";
            button8.TextAlign = ContentAlignment.MiddleRight;
            button8.UseVisualStyleBackColor = false;
            button8.Click += completeBookDetailToolStripMenuItem_Click;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.SeaShell;
            panelContainer.Location = new Point(275, 50);
            panelContainer.Margin = new Padding(0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(906, 777);
            panelContainer.TabIndex = 18;
            panelContainer.Paint += panelContainer_Paint;
            // 
            // StudentMenuContainer
            // 
            StudentMenuContainer.BackColor = Color.AntiqueWhite;
            StudentMenuContainer.Controls.Add(student_Menu);
            StudentMenuContainer.Controls.Add(button4);
            StudentMenuContainer.Controls.Add(button9);
            StudentMenuContainer.Controls.Add(button5);
            StudentMenuContainer.Location = new Point(3, 129);
            StudentMenuContainer.Name = "StudentMenuContainer";
            StudentMenuContainer.Size = new Size(211, 57);
            StudentMenuContainer.TabIndex = 1;
            // 
            // student_Menu
            // 
            student_Menu.BackColor = Color.AntiqueWhite;
            student_Menu.Image = Properties.Resources.icons8_manage_50;
            student_Menu.ImageAlign = ContentAlignment.MiddleLeft;
            student_Menu.Location = new Point(0, 0);
            student_Menu.Margin = new Padding(0);
            student_Menu.Name = "student_Menu";
            student_Menu.Size = new Size(209, 57);
            student_Menu.TabIndex = 6;
            student_Menu.Text = "Manage Student";
            student_Menu.TextAlign = ContentAlignment.MiddleRight;
            student_Menu.UseVisualStyleBackColor = false;
            student_Menu.Click += student_Menu_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.AntiqueWhite;
            button9.Image = Properties.Resources.icons8_update_file_50;
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.Location = new Point(0, 114);
            button9.Margin = new Padding(0);
            button9.Name = "button9";
            button9.Size = new Size(178, 57);
            button9.TabIndex = 0;
            button9.Text = "Update Student";
            button9.TextAlign = ContentAlignment.MiddleRight;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // BookMenuContainer
            // 
            BookMenuContainer.BackColor = Color.AntiqueWhite;
            BookMenuContainer.Controls.Add(Book_menu);
            BookMenuContainer.Controls.Add(button1);
            BookMenuContainer.Controls.Add(button2);
            BookMenuContainer.Controls.Add(button3);
            BookMenuContainer.Controls.Add(button6);
            BookMenuContainer.Controls.Add(button8);
            BookMenuContainer.Controls.Add(button7);
            BookMenuContainer.Location = new Point(3, 66);
            BookMenuContainer.Name = "BookMenuContainer";
            BookMenuContainer.Size = new Size(209, 57);
            BookMenuContainer.TabIndex = 0;
            // 
            // Book_menu
            // 
            Book_menu.BackColor = Color.AntiqueWhite;
            Book_menu.Image = Properties.Resources.icons8_books_50;
            Book_menu.ImageAlign = ContentAlignment.MiddleLeft;
            Book_menu.Location = new Point(0, 0);
            Book_menu.Margin = new Padding(0);
            Book_menu.Name = "Book_menu";
            Book_menu.Size = new Size(210, 57);
            Book_menu.TabIndex = 9;
            Book_menu.Text = "       Manage Books";
            Book_menu.TextAlign = ContentAlignment.MiddleRight;
            Book_menu.UseVisualStyleBackColor = false;
            Book_menu.Click += Book_menu_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.AntiqueWhite;
            button10.Image = Properties.Resources.profile_50;
            button10.ImageAlign = ContentAlignment.MiddleLeft;
            button10.Location = new Point(3, 3);
            button10.Name = "button10";
            button10.Size = new Size(210, 57);
            button10.TabIndex = 0;
            button10.Text = "My Profile";
            button10.TextAlign = ContentAlignment.MiddleRight;
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AntiqueWhite;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btn_dasboard);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1181, 52);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.AntiqueWhite;
            label2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(327, 4);
            label2.Name = "label2";
            label2.Size = new Size(552, 46);
            label2.TabIndex = 1;
            label2.Text = "Library Management System";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_dasboard
            // 
            btn_dasboard.BackColor = Color.White;
            btn_dasboard.Image = Properties.Resources.hamburger;
            btn_dasboard.Location = new Point(55, 12);
            btn_dasboard.Name = "btn_dasboard";
            btn_dasboard.Size = new Size(29, 25);
            btn_dasboard.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_dasboard.TabIndex = 0;
            btn_dasboard.TabStop = false;
            btn_dasboard.Click += btn_dasboard_Click;
            // 
            // BookMenuTransition
            // 
            BookMenuTransition.Interval = 5;
            BookMenuTransition.Tick += BookMenuTransition_Tick;
            // 
            // StudentMenuTransition
            // 
            StudentMenuTransition.Interval = 5;
            StudentMenuTransition.Tick += StudentMenuTransition_Tick;
            // 
            // DasboardPanel
            // 
            DasboardPanel.BackColor = Color.AntiqueWhite;
            DasboardPanel.Controls.Add(contain_menu);
            DasboardPanel.Controls.Add(label1);
            DasboardPanel.Dock = DockStyle.Left;
            DasboardPanel.Location = new Point(0, 52);
            DasboardPanel.Name = "DasboardPanel";
            DasboardPanel.Size = new Size(272, 775);
            DasboardPanel.TabIndex = 2;
            // 
            // contain_menu
            // 
            contain_menu.AutoScroll = true;
            contain_menu.Controls.Add(button10);
            contain_menu.Controls.Add(BookMenuContainer);
            contain_menu.Controls.Add(StudentMenuContainer);
            contain_menu.Controls.Add(btn_logout);
            contain_menu.Location = new Point(12, 42);
            contain_menu.Name = "contain_menu";
            contain_menu.Size = new Size(260, 706);
            contain_menu.TabIndex = 0;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.AntiqueWhite;
            btn_logout.BackgroundImageLayout = ImageLayout.None;
            btn_logout.Image = Properties.Resources.icons8_logout_50;
            btn_logout.ImageAlign = ContentAlignment.MiddleLeft;
            btn_logout.Location = new Point(3, 192);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(210, 57);
            btn_logout.TabIndex = 2;
            btn_logout.Text = "Logout";
            btn_logout.TextAlign = ContentAlignment.MiddleRight;
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(96, 0);
            label1.Name = "label1";
            label1.Size = new Size(173, 39);
            label1.TabIndex = 2;
            label1.Text = "Dasboard";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // Dashbord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1181, 827);
            Controls.Add(DasboardPanel);
            Controls.Add(panel1);
            Controls.Add(panelContainer);
            Name = "Dashbord";
            Text = "Dashboard";
            FormClosing += Dashbord_FormClosing;
            Load += Form1_Load;
            StudentMenuContainer.ResumeLayout(false);
            BookMenuContainer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_dasboard).EndInit();
            DasboardPanel.ResumeLayout(false);
            DasboardPanel.PerformLayout();
            contain_menu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Panel panelContainer;
        private Button button9;
        private Button button10;
        private PictureBox btn_dasboard;
        private Panel panel1;
        private FlowLayoutPanel StudentMenuContainer;
        private FlowLayoutPanel BookMenuContainer;
        private Button student_Menu;
        private Button Book_menu;
        private System.Windows.Forms.Timer BookMenuTransition;
        private System.Windows.Forms.Timer StudentMenuTransition;
        private Panel DasboardPanel;
        private System.Windows.Forms.Timer sidebarTransition;
        private Label label1;
        private Label label2;
        private FlowLayoutPanel contain_menu;
        private Button btn_logout;
    }
}
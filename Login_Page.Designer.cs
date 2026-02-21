namespace Library_Mangment_System
{
    partial class Login_page
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            login_button = new Button();
            label2 = new Label();
            username_box = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            label3 = new Label();
            password_box = new Guna.UI2.WinForms.Guna2TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // login_button
            // 
            login_button.BackColor = Color.Tan;
            login_button.BackgroundImageLayout = ImageLayout.None;
            login_button.FlatStyle = FlatStyle.Popup;
            login_button.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_button.ForeColor = SystemColors.ActiveCaptionText;
            login_button.Location = new Point(562, 355);
            login_button.Name = "login_button";
            login_button.Size = new Size(179, 38);
            login_button.TabIndex = 8;
            login_button.Text = "Login";
            login_button.UseVisualStyleBackColor = false;
            login_button.Click += login_button_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(479, 188);
            label2.Name = "label2";
            label2.Size = new Size(117, 23);
            label2.TabIndex = 11;
            label2.Text = "User Name";
            // 
            // username_box
            // 
            username_box.BorderColor = Color.Gray;
            username_box.BorderRadius = 10;
            username_box.BorderThickness = 2;
            username_box.CustomizableEdges = customizableEdges1;
            username_box.DefaultText = "";
            username_box.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            username_box.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            username_box.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            username_box.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            username_box.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            username_box.Font = new Font("Segoe UI", 9F);
            username_box.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            username_box.Location = new Point(630, 179);
            username_box.Margin = new Padding(3, 4, 3, 4);
            username_box.Name = "username_box";
            username_box.PasswordChar = '\0';
            username_box.PlaceholderText = "";
            username_box.SelectedText = "";
            username_box.ShadowDecoration.CustomizableEdges = customizableEdges2;
            username_box.Size = new Size(188, 32);
            username_box.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(562, 61);
            label1.Name = "label1";
            label1.Size = new Size(138, 27);
            label1.TabIndex = 10;
            label1.Text = "WELCOME!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(479, 254);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 13;
            label3.Text = "Password";
            // 
            // password_box
            // 
            password_box.BorderColor = Color.Gray;
            password_box.BorderRadius = 10;
            password_box.BorderThickness = 2;
            password_box.CustomizableEdges = customizableEdges3;
            password_box.DefaultText = "";
            password_box.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            password_box.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            password_box.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            password_box.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            password_box.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            password_box.Font = new Font("Segoe UI", 9F);
            password_box.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            password_box.Location = new Point(630, 254);
            password_box.Margin = new Padding(3, 4, 3, 4);
            password_box.Name = "password_box";
            password_box.PasswordChar = '*';
            password_box.PlaceholderText = "";
            password_box.SelectedText = "";
            password_box.ShadowDecoration.CustomizableEdges = customizableEdges4;
            password_box.Size = new Size(188, 32);
            password_box.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.lms_ezgif_com_webp_to_jpg_converter;
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(424, 492);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // Login_page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(849, 490);
            Controls.Add(pictureBox1);
            Controls.Add(password_box);
            Controls.Add(label3);
            Controls.Add(username_box);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(login_button);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Login_page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login ";
            Load += Login_page_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Password_box_Enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Password_box_Leave(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Username_box_Leave(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

#endregion
        private Button login_button;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox username_box;
        private Label label1;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox password_box;
        private PictureBox pictureBox1;
    }
}

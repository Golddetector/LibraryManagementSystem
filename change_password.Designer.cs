namespace Library_Mangment_System
{
    partial class change_password
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.AntiqueWhite;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(572, 164);
            button1.Name = "button1";
            button1.Size = new Size(144, 41);
            button1.TabIndex = 0;
            button1.Text = "Change";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            label1.Location = new Point(91, 116);
            label1.Name = "label1";
            label1.Size = new Size(172, 28);
            label1.TabIndex = 1;
            label1.Text = "Previous password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            label2.Location = new Point(91, 163);
            label2.Name = "label2";
            label2.Size = new Size(138, 28);
            label2.TabIndex = 2;
            label2.Text = "New password";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            label3.Location = new Point(91, 215);
            label3.Name = "label3";
            label3.Size = new Size(170, 28);
            label3.TabIndex = 3;
            label3.Text = "Confirm Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(304, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 27);
            textBox1.TabIndex = 4;
            textBox1.UseSystemPasswordChar = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(304, 164);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(207, 27);
            textBox2.TabIndex = 5;
            textBox2.UseSystemPasswordChar = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(304, 216);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(207, 27);
            textBox3.TabIndex = 6;
            textBox3.UseSystemPasswordChar = true;
            // 
            // change_password
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(888, 730);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "change_password";
            Text = "change_password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}
namespace LoginForm
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel5 = new Panel();
            error_label = new Label();
            textBox_email_id = new TextBox();
            confirm_password_textBox = new TextBox();
            linkLabel_termCon = new LinkLabel();
            termAndConCheckBox = new CheckBox();
            login_button = new Button();
            signup_button = new Button();
            picture_input = new PictureBox();
            password_textBox = new TextBox();
            username_textBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_input).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(252, 252, 255);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(684, 823);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1034, 823);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(684, 823);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(684, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 823);
            panel2.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.AutoSize = true;
            panel5.Controls.Add(error_label);
            panel5.Controls.Add(textBox_email_id);
            panel5.Controls.Add(confirm_password_textBox);
            panel5.Controls.Add(linkLabel_termCon);
            panel5.Controls.Add(termAndConCheckBox);
            panel5.Controls.Add(login_button);
            panel5.Controls.Add(signup_button);
            panel5.Controls.Add(picture_input);
            panel5.Controls.Add(password_textBox);
            panel5.Controls.Add(username_textBox);
            panel5.Location = new Point(-3, 65);
            panel5.Name = "panel5";
            panel5.Size = new Size(393, 675);
            panel5.TabIndex = 5;
            // 
            // error_label
            // 
            error_label.AutoSize = true;
            error_label.BackColor = Color.Gainsboro;
            error_label.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            error_label.ForeColor = Color.Red;
            error_label.Location = new Point(17, 298);
            error_label.MaximumSize = new Size(355, 0);
            error_label.Name = "error_label";
            error_label.Size = new Size(0, 20);
            error_label.TabIndex = 8;
            // 
            // textBox_email_id
            // 
            textBox_email_id.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_email_id.Location = new Point(22, 404);
            textBox_email_id.Name = "textBox_email_id";
            textBox_email_id.PlaceholderText = "Email";
            textBox_email_id.Size = new Size(319, 33);
            textBox_email_id.TabIndex = 7;
            // 
            // confirm_password_textBox
            // 
            confirm_password_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            confirm_password_textBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            confirm_password_textBox.Location = new Point(22, 500);
            confirm_password_textBox.Name = "confirm_password_textBox";
            confirm_password_textBox.PlaceholderText = "Confirm Password";
            confirm_password_textBox.Size = new Size(319, 33);
            confirm_password_textBox.TabIndex = 6;
            confirm_password_textBox.UseSystemPasswordChar = true;
            // 
            // linkLabel_termCon
            // 
            linkLabel_termCon.AutoSize = true;
            linkLabel_termCon.Location = new Point(78, 542);
            linkLabel_termCon.Name = "linkLabel_termCon";
            linkLabel_termCon.Size = new Size(60, 15);
            linkLabel_termCon.TabIndex = 5;
            linkLabel_termCon.TabStop = true;
            linkLabel_termCon.Text = "offer term";
            // 
            // termAndConCheckBox
            // 
            termAndConCheckBox.AutoSize = true;
            termAndConCheckBox.Location = new Point(25, 542);
            termAndConCheckBox.Name = "termAndConCheckBox";
            termAndConCheckBox.Size = new Size(64, 19);
            termAndConCheckBox.TabIndex = 4;
            termAndConCheckBox.Text = "I agree ";
            termAndConCheckBox.UseVisualStyleBackColor = true;
            termAndConCheckBox.CheckedChanged += termAndConCheckBox_CheckedChanged;
            // 
            // login_button
            // 
            login_button.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            login_button.Location = new Point(22, 619);
            login_button.Name = "login_button";
            login_button.Size = new Size(319, 44);
            login_button.TabIndex = 2;
            login_button.Text = "Login";
            login_button.UseVisualStyleBackColor = true;
            login_button.Click += login_button_Click;
            // 
            // signup_button
            // 
            signup_button.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            signup_button.Location = new Point(22, 569);
            signup_button.Name = "signup_button";
            signup_button.Size = new Size(319, 44);
            signup_button.TabIndex = 3;
            signup_button.Text = "Sign Up";
            signup_button.UseVisualStyleBackColor = true;
            signup_button.Click += signup_button_Click;
            // 
            // picture_input
            // 
            picture_input.Image = (Image)resources.GetObject("picture_input.Image");
            picture_input.Location = new Point(-35, -38);
            picture_input.Name = "picture_input";
            picture_input.Size = new Size(425, 322);
            picture_input.SizeMode = PictureBoxSizeMode.Zoom;
            picture_input.TabIndex = 0;
            picture_input.TabStop = false;
            // 
            // password_textBox
            // 
            password_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            password_textBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            password_textBox.Location = new Point(22, 452);
            password_textBox.Name = "password_textBox";
            password_textBox.PlaceholderText = "Password";
            password_textBox.Size = new Size(319, 33);
            password_textBox.TabIndex = 1;
            password_textBox.UseSystemPasswordChar = true;
            // 
            // username_textBox
            // 
            username_textBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            username_textBox.Location = new Point(22, 356);
            username_textBox.Name = "username_textBox";
            username_textBox.PlaceholderText = "Username";
            username_textBox.Size = new Size(319, 33);
            username_textBox.TabIndex = 0;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 823);
            Controls.Add(panel1);
            Name = "SignUpForm";
            Text = "Sign Up";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picture_input).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel5;
        private LinkLabel linkLabel_termCon;
        private CheckBox termAndConCheckBox;
        private Button login_button;
        private Button signup_button;
        private PictureBox picture_input;
        private TextBox password_textBox;
        private TextBox username_textBox;
        private TextBox textBox_email_id;
        private TextBox confirm_password_textBox;
        private Label error_label;
    }
}
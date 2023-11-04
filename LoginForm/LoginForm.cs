using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace LoginForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            login_button.Enabled = false;
        }

        private void picture_input_Click(object sender, EventArgs e)
        {

        }



        private void login_button_Click(object sender, EventArgs e)
        {

            // Create a Database Connection
            string conectionStringSql = "Data Source=LAPTOP-F3MH6A4U\\SQLEXPRESS;Initial Catalog=GrifindoDatabase;Integrated Security=True;";
            SqlConnection con = new SqlConnection(conectionStringSql);

            string username_text = username_textBox.Text;
            string password_text = password_textBox.Text;

            Console.WriteLine($"username: {username_text}, password: {password_text}");
        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForm signup_form = new SignUpForm();
            signup_form.ShowDialog();
            this.Close();
        }

        private void username_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (termAndConCheckBox.Checked)
                login_button.Enabled = true;
            else
                login_button.Enabled = false;
        }
    }
}
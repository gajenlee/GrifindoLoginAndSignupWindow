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

namespace LoginForm
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            signup_button.Enabled = false;
        }

        // check the username
        private bool CheckTheUserName(string name)
        {
            if (name.Length > 5 && !char.IsNumber(name[0])) return true;
            return false;
        }

        // Check the User Email
        private bool CheckTheUserEmailAddress(string email)
        {

            return true;
        }

        // Check the User Password 
        private bool CheckTheUserPassowrd(string password)
        {
            List<string> fillter_checker = new List<string>();
            byte[] bytes = Encoding.ASCII.GetBytes(password);
            if (password.Length >= 8)
            {
                for (byte i = 0; i < bytes.Length; i++)
                {
                    if (bytes[i] >= 65 && bytes[i] <= 90) fillter_checker.Add("Upper");
                    if (bytes[i] >= 97 && bytes[i] <= 122) fillter_checker.Add("Lower");
                    if (bytes[i] >= 48 && bytes[i] <= 57) fillter_checker.Add("Num");
                    if (bytes[i] >= 32 && bytes[i] <= 47 || bytes[i] >= 58 && bytes[i] <= 64 || bytes[i] >= 91 && bytes[i] <= 96 || bytes[i] >= 123 && bytes[i] <= 126) fillter_checker.Add("Symbol");

                }
            }
            else
            {
                Console.WriteLine("!! The Password Must be Include at least eight characters !!");
                return false;
            }
            if (fillter_checker.Contains("Upper") && fillter_checker.Contains("Lower") && fillter_checker.Contains("Num") && fillter_checker.Contains("Symbol")) return true;
            else
            {
                Console.WriteLine("!! The Password Must be Includes !!\n" +
                    "1. UpperCase Letters.\n" +
                    "2. LowerCase Letters.\n" +
                    "3. Numbers.\n" +
                    "4. Symbols.\n" +
                    "---- Make sure these are includes in your password");
                return false;
            }
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login_form = new LoginForm();
            login_form.ShowDialog();
            this.Close();
        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            string userName = username_textBox.Text;
            string userPassword = password_textBox.Text;
            string userEmailAddress = textBox_email_id.Text;
            string userConfirmPassword = confirm_password_textBox.Text;

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-F3MH6A4U\\SQLEXPRESS;Initial Catalog=GrifindoDatabase;Integrated Security=True;");

            if (userName != "" && userPassword != "" && userConfirmPassword != "" && userEmailAddress != "")
            {
                if (CheckTheUserName(userName) && CheckTheUserEmailAddress(userEmailAddress) && CheckTheUserPassowrd(userPassword))
                {
                    if (userPassword == userConfirmPassword)
                    {
                        con.Open();
                        string query = "INSERT INTO UsersInformation ( UserName, UserEmailAddress, UserPassword ) VALUES ( '" + userName + "', '" + userEmailAddress + "', '" + userPassword + "' )";

                        SqlCommand cmd = new SqlCommand(query, con);
                        con.Close();

                        this.Hide();
                        LoginForm login_form = new LoginForm();
                        login_form.ShowDialog();
                        this.Close();
                    }
                    else
                        error_label.Text = "Password is not matching ";
                }
                else
                    error_label.Text = "Numbers, capital letters, symbols, and simple letters should be included in the password";
            }
            else
                error_label.Text = "Input field is empty, please fill it out";
        }

        private void termAndConCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (termAndConCheckBox.Checked) signup_button.Enabled = true;
            else signup_button.Enabled = false;
        }
    }
}

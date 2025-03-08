using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace App_
{
    public partial class Register_ : Form
    {
        private SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\OneDrive\Documents\Soft.mdf;Integrated Security=True;Connect Timeout=30");

        public Register_()
        {
            InitializeComponent();

            // Attach KeyDown event handlers for keyboard navigation
            signup_email.KeyDown += new KeyEventHandler(RegisterFields_KeyDown);
            signup_username.KeyDown += new KeyEventHandler(RegisterFields_KeyDown);
            signup_password.KeyDown += new KeyEventHandler(RegisterFields_KeyDown);
        }

        private void signup_LOGIN_Click(object sender, EventArgs e)
        {
            Login_ loginForm = new Login_();
            loginForm.Show();
            this.Hide();
        }

        private void signup_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(signup_email.Text))
            {
                MessageBox.Show("Please enter Email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                signup_email.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(signup_username.Text))
            {
                MessageBox.Show("Please enter Username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                signup_username.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(signup_password.Text))
            {
                MessageBox.Show("Please enter Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                signup_password.Focus();
                return;
            }

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    // Check if username already exists
                    string checkUsername = "SELECT COUNT(*) FROM admin WHERE username = @username";
                    using (SqlCommand checkUser = new SqlCommand(checkUsername, connect))
                    {
                        checkUser.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                        int userExists = (int)checkUser.ExecuteScalar();

                        if (userExists > 0)
                        {
                            MessageBox.Show($"{signup_username.Text} already exists!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            // Clear fields after error
                            signup_email.Text = string.Empty;
                            signup_username.Text = string.Empty;
                            signup_password.Text = string.Empty;

                            signup_email.Focus(); // Reset focus
                            return;
                        }
                    }

                    // Insert new user
                    string insertData = "INSERT INTO admin (email, username, _password, date_created) " +
                                        "VALUES(@email, @username, @pass, @date)";

                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@email", signup_email.Text.Trim());
                        cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", signup_password.Text.Trim());
                        cmd.Parameters.AddWithValue("@date", DateTime.Today);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Redirect to Login Page
                        Login_ loginForm = new Login_();
                        loginForm.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to Database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void RegisterFields_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevents Enter from adding a new line

                if (sender == signup_email)
                {
                    if (string.IsNullOrWhiteSpace(signup_email.Text))
                    {
                        MessageBox.Show("Please enter Email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        signup_email.Focus();
                    }
                    else
                    {
                        signup_username.Focus(); // Move to username
                    }
                }
                else if (sender == signup_username)
                {
                    if (string.IsNullOrWhiteSpace(signup_username.Text))
                    {
                        MessageBox.Show("Please enter Username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        signup_username.Focus();
                    }
                    else
                    {
                        signup_password.Focus(); // Move to password
                    }
                }
                else if (sender == signup_password)
                {
                    if (string.IsNullOrWhiteSpace(signup_password.Text))
                    {
                        MessageBox.Show("Please enter Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        signup_password.Focus();
                    }
                    else
                    {
                        signup_btn_Click(sender, e); // Submit registration form
                    }
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (sender == signup_email)
                {
                    signup_username.Focus();
                }
                else if (sender == signup_username)
                {
                    signup_password.Focus();
                }
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (sender == signup_password)
                {
                    signup_username.Focus();
                }
                else if (sender == signup_username)
                {
                    signup_email.Focus();
                }
                e.SuppressKeyPress = true;
            }
        }

        private void signup_show_password_check(object sender, EventArgs e)
        {
            signup_password.PasswordChar = signup_show_password.Checked ? '\0' : '*';
        }

        private void clear_Click(object sender, EventArgs e)
        {
            // Clear all input fields
            signup_email.Text = string.Empty;
            signup_username.Text = string.Empty;
            signup_password.Text = string.Empty;

            // Set focus back to the first field
            signup_email.Focus();
        }

        private void heading_txt_Click(object sender, EventArgs e)
        {
            // Placeholder function to prevent crashes
        }

        private void username_txt_Click(object sender, EventArgs e)
        {
            //username-txt
        }

        private void email_txt_Click(object sender, EventArgs e)
        {
            //email-txt
        }

        private void password_txt_Click(object sender, EventArgs e)
        {
            //password-txt-box
        }

        private void already_account_txt_Click(object sender, EventArgs e)
        {
            //already-account-txt
        }

        private void signup_email_txt_area(object sender, EventArgs e)
        {
            //signup-email-txt-area
        }

        private void signup_username_txt_area(object sender, EventArgs e)
        {
            //signup-username-area
        }

        private void signup_password_txt_area(object sender, EventArgs e)
        {
            //signup-password-area
        }
    }
}
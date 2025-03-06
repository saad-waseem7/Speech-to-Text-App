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
        }

        private void heading_txt_Click(object sender, EventArgs e)
        {
            //heading-txt
        }

        private void username_txt_Click(object sender, EventArgs e)
        {
            //username-txt
        }

        private void email_txt_Click(object sender, EventArgs e)
        {
            //email-txt
        }

        private void signup_LOGIN_Click(object sender, EventArgs e)
        {
            Login_ login_register_here = new Login_();
            login_register_here.Show();
            this.Hide();
        }

        private void signup_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            if (signup_email.Text == "" || signup_username.Text == ""
                || signup_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        String checkUsername = "SELECT * FROM admin WHERE username = '"
                            + signup_username.Text.Trim() + "'"; // admin is our table name

                        using (SqlCommand checkUser = new SqlCommand(checkUsername, connect))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show(signup_username.Text + " is already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO admin (email, username, _password, date_created) " +
                                    "VALUES(@email, @username, @pass, @date)";

                                DateTime date = DateTime.Today;

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@email", signup_email.Text.Trim());
                                    cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", signup_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date", date);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // TO SWITCH THE FORM
                                    Register_ signup_LOGIN = new Register_();
                                    signup_LOGIN.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void signup_show_password_check(object sender, EventArgs e)
        {
            if (signup_show_password.Checked)
            {
                signup_password.PasswordChar = '\0';
            }
            else
            {
                signup_password.PasswordChar = '*';
            }
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

        private void clear_Click(object sender, EventArgs e)
        {
            // Clear all input fields
            signup_email.Text = string.Empty;
            signup_username.Text = string.Empty;
            signup_password.Text = string.Empty;

            // Set focus back to the first field
            signup_email.Focus();
        }

        private void password_txt_Click(object sender, EventArgs e)
        {
            //password-txt-box
        }

        private void already_account_txt_Click(object sender, EventArgs e)
        {
            //already-account-txt
        }
    }
}
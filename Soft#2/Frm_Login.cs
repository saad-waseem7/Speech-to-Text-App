using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace App_
{
    public partial class Login_ : Form
    {
        private SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\OneDrive\Documents\Soft.mdf;Integrated Security=True;Connect Timeout=30");

        public Login_()
        {
            InitializeComponent();

            // Attach KeyDown event handlers
            login_username.KeyDown += new KeyEventHandler(LoginFields_KeyDown);
            login_password.KeyDown += new KeyEventHandler(LoginFields_KeyDown);

            // Ensure Enter key doesn't add new lines
            login_username.AcceptsReturn = false;
            login_password.AcceptsReturn = false;
            // login_username.Multiline = true;
            // login_password.Multiline = true;
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
        }

        private void welcome_txt_Click(object sender, EventArgs e)
        {
            // welcome-txt
        }

        private void login_register_here_Click(object sender, EventArgs e)
        {
            Register_ signup_LOGIN = new Register_();
            signup_LOGIN.Show();
            this.Hide();
        }

        private void login_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(login_username.Text))
            {
                MessageBox.Show("Please enter Username!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                login_username.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(login_password.Text))
            {
                MessageBox.Show("Please enter Password!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                login_password.Focus();
                return;
            }

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM admin WHERE username = @username AND _password = @pass";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.Clear(); // Clear previous parameters

                        cmd.Parameters.AddWithValue("@username", login_username.Text);
                        cmd.Parameters.AddWithValue("@pass", login_password.Text);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count >= 1)
                        {
                            MessageBox.Show("Logged In successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Main_ mForm = new Main_(); // Open Main form
                            mForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            // Clear username & password fields
                            login_username.Text = string.Empty;
                            login_password.Text = string.Empty;

                            login_username.Focus(); // Set focus back to username field
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Connecting: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void LoginFields_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevents Enter from adding a new line

                if (sender == login_username)
                {
                    if (string.IsNullOrWhiteSpace(login_username.Text))
                    {
                        MessageBox.Show("Please enter Username!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        login_username.Focus();
                    }
                    else
                    {
                        login_password.Focus(); // Move to password field
                    }
                }
                else if (sender == login_password)
                {
                    if (string.IsNullOrWhiteSpace(login_password.Text))
                    {
                        MessageBox.Show("Please enter Password!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        login_password.Focus();
                    }
                    else
                    {
                        login_btn_Click(sender, e); // Submit login form
                    }
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (sender == login_username)
                {
                    login_password.Focus(); // Move to password
                }
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (sender == login_password)
                {
                    login_username.Focus(); // Move to username
                }
                e.SuppressKeyPress = true;
            }
        }

        private void log_show_password_check(object sender, EventArgs e)
        {
            login_password.PasswordChar = log_show_password.Checked ? '\0' : '*';
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            // Clear all input fields
            login_username.Text = string.Empty;
            login_password.Text = string.Empty;

            // Set focus back to the first field
            login_username.Focus();
        }

        private void username_txt_area(object sender, EventArgs e)
        {
            // username-txt-area
        }

        private void password_txt_area(object sender, EventArgs e)
        {
            // password-txt-area
        }

        private void username_txt_Click(object sender, EventArgs e)
        {
            // username-txt
        }

        private void password_txt_Click(object sender, EventArgs e)
        {
            // password-txt
        }

        private void no_account_txt_Click(object sender, EventArgs e)
        {
            // no-account-txt
        }
    }
}
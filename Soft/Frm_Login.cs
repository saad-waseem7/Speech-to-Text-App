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
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
        }

        private void welcome_txt_Click(object sender, EventArgs e)
        {
            //welcome-txt
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
            if (login_username.Text == "" || login_password.Text == "")
            {
                MessageBox.Show("Please fil all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        String selectData = "SELECT * FROM admin WHERE username = @username AND _password = @pass";
                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", login_username.Text);
                            cmd.Parameters.AddWithValue("@pass", login_password.Text);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Logged In successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Main_ mForm = new Main_(); //Mainform call...
                                mForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Connecting: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void log_show_password_check(object sender, EventArgs e)
        {
            if (log_show_password.Checked)
            {
                login_password.PasswordChar = '\0';
            }
            else
            {
                login_password.PasswordChar = '*';
            }
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
            //password-txt-area
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
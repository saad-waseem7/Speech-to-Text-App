using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace App_1
{
    public partial class Frm_Login : Form
    {
        private SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\OneDrive\Documents\saad.mdf;Integrated Security=True;Connect Timeout=30");

        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //welcome-txt
        }

        private void login_register_here_Click(object sender, EventArgs e)
        {
            Form1 signup_LOGIN = new Form1();
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

                                MainForm mForm = new MainForm();
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

        private void log_show_password_CheckedChanged(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear all input fields
            login_username.Text = string.Empty;
            login_password.Text = string.Empty;

            // Set focus back to the first field
            login_username.Focus();
        }

        private void login_password_TextChanged(object sender, EventArgs e)
        {
            //password-txt-area
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // username-txt-box
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // password-txt-box
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // no-account-txt-box
        }

        private void login_username_TextChanged(object sender, EventArgs e)
        {
            // login-txt-area
        }
    }
}
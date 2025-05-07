
namespace App_
{
    partial class Register_
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
            this.signup_close = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.signup_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.signup_username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.signup_password = new System.Windows.Forms.TextBox();
            this.signup_show_password = new System.Windows.Forms.CheckBox();
            this.signup_btn = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.signup_LOGIN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signup_close
            // 
            this.signup_close.AutoSize = true;
            this.signup_close.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_close.Location = new System.Drawing.Point(262, 3);
            this.signup_close.Name = "signup_close";
            this.signup_close.Size = new System.Drawing.Size(20, 21);
            this.signup_close.TabIndex = 25;
            this.signup_close.Text = "X";
            this.signup_close.Click += new System.EventHandler(this.signup_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(26, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get Started";
            this.label1.Click += new System.EventHandler(this.heading_txt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "E-mail Address:";
            this.label2.Click += new System.EventHandler(this.email_txt_Click);
            // 
            // signup_email
            // 
            this.signup_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.signup_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.signup_email.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_email.Location = new System.Drawing.Point(31, 136);
            this.signup_email.Multiline = true;
            this.signup_email.Name = "signup_email";
            this.signup_email.Size = new System.Drawing.Size(216, 28);
            this.signup_email.TabIndex = 2;
            this.signup_email.TextChanged += new System.EventHandler(this.signup_email_txt_area);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username:";
            this.label3.Click += new System.EventHandler(this.username_txt_Click);
            // 
            // signup_username
            // 
            this.signup_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.signup_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.signup_username.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_username.Location = new System.Drawing.Point(31, 199);
            this.signup_username.Multiline = true;
            this.signup_username.Name = "signup_username";
            this.signup_username.Size = new System.Drawing.Size(216, 28);
            this.signup_username.TabIndex = 4;
            this.signup_username.TextChanged += new System.EventHandler(this.signup_username_txt_area);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password:";
            this.label4.Click += new System.EventHandler(this.password_txt_Click);
            // 
            // signup_password
            // 
            this.signup_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.signup_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.signup_password.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_password.Location = new System.Drawing.Point(31, 262);
            this.signup_password.Multiline = true;
            this.signup_password.Name = "signup_password";
            this.signup_password.PasswordChar = '*';
            this.signup_password.Size = new System.Drawing.Size(216, 28);
            this.signup_password.TabIndex = 6;
            this.signup_password.TextChanged += new System.EventHandler(this.signup_password_txt_area);
            // 
            // signup_show_password
            // 
            this.signup_show_password.AutoSize = true;
            this.signup_show_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_show_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_show_password.Location = new System.Drawing.Point(125, 296);
            this.signup_show_password.Name = "signup_show_password";
            this.signup_show_password.Size = new System.Drawing.Size(119, 21);
            this.signup_show_password.TabIndex = 7;
            this.signup_show_password.Text = "Show Password";
            this.signup_show_password.UseVisualStyleBackColor = true;
            this.signup_show_password.CheckedChanged += new System.EventHandler(this.signup_show_password_check);
            // 
            // signup_btn
            // 
            this.signup_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.signup_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_btn.FlatAppearance.BorderSize = 0;
            this.signup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_btn.ForeColor = System.Drawing.Color.White;
            this.signup_btn.Location = new System.Drawing.Point(31, 356);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(216, 35);
            this.signup_btn.TabIndex = 8;
            this.signup_btn.Text = "REGISTER";
            this.signup_btn.UseVisualStyleBackColor = false;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.White;
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.clear.Location = new System.Drawing.Point(31, 406);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(216, 35);
            this.clear.TabIndex = 9;
            this.clear.Text = "CLEAR";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 465);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Alreday Have an Account ?";
            this.label5.Click += new System.EventHandler(this.already_account_txt_Click);
            // 
            // signup_LOGIN
            // 
            this.signup_LOGIN.AutoSize = true;
            this.signup_LOGIN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_LOGIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.signup_LOGIN.Location = new System.Drawing.Point(84, 487);
            this.signup_LOGIN.Name = "signup_LOGIN";
            this.signup_LOGIN.Size = new System.Drawing.Size(97, 17);
            this.signup_LOGIN.TabIndex = 11;
            this.signup_LOGIN.Text = "Back to LOGIN";
            this.signup_LOGIN.Click += new System.EventHandler(this.signup_LOGIN_Click);
            // 
            // Register_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(285, 544);
            this.Controls.Add(this.signup_close);
            this.Controls.Add(this.signup_LOGIN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.signup_btn);
            this.Controls.Add(this.signup_show_password);
            this.Controls.Add(this.signup_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.signup_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.signup_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Register_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Register__Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label signup_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox signup_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox signup_username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox signup_password;
        private System.Windows.Forms.CheckBox signup_show_password;
        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label signup_LOGIN;
    }
}


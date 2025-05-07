
namespace App_
{
    partial class Feedback_
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
            this.feedback_txt = new System.Windows.Forms.RichTextBox();
            this.submit_feedback_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // feedback_txt
            // 
            this.feedback_txt.Location = new System.Drawing.Point(262, 138);
            this.feedback_txt.Name = "feedback_txt";
            this.feedback_txt.Size = new System.Drawing.Size(500, 220);
            this.feedback_txt.TabIndex = 1;
            this.feedback_txt.Text = "";
            this.feedback_txt.TextChanged += new System.EventHandler(this.feedback_textbox);
            // 
            // submit_feedback_btn
            // 
            this.submit_feedback_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(82)))), ((int)(((byte)(179)))));
            this.submit_feedback_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submit_feedback_btn.FlatAppearance.BorderSize = 0;
            this.submit_feedback_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit_feedback_btn.ForeColor = System.Drawing.Color.White;
            this.submit_feedback_btn.Location = new System.Drawing.Point(461, 389);
            this.submit_feedback_btn.Name = "submit_feedback_btn";
            this.submit_feedback_btn.Size = new System.Drawing.Size(93, 40);
            this.submit_feedback_btn.TabIndex = 2;
            this.submit_feedback_btn.Text = "Submit";
            this.submit_feedback_btn.UseVisualStyleBackColor = false;
            this.submit_feedback_btn.Click += new System.EventHandler(this.submit_feedback_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(82)))), ((int)(((byte)(179)))));
            this.exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.ForeColor = System.Drawing.Color.White;
            this.exit_btn.Location = new System.Drawing.Point(931, 483);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(93, 40);
            this.exit_btn.TabIndex = 4;
            this.exit_btn.Text = "Exit\r\n";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(82)))), ((int)(((byte)(179)))));
            this.back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_btn.FlatAppearance.BorderSize = 0;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.ForeColor = System.Drawing.Color.White;
            this.back_btn.Location = new System.Drawing.Point(44, 483);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(93, 40);
            this.back_btn.TabIndex = 5;
            this.back_btn.Text = "Go Back";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(337, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Please Enter your Feedback";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Feedback_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.submit_feedback_btn);
            this.Controls.Add(this.feedback_txt);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Feedback_Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Feedback_Frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox feedback_txt;
        private System.Windows.Forms.Button submit_feedback_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label label1;
    }
}
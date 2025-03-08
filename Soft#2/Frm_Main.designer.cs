
namespace App_
{
    partial class Main_
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
            this.txt_speech_box = new System.Windows.Forms.TextBox();
            this.trk_speed = new System.Windows.Forms.TrackBar();
            this.trk_vol = new System.Windows.Forms.TrackBar();
            this.btn_read = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_resume = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_record = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.file_dialog_1 = new System.Windows.Forms.OpenFileDialog();
            this.save_file_dialog_1 = new System.Windows.Forms.SaveFileDialog();
            this.speech_txt_box = new System.Windows.Forms.TextBox();
            this.clk_listen = new System.Windows.Forms.Button();
            this.txt_speed = new System.Windows.Forms.TextBox();
            this.txt_vol = new System.Windows.Forms.TextBox();
            this.signup_close = new System.Windows.Forms.Label();
            this.btn_stp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trk_speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_vol)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_speech_box
            // 
            this.txt_speech_box.Location = new System.Drawing.Point(447, 44);
            this.txt_speech_box.Multiline = true;
            this.txt_speech_box.Name = "txt_speech_box";
            this.txt_speech_box.Size = new System.Drawing.Size(365, 252);
            this.txt_speech_box.TabIndex = 0;
            this.txt_speech_box.TextChanged += new System.EventHandler(this.text_to_speech_box);
            // 
            // trk_speed
            // 
            this.trk_speed.Location = new System.Drawing.Point(277, 371);
            this.trk_speed.Name = "trk_speed";
            this.trk_speed.Size = new System.Drawing.Size(111, 45);
            this.trk_speed.TabIndex = 1;
            this.trk_speed.Tag = "Speed";
            this.trk_speed.Scroll += new System.EventHandler(this.trk_speed_Scroll);
            // 
            // trk_vol
            // 
            this.trk_vol.Location = new System.Drawing.Point(408, 371);
            this.trk_vol.Name = "trk_vol";
            this.trk_vol.Size = new System.Drawing.Size(111, 45);
            this.trk_vol.TabIndex = 2;
            this.trk_vol.Tag = "volume";
            this.trk_vol.Scroll += new System.EventHandler(this.trk_vol_Scroll);
            // 
            // btn_read
            // 
            this.btn_read.Location = new System.Drawing.Point(558, 333);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(75, 53);
            this.btn_read.TabIndex = 3;
            this.btn_read.Text = "Read";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.Location = new System.Drawing.Point(639, 333);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(75, 53);
            this.btn_pause.TabIndex = 4;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_resume
            // 
            this.btn_resume.Location = new System.Drawing.Point(720, 333);
            this.btn_resume.Name = "btn_resume";
            this.btn_resume.Size = new System.Drawing.Size(75, 53);
            this.btn_resume.TabIndex = 5;
            this.btn_resume.Text = "Resume";
            this.btn_resume.UseVisualStyleBackColor = true;
            this.btn_resume.Click += new System.EventHandler(this.btn_resume_Click);
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(558, 399);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(75, 53);
            this.btn_open.TabIndex = 6;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_record
            // 
            this.btn_record.Location = new System.Drawing.Point(639, 399);
            this.btn_record.Name = "btn_record";
            this.btn_record.Size = new System.Drawing.Size(75, 53);
            this.btn_record.TabIndex = 7;
            this.btn_record.Text = "Record";
            this.btn_record.UseVisualStyleBackColor = true;
            this.btn_record.Click += new System.EventHandler(this.btn_record_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(720, 399);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 53);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // file_dialog_1
            // 
            this.file_dialog_1.FileName = "openFileDialog1";
            // 
            // speech_txt_box
            // 
            this.speech_txt_box.Location = new System.Drawing.Point(36, 44);
            this.speech_txt_box.Multiline = true;
            this.speech_txt_box.Name = "speech_txt_box";
            this.speech_txt_box.Size = new System.Drawing.Size(365, 252);
            this.speech_txt_box.TabIndex = 9;
            this.speech_txt_box.TextChanged += new System.EventHandler(this.speech_txt_box_area);
            // 
            // clk_listen
            // 
            this.clk_listen.Location = new System.Drawing.Point(36, 315);
            this.clk_listen.Name = "clk_listen";
            this.clk_listen.Size = new System.Drawing.Size(93, 39);
            this.clk_listen.TabIndex = 10;
            this.clk_listen.Text = "Listen";
            this.clk_listen.UseVisualStyleBackColor = true;
            this.clk_listen.Click += new System.EventHandler(this.clk_listen_speech_text);
            // 
            // txt_speed
            // 
            this.txt_speed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_speed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_speed.Location = new System.Drawing.Point(291, 407);
            this.txt_speed.Multiline = true;
            this.txt_speed.Name = "txt_speed";
            this.txt_speed.ReadOnly = true;
            this.txt_speed.Size = new System.Drawing.Size(86, 30);
            this.txt_speed.TabIndex = 11;
            this.txt_speed.Text = "Speed";
            this.txt_speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_vol
            // 
            this.txt_vol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_vol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_vol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vol.Location = new System.Drawing.Point(421, 407);
            this.txt_vol.Multiline = true;
            this.txt_vol.Name = "txt_vol";
            this.txt_vol.ReadOnly = true;
            this.txt_vol.Size = new System.Drawing.Size(86, 30);
            this.txt_vol.TabIndex = 12;
            this.txt_vol.Text = "Volume";
            this.txt_vol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // signup_close
            // 
            this.signup_close.AutoSize = true;
            this.signup_close.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_close.Location = new System.Drawing.Point(828, 2);
            this.signup_close.Name = "signup_close";
            this.signup_close.Size = new System.Drawing.Size(20, 21);
            this.signup_close.TabIndex = 26;
            this.signup_close.Text = "X";
            this.signup_close.Click += new System.EventHandler(this.close_Click);
            // 
            // btn_stp
            // 
            this.btn_stp.Location = new System.Drawing.Point(36, 366);
            this.btn_stp.Name = "btn_stp";
            this.btn_stp.Size = new System.Drawing.Size(93, 39);
            this.btn_stp.TabIndex = 27;
            this.btn_stp.Text = "Stop";
            this.btn_stp.UseVisualStyleBackColor = true;
            this.btn_stp.Click += new System.EventHandler(this.btn_stp_Click);
            // 
            // Main_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.btn_stp);
            this.Controls.Add(this.signup_close);
            this.Controls.Add(this.txt_vol);
            this.Controls.Add(this.txt_speed);
            this.Controls.Add(this.clk_listen);
            this.Controls.Add(this.speech_txt_box);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_record);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_resume);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.trk_vol);
            this.Controls.Add(this.trk_speed);
            this.Controls.Add(this.txt_speech_box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm1";
            ((System.ComponentModel.ISupportInitialize)(this.trk_speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_vol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_speech_box;
        private System.Windows.Forms.TrackBar trk_speed;
        private System.Windows.Forms.TrackBar trk_vol;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_resume;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_record;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.OpenFileDialog file_dialog_1;
        private System.Windows.Forms.SaveFileDialog save_file_dialog_1;
        private System.Windows.Forms.TextBox speech_txt_box;
        private System.Windows.Forms.Button clk_listen;
        private System.Windows.Forms.TextBox txt_speed;
        private System.Windows.Forms.TextBox txt_vol;
        private System.Windows.Forms.Label signup_close;
        private System.Windows.Forms.Button btn_stp;
    }
}

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
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.trk_speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_vol)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(644, 252);
            this.textBox1.TabIndex = 0;
            // 
            // trk_speed
            // 
            this.trk_speed.Location = new System.Drawing.Point(40, 309);
            this.trk_speed.Name = "trk_speed";
            this.trk_speed.Size = new System.Drawing.Size(111, 45);
            this.trk_speed.TabIndex = 1;
            this.trk_speed.Tag = "Speed";
            this.trk_speed.Scroll += new System.EventHandler(this.trk_speed_Scroll);
            // 
            // trk_vol
            // 
            this.trk_vol.Location = new System.Drawing.Point(212, 309);
            this.trk_vol.Name = "trk_vol";
            this.trk_vol.Size = new System.Drawing.Size(111, 45);
            this.trk_vol.TabIndex = 2;
            this.trk_vol.Tag = "volume";
            this.trk_vol.Scroll += new System.EventHandler(this.trk_vol_Scroll);
            // 
            // btn_read
            // 
            this.btn_read.Location = new System.Drawing.Point(399, 315);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(75, 53);
            this.btn_read.TabIndex = 3;
            this.btn_read.Text = "Read";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.Location = new System.Drawing.Point(480, 315);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(75, 53);
            this.btn_pause.TabIndex = 4;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_resume
            // 
            this.btn_resume.Location = new System.Drawing.Point(561, 315);
            this.btn_resume.Name = "btn_resume";
            this.btn_resume.Size = new System.Drawing.Size(75, 53);
            this.btn_resume.TabIndex = 5;
            this.btn_resume.Text = "Resume";
            this.btn_resume.UseVisualStyleBackColor = true;
            this.btn_resume.Click += new System.EventHandler(this.btn_resume_Click);
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(399, 381);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(75, 53);
            this.btn_open.TabIndex = 6;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_record
            // 
            this.btn_record.Location = new System.Drawing.Point(480, 381);
            this.btn_record.Name = "btn_record";
            this.btn_record.Size = new System.Drawing.Size(75, 53);
            this.btn_record.TabIndex = 7;
            this.btn_record.Text = "Record";
            this.btn_record.UseVisualStyleBackColor = true;
            this.btn_record.Click += new System.EventHandler(this.btn_record_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(561, 381);
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
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_record);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_resume);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.trk_vol);
            this.Controls.Add(this.trk_speed);
            this.Controls.Add(this.textBox1);
            this.Name = "MainForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm1";
            ((System.ComponentModel.ISupportInitialize)(this.trk_speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_vol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
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
    }
}
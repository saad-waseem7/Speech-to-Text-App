using System;
using System.IO;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace App_
{
    public partial class Main_ : Form
    {
        private SpeechSynthesizer ss;

        public Main_()
        {
            InitializeComponent();
        }

        private void btn_resume_Click(object sender, EventArgs e)
        {
            ss.Resume();
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            ss = new SpeechSynthesizer();
            ss.Rate = trk_speed.Value;
            ss.Volume = trk_vol.Value;
            ss.SpeakAsync(textBox1.Text);
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            ss.Pause();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "text files|*.txt";
            ofd.ShowDialog();
            string fname = ofd.FileName;
            StreamReader sr = new StreamReader(fname);
            textBox1.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void btn_record_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Wave Files| *.wav";
            sfd.ShowDialog();
            string fname;
            fname = sfd.FileName;
            SpeechSynthesizer ss = new SpeechSynthesizer();
            ss.Rate = trk_speed.Value;
            ss.Volume = trk_vol.Value;
            ss.SetOutputToWaveFile(fname);
            ss.Speak(textBox1.Text);
            ss.SetOutputToDefaultAudioDevice();
            MessageBox.Show("Text Recorded as Wave File.");
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void trk_speed_Scroll(object sender, EventArgs e)
        {
        }

        private void trk_vol_Scroll(object sender, EventArgs e)
        {
        }
    }
}
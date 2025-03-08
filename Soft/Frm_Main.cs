using System;
using System.IO;
using System.Speech.Recognition;
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
            ss.SpeakAsync(txt_speech_box.Text);
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
            txt_speech_box.Text = sr.ReadToEnd();
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
            ss.Speak(txt_speech_box.Text);
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

        private void text_to_speech_box(object sender, EventArgs e)
        {
            //Textbox for text-speech
        }

        private void speech_txt_box_area(object sender, EventArgs e)
        {
            //Textbox for speech-text
        }

        private void clk_listen_speech_text(object sender, EventArgs e)
        {
            SpeechRecognitionEngine sr = new SpeechRecognitionEngine();
            Grammar words = new DictationGrammar();
            sr.LoadGrammar(words);
            try
            {
                speech_txt_box.Text = "Listening.....";
                sr.SetInputToDefaultAudioDevice();
                RecognitionResult result = sr.Recognize();
                speech_txt_box.Clear();
                speech_txt_box.Text = result.Text;
            }
            catch
            {
                speech_txt_box.Text = "";
                MessageBox.Show("Mic Not Found.");
            }
            finally
            {
                sr.UnloadAllGrammars();
            }
        }



        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_stp_Click(object sender, EventArgs e)
        {

        }
    }
}
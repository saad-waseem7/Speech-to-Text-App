using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace App_1
{
    public partial class MainForm : Form
    {
        SpeechSynthesizer speech;

        public MainForm()
        {
            InitializeComponent();
            speech = new SpeechSynthesizer();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //speak
            if(richTextBox1.Text!="")
            {
                speech.SpeakAsync(richTextBox1.Text);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //pause
            if(speech.State==SynthesizerState.Speaking)
            {
                speech.Pause();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //resume
            if (speech.State == SynthesizerState.Paused)
            {
                speech.Resume();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

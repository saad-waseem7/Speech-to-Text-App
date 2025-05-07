using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_
{
    public partial class Feedback_ : Form
    {
        public Feedback_()
        {
            InitializeComponent();

            // Hook up the KeyDown event to the textbox
            feedback_txt.KeyDown += feedback_txt_KeyDown;
        }

        private void submit_feedback_btn_Click(object sender, EventArgs e)
        {
            submit_feedback_btn_Click(sender, e, true);  // Normal click closes window
        }

        private void submit_feedback_btn_Click(object sender, EventArgs e, bool closeWindow = true)
        {
            if (!string.IsNullOrWhiteSpace(feedback_txt.Text))  // Use textbox, not the button text
            {
                MessageBox.Show("Thank you for your feedback! ", "Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                feedback_txt.Text = string.Empty;

                if (closeWindow)
                    this.Close(); // Only close when triggered by button click
            }
            else
            {
                MessageBox.Show("Please write something before submitting.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void feedback_textbox(object sender, EventArgs e)
        {
            // This method can remain empty if unused
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // NEW: KeyDown handler for Enter/Shift+Enter logic
        private void feedback_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !e.Shift)
            {
                // Trigger feedback submit without closing form
                submit_feedback_btn_Click(sender, e, false);
                e.Handled = true;
                e.SuppressKeyPress = true; // Prevent newline or ding
            }
            // Shift+Enter: default behavior (inserts newline)
        }

        private void Feedback_Frm_Load(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Main_ mForm = new Main_(); // Open Main form
            mForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

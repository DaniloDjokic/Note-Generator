using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteGenerator
{
    public partial class Form1 : Form
    {
        Form1 form;
        bool firstStart = true;

        public Form1()
        {
            InitializeComponent();
            AppHandler.SetForm(this);
            form = this;
            startButton.Enabled = false;
            nextButton.Enabled = false;
        }

        public double switchInterval
        {
            get
            {
                return (double)numericUpDown1.Value;
            }
        }

        public Label Question
        {
            get
            {
                return question;
            }
            set
            {
                question.Text = value.ToString();
            }
        }

        public Label Answer
        {
            get
            {
                return answer;
            }
            set
            {
                answer.Text = value.ToString();
            }
        }

        public Button Start { get { return startButton; } }

        public Button Next { get { return nextButton; } }

        public Button Reverse { get { return reverseButton; } }

        public int GetStringNumber()
        {
            foreach (Control c in form.Controls)
            {
                if (c is GroupBox)
                {
                    foreach(Control ct in c.Controls)
                    {
                        if (ct is RadioButton)
                        {
                            RadioButton radio = ct as RadioButton;
                            if (radio.Checked) return Convert.ToInt32(radio.Text);
                        }
                    }                 
                }
            }
            return 0;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            AppHandler.NextPressed();
        }

        private void reverseButton_Click(object sender, EventArgs e)
        {
            string temp = question.Text;
            question.Text = answer.Text;
            answer.Text = temp;
            AppHandler.Reverse();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            AppHandler.StartPressed();
            firstStart = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            AppHandler.UpdateTimer();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            if (firstStart) startButton.Enabled = true;
            else
            {
                startButton.Enabled = true;
                reverseButton.Enabled = true;
                nextButton.Enabled = false;
                SetLabelText();
            }
        }

        public void SetLabelText()
        {
            if (!AppHandler.IsReversed)
            {
                question.Text = "Fret";
                answer.Text = "Note";
            }
            else
            {
                question.Text = "Note";
                answer.Text = "Fret";
            }
        }
    }
}

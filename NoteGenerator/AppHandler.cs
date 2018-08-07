using System;
using System.Collections.Generic;

namespace NoteGenerator
{
    static class AppHandler
    {
        static StringHandler stringHandler;
        static private Form1 form;
        static private bool isReversed = false;
        static System.Timers.Timer timer = new System.Timers.Timer();
        static KeyValuePair<int, string> stringPair;

        static public bool IsReversed { get { return isReversed; } }

        public static void Reverse()
        {
            isReversed = !isReversed;
        }

        static public void SetForm(Form1 f)
        {
            form = f;
            TimerSet();
        }

        static public void StartPressed()
        {
            form.Answer.Hide();
            stringHandler = new StringHandler(form.GetStringNumber());
            
            SetLabels();
            OnStart();
            BeginTimer();
        }

        static public void NextPressed()
        {
            form.Answer.Hide();
            SetLabels();
            BeginTimer();
        }

        static void SetLabels()
        {
            stringPair = stringHandler.GetPair();
            if (!isReversed)
            {              
                form.Question.Text = stringPair.Key.ToString();
                form.Answer.Text = stringPair.Value;
            }
            else
            {
                form.Answer.Text = stringPair.Key.ToString();
                form.Question.Text = stringPair.Value;
            }
        }

        static private void TimerSet()
        {
            timer.Elapsed += new System.Timers.ElapsedEventHandler(TimerTrigger);
            timer.AutoReset = false;
            timer.SynchronizingObject = form;
            UpdateTimer();
        }

        static public void UpdateTimer()
        {
            timer.Interval = form.switchInterval * 1000;
        }

        static private void BeginTimer()
        {
            timer.Enabled = true;
        }

        static private void TimerTrigger(object sender, EventArgs e)
        {
            form.Answer.Show();
        }

        static private void OnStart()
        {
            form.Reverse.Enabled = false;
            form.Next.Enabled = true;
            form.Start.Enabled = false;
        }

    }
}

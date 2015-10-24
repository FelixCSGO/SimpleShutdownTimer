using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleShutdownTimer
{
    public partial class simpleShutDownTimer : Form
    {
        System.Threading.Timer mainTimer;
        private bool timerRunning = false;

        public simpleShutDownTimer()
        {
            Font = SystemFonts.MessageBoxFont;
            MessageBox.Show("Welcome to the Beta of ShutDownTimer"); // This is a MessageBox (:
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Stop.Enabled = false; //Disable the stop button because it doesn't need to be stopped.
        }

        public void TimerCallback(object state)
        {
            //do the shutdown thing here
            //MessageBox.Show("Not actually going to shut down!");
            var psi = new ProcessStartInfo("shutdown", "/s /t 0");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
        }

        public void Button30m_Click(object sender, EventArgs e)
        {
            TimeSpan timeSpan = new TimeSpan(0, 30, 0); //0 hours, 30 minutes, 0 seconds
            TimeSpan nil = new TimeSpan(0, 0, 0, 0, -1);
            mainTimer = new System.Threading.Timer(TimerCallback, null, timeSpan, nil); //This starts the timer also
            runningTimer();
        }

        public void Button_45m_Click(object sender, EventArgs e)
        {
            TimeSpan timeSpan = new TimeSpan(0, 45, 0); // 0 hours, and 45 mins, 0 seconds.
            TimeSpan nil = new TimeSpan(0, 0, 0, 0, -1);
            mainTimer = new System.Threading.Timer(TimerCallback, null, timeSpan, nil); // Fuck you (^:
            runningTimer();
        }

        public void button2hr_Click(object sender, EventArgs e)
        {
            TimeSpan timeSpan = new TimeSpan(2, 0, 0); // 2 hours, and 0 mins, and 0 seconds.
            TimeSpan nil = new TimeSpan(0, 0, 0, 0, -1);
            mainTimer = new System.Threading.Timer(TimerCallback, null, timeSpan, nil);
            runningTimer();
        }

        public void button_4hrs_Click(object sender, EventArgs e)
        {
            TimeSpan timeSpan = new TimeSpan(4, 0, 0);
            TimeSpan nil = new TimeSpan(0, 0, 0, 0, -1);
            mainTimer = new System.Threading.Timer(TimerCallback, null, timeSpan, nil);
            runningTimer();
        }

        public void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);            
        }

        public void Stop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The timer was stopped, the application will now close.");
            runningTimer();
            Environment.Exit(0);
        }

        public void help_button_Click(object sender, EventArgs e)
        {
            new help_Form().Show();
        }


        public void runningTimer()
        {
            timerRunning = true;
            Stop.Enabled = true;
            Button30m.Enabled = false;
            Button_45m.Enabled = false;
            button2hr.Enabled = false;
            button_4hrs.Enabled = false;
            buttonCustom.Enabled = false;
        }

        private void button_Custom(object sender, EventArgs e)
        {
            MessageBox.Show("This is being developed (;");
            new customTimer_Form().Show();
        }



        /*
        private void button1_Click(object sender, EventArgs e)
        {
        TimeSpan timeSpan = new TimeSpan(0, 0, 5);
        TimeSpan nil = new TimeSpan(0, 0, 0, 0, -1);
        mainTimer = new System.Threading.Timer(TimerCallback, null, timeSpan, nil);
        timerRunning = true;

        Stop.Enabled = true;
        Button30m.Enabled = false;
        Button_45m.Enabled = false;
        button2hr.Enabled = false;
        button_4hrs.Enabled = false;
        customTimeButton.Enabled = false;
        }
        */

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DateTime baseTime;
        int secondsToAdd = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            baseTime = DateTime.Now;
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            secondsToAdd++;
            label1.Text = baseTime.AddSeconds(secondsToAdd).ToString("HH:mm:ss");
            label1.Visible=true;
        }

    }
}

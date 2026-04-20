using shutty_utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static utility.Program;

namespace utility
{
    //public partial class Form1 : BaseForm { }
    public partial class Form1 : BaseForm
    {
        int elapsed, remaining;
        int total_seconds = 1;

        const int max_value = 1441;
        const int min_value = 1;

        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Value = 5;
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
        }
        private void UpdateHistory()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(Logger.History.ToArray());
        }
        //reset timer
        public void TimerReset()
        {
            timer2.Stop();
            total_seconds = Program.time * 60;
        }
        public void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Program.time = (int)numericUpDown1.Value;
            total_seconds = Program.time * 60;
        }
        //shutdown button
        private async void button1_Click(object sender, EventArgs e)
        {
            if (Program.time >= max_value)
            {
                Logger.Add("Enter the correct time(max value 1440)!");
                UpdateHistory();
            }
            else if (Program.time < min_value)
            {
                Logger.Add("Enter the correct time(min value 1)!");
                UpdateHistory();
            }
            else 
            {
                await Program.ShutDownPc();
                UpdateHistory();

                remaining = total_seconds;
                timer2.Start();
            }
        }
        //restart button
        private async void button3_Click(object sender, EventArgs e)
        {
            if (Program.time >= max_value)
            {
                Logger.Add("Enter the correct time(max value 1440)!");
                UpdateHistory();
            }
            else if (Program.time <= min_value)
            {
                Logger.Add("Enter the correct time(min value 1)!");
                UpdateHistory();
            }
            else
            {
                Program.RestartPc();
                UpdateHistory();

                remaining = total_seconds;
                timer2.Start();
            }
        }

        //exit application button
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //form2
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 info = new Form2(this);
            info.Show();
        }

        //undo button
        private void button2_Click(object sender, EventArgs e)
        {
            Program.Undo();
            UpdateHistory();
            TimerReset();
        }

        //logic timer2
        public void timer2_Tick(object sender, EventArgs e)
        {
            if (remaining > 0)
            {
                elapsed = total_seconds - remaining;
                string time_print = TimeSpan.FromSeconds(remaining).ToString(@"hh\:mm\:ss");

                label3.Text = time_print + "|" + CreateProgressBar(elapsed, total_seconds);
                remaining--;
            }
            else
            {
                timer2.Stop();
            }
        }

        //progress bar
        private string CreateProgressBar(int cur, int total)
        {
            const int width = 47;
            int filled = (cur * width) / total;
            StringBuilder bar = new StringBuilder("[");
            
            for (int i = 0; i < width; i++)
            {
                bar.Append(i < filled ? "█" : "░");
            }
            bar.Append("]");
           
            return bar.ToString();
        }
    }
}
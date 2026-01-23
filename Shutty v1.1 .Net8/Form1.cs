using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static utility.Program;

namespace utility
{
    public partial class Form1 : Form
    {
        int elapsed, remining;

        int timer = 1;
        
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
            timer = Program.time * 60;
        }

        public void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Program.time = (int)numericUpDown1.Value;
            timer = Program.time * 60;
        }

        //shutdown button
        private void button1_Click(object sender, EventArgs e)
        {
            Program.ShutDownPc();
            UpdateHistory();

            remining = timer;
            timer2.Start();

        }

        //restart button

        private void button3_Click(object sender, EventArgs e)
        {
            Program.RestartPc();

            UpdateHistory();
            remining = timer;
            timer2.Start();
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
            Form2 info = new Form2();
            info.ShowDialog();
        }

        //undo button
        private void button2_Click(object sender, EventArgs e)
        {
            Program.Undo();

            UpdateHistory();

            TimerReset();
        }

        //logic timer2
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (remining > 0)
            {
                elapsed = timer - remining;
                string time_print = TimeSpan.FromSeconds(remining).ToString(@"mm\:ss");

                label3.Text = time_print + "|" + CreateProgressBar(elapsed, timer);
                remining--;
            }

            else
            {
                timer2.Stop();
            }
        }

        //progress bar
        private string CreateProgressBar(int cur, int total)
        {
            const int width = 50;

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
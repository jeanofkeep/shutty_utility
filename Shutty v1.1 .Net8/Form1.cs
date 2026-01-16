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
        //int timer = 60 * 2;

        int remining;
        int timer = 1;
        string time_print;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Program.ShutDownPc();

            UpdateHistory();

            //totalValue = 10;
            remining = timer;

            timer2.Start();
            //MessageBox.Show("Start");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.RestartPc();

            UpdateHistory();
            remining = timer;
            timer2.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 info = new Form2();
            info.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.Undo();

            UpdateHistory();

            TimerReset();

        }

        //###################################################

        //Logicl timer
        
        public void timer22_Tick(object? sender, EventArgs e)
        { 
            
            label3.Text = TimeSpan.FromSeconds(timer).ToString(@"mm\:ss");
            
            if (timer == 0)
            {
                timer2.Stop();
                label3.Text = "Готово!";
            }

            else
            {
                timer--;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (remining > 0)
            {
                int elapsed = timer - remining;
                string time_print = TimeSpan.FromSeconds(remining).ToString(@"mm\:ss");

                //label3.Text = CreateProgressBar(elapsed, timer);
                label3.Text = time_print + "|" +CreateProgressBar(elapsed, timer);
                remining--;
            }

            else
            {
                timer1.Stop();
                //percents = 100;
                //lblTimer.Text = "[█████████████████████████] Готово!";
            }

        }

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
            //bar.Append(i < filled ? "█" : "░");
            //bar.Append("░");
            //bar.Append("█");
            //bar.Append("▌ ");


            return bar.ToString();

        }




        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
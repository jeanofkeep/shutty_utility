using static utility.Program;
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

/*
 * public partial class Form1 : Form
    {
        int seconds = 4; // сколько секунд считать

        public Form1()
        {
            InitializeComponent();
            lblTimer.Text = seconds.ToString();

            timer1.Tick += timer1_Tick;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            seconds = 4; // сброс таймера
            lblTimer.Text = seconds.ToString();
            timer1.Start();
            MessageBox.Show("Start");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds--;

            lblTimer.Text = seconds.ToString();

            //MessageBox.Show("tick");

            


            if (seconds <= 0)
            {
                timer1.Stop();
                
                lblTimer.Text = "Готово!";
            }
        }

 */

namespace utility
{
    public partial class Form1 : Form
    {
        //int timer = 0;

        //private Timer timer2;

        //timer2 = new System.Windows.Forms.Timer();

        int timer = 1 * 60;

        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Value = 5;
            //int timer = 0;
            //shutdownTimer.Interval = 1000;
            
            label3.Text = TimeSpan.FromSeconds(timer).ToString(@"mm\:ss");

            

            timer2.Interval = 1000;

            timer2.Tick += timer2_Tick;

            //timer2.Enabled = true;

            //timer2.Start();

            //timer2 = new System.Windows.Forms.Timer();



            //timer2.Tick += new EventHandler(timer2_Tick);
        }

        

        private void UpdateHistory()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(Logger.History.ToArray());
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            Program.time = (int)numericUpDown1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //label3.Text = TimeSpan.FromSeconds(timer).ToString(@"mm\:ss");

            Program.ShutDownPc();

            UpdateHistory();

            //timer = Program.time * 60;

            //timer = 5 * 60;

            //int minutes = timer / 60;
            //int seconds = timer % 60;

            //label3.Text = timer.ToString($"off in {minutes}:{seconds}");

            //label3.Text = $"off in:{timer}";

            timer2.Start();
            //MessageBox.Show("Start");
        }



        private void button3_Click(object sender, EventArgs e)
        {
            Program.RestartPc();

            UpdateHistory();
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
        }

        private void timer2_Tick(object? sender, EventArgs e)
        {
            

            //int timer = Program.time * 60;

            

            //TimeSpan time = TimeSpan.FromSeconds(timer);
            label3.Text = TimeSpan.FromSeconds(timer).ToString(@"mm\:ss"); // формат mm:ss

            //int minutes = timer / 60;
            //int seconds = timer % 60;

            //label3.Text = $"off in {minutes:D2}:{seconds:D2}";


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

        private void UpdateTimer()
        {


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

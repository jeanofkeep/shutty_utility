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
        

        //private Timer timer2;

        //timer2 = new System.Windows.Forms.Timer();

        //int timer = Program.time * 60;
        //int timer = 60 * 2;

        int timer = 0;

        //int test_X = 60 * 2;
        int test_X = 1;

        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Value = 5;
            //int timer = 0;
            //shutdownTimer.Interval = 1000;
            
            label3.Text = TimeSpan.FromSeconds(timer).ToString(@"mm\:ss");

            

            timer2.Interval = 1000;

            timer2.Tick += timer2_Tick;
        }

        

        private void UpdateHistory()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(Logger.History.ToArray());
        }

        public void timer_reset(object? sender, EventArgs e)
        {
            timer2.Stop();
            test_X = Program.time * 60;
        }

        public void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            Program.time = (int)numericUpDown1.Value;
            
            test_X = Program.time * 60;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //label3.Text = TimeSpan.FromSeconds(timer).ToString(@"mm\:ss");

            Program.ShutDownPc();

            UpdateHistory();

            timer2.Start();
            //MessageBox.Show("Start");
        }



        private void button3_Click(object sender, EventArgs e)
        {
            Program.RestartPc();

            UpdateHistory();

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
            //timer_reset();

            timer2.Stop();
            test_X = Program.time * 60;
            //label3.Text = "00:00";
            //timer2.Enabled = false;
        }

        //###################################################

        //Logicl timer
        
        public void timer2_Tick(object? sender, EventArgs e)
        { 
            
            label3.Text = TimeSpan.FromSeconds(test_X).ToString(@"mm\:ss"); // формат mm:ss

            //int minutes = timer / 60;
            //int seconds = timer % 60;

            //MessageBox.Show(test);
            //label3.Text = $"off in {test_X}";


            if (test_X == 0)
            {
                timer2.Stop();
                label3.Text = "Готово!";
            }

            else
            {
                test_X--;
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

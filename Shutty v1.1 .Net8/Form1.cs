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
using System.Drawing.Drawing2D;
using static utility.Program;


namespace utility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Value = 5;
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
            Program.ShutDownPc();

            UpdateHistory();
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

    }
}

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


namespace utility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.ActiveControl = this;
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Program.time = (int)numericUpDown1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.ShutDownPc();

            MessageBox.Show($"PC shutdown in {Program.time} min!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.RestartPc();
            MessageBox.Show($"PC restart in {Program.time} min!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}

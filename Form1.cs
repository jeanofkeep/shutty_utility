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
            int radius = 20; // радиус скругления углов
            var path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(button2.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(button2.Width - radius, button2.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, button2.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            button2.Region = new Region(path);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.RestartPc();
            MessageBox.Show($"PC restart in {Program.time} min!");
        }

        
    }
}

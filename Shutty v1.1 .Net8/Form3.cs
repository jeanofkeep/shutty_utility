using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace utility
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            //label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            //label1.Top = (this.ClientSize.Height - label1.Height) / 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 info = new Form2();
            info.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox2.Text);
        }
    }
}

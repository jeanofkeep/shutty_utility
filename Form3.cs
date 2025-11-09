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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 info = new Form2();
            info.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, (object)textBox1);
        }
    }
}

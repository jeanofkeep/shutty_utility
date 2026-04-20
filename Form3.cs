using shutty_utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace utility
{
    public partial class Form3 : BaseForm
    {
        private readonly Form2 _owner;
        public Form3(Form2 owner)
        {
            InitializeComponent();
            _owner = owner;
            this.ShowInTaskbar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            _owner.Show();
        }

        //copy buttons
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
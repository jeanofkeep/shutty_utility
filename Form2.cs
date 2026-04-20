using shutty_utility;
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
    public partial class Form2 : BaseForm
    {
        private readonly Form1 _owner;
        public Form2(Form1 owner)
        {
            InitializeComponent();
            _owner = owner;
            this.ShowInTaskbar = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            _owner.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 support = new Form3(this);
            support.Show();
        }
    }
}
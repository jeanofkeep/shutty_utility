using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using utility;

namespace shutty_utility
{
    public class BaseForm : Form
    {
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //check exit button
            Form1 main = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (main != null && main.timer2.Enabled)
            {
                DialogResult result = MessageBox.Show(
                    "The shutdown  timer will continue even after closing the app. Exit anyway?",
                    "Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                    e.Cancel = true;
            }
            base.OnFormClosing(e);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter7
{
    public partial class Timer : Form
    {
        public Timer()
        {
            InitializeComponent();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int num = Convert.ToInt16(lblnum.Text);
            num++;
            lblnum.Text = num.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer2.Enabled == false)
            {
                int interval=Convert.ToInt16(txtinterval.Text);
                timer2.Interval= interval;  // use method (.interval) to call that in properties //
                timer2.Enabled = true;
            }
            else
            {
                timer2.Enabled = false;
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            
        }
    }
}

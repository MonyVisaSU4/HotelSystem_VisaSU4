using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter7
{
    public partial class Timer_Game : Form
    {
        public Timer_Game()
        {
            InitializeComponent();
        }

        private  void timer2_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int num = random.Next(0, 100);
            //int num = Convert.ToInt16(lblnum.Text);
            //num++;
            lblnum.Text = num.ToString();
        }

        private  void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt16(lblnum.Text);
            
            lblnum.Text = num.ToString();
            
            
                int interval = Convert.ToInt16(txtspeed.Text);
                timer2.Interval = interval;  // use method (.interval) to call that in properties //
                timer2.Enabled = true;
          
            

        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            int num = Convert.ToInt16(lblnum.Text);
            int guess = Convert.ToInt16(txtguess.Text);
            if (guess == num)
            {
                lblshow.Text = guess.ToString("Ok You Win");
            }
            else
            {
                lblshow.Text = guess.ToString("Yo Lose Bro");
            }
        }

        private void lblnum_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker_2._0
{
    public partial class Form1 : Form
    {
        int counter = 0;
        int time = 0;
        int round = 0;
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
        }

        private void clickbutton_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            counter++;
            numberlabel.Text = counter.ToString();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time++;
            timelabel.Text = time.ToString();
            if (time == 5)
            {
                timer.Enabled = false;
                clickbutton.Enabled = false;
                round++;
                dataGridView1.Rows.Add(round, counter);
            }
        }

        private void restart()
        {
            clickbutton.Enabled = true;
            time = 0;
            counter = 0;
            timelabel.Text = time.ToString();
            numberlabel.Text = counter.ToString();
        }

        private void restartbutton_Click(object sender, EventArgs e)
        {
            restart();
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}

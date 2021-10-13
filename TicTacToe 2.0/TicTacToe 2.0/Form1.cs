using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_2._0
{
    public partial class Form1 : Form
    {
        int player;
        int x = 0;
        int o = 0;
        int round = 1;
        public Form1()
        {
            InitializeComponent();
            player = 1;
            label1.Text = "Player 1 : Start the game!";
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (player)
            {
                case 1:
                    sender.GetType().GetProperty("Text").SetValue(sender, "x");
                    player = 0;
                    label1.Text = "Player 2 : Your turn!";
                    break;
                case 0:
                    sender.GetType().GetProperty("Text").SetValue(sender, "o");
                    player = 1;
                    label1.Text = "Player 1 : Your turn!";
                    break;
            }
            sender.GetType().GetProperty("Enabled").SetValue(sender, false);
            checkWin();
        }

        private void checkWin()
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text)
            {
                if (button1.Text != "")
                {
                    if (button1.Text == "x")
                    {
                        x++;
                        label5.Text = x.ToString();
                        round++;
                        label8.Text = round.ToString();
                        stopGame();
                    }
                    else
                    {
                        o++;
                        label6.Text = o.ToString();
                        round++;
                        label8.Text = round.ToString();
                        stopGame();
                    }
                }
            }
            if (button4.Text == button5.Text && button5.Text == button6.Text)
            {
                if (button4.Text != "")
                {
                    if (button4.Text == "x")
                    {
                        x++;
                        label5.Text = x.ToString();
                        round++;
                        label8.Text = round.ToString();
                        stopGame();
                    }
                    else
                    {
                        o++;
                        label6.Text = o.ToString();
                        round++;
                        label8.Text = round.ToString();
                        stopGame();
                    }
                }
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text)
            {
                if (button7.Text != "")
                {
                    if (button7.Text == "x")
                    {
                        x++;
                        label5.Text = x.ToString();
                        round++;
                        label8.Text = round.ToString();
                        stopGame();
                    }
                    else
                    {
                        o++;
                        label6.Text = o.ToString();
                        round++;
                        label8.Text = round.ToString();
                        stopGame();
                    }
                }
            }
            if (button1.Text == button4.Text && button4.Text == button7.Text)
            {
                if (button1.Text != "")
                {
                    if (button1.Text == "x")
                    {
                        x++;
                        label5.Text = x.ToString();
                        round++;
                        label8.Text = round.ToString();
                        stopGame();
                    }
                    else
                    {
                        o++;
                        label6.Text = o.ToString();
                        round++;
                        label8.Text = round.ToString();
                        stopGame();
                    }
                }
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text)
            {
                if (button2.Text != "")
                {
                    if (button2.Text == "x")
                    {
                        x++;
                        label5.Text = x.ToString();
                        round++;
                        label8.Text = round.ToString();
                        stopGame();
                    }
                    else
                    {
                        o++;
                        label6.Text = o.ToString();
                        round++;
                        label8.Text = round.ToString();
                        stopGame();
                    }
                }
            }
            if (button3.Text == button6.Text && button6.Text == button9.Text)
            {
                if (button3.Text != "")
                {
                    if (button3.Text == "x")
                    {
                        x++;
                        label5.Text = x.ToString();
                        round++;
                        label8.Text = round.ToString();
                        stopGame();
                    }
                    else
                    {
                        o++;
                        label6.Text = o.ToString();
                        round++;
                        label8.Text = round.ToString();
                        stopGame();
                    }
                }
            }
            if (button1.Text == button5.Text && button5.Text == button9.Text)
            {
                if (button1.Text != "")
                {
                    if (button1.Text == "x")
                    {
                        x++;
                        label5.Text = x.ToString();
                        round++;
                        label8.Text = round.ToString();
                        stopGame();
                    }
                    else
                    {
                        o++;
                        label6.Text = o.ToString();
                        round++;
                        label8.Text = round.ToString();
                        stopGame();
                    }
                }
            }
            if (button3.Text == button5.Text && button5.Text == button7.Text)
            {
                if (button3.Text != "")
                {
                    if (button3.Text == "x")
                    {
                        x++;
                        label5.Text = x.ToString();
                        round++;
                        label8.Text = round.ToString();
                        stopGame();
                    }
                    else
                    {
                        o++;
                        label6.Text = o.ToString();
                        round++;
                        label8.Text = round.ToString();
                        stopGame();
                    }
                }
            }
            if (round > 5)
            {
                button10.Enabled = false;
                label8.Text = "5";
                if (x > o)
                {
                    label2.Text = "Player 1 : Wins!";
                }
                if (x < o)
                {
                    label2.Text = "Player 2 : Wins!";
                }
            }
        }
        public void clearGame()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            label2.Text = "No winner yet";
            
        }

        public void stopGame()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            clearGame();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            clearGame();
            button10.Enabled = true;
            label5.Text = "0";
            label6.Text = "0";
            label8.Text = "1";
            o = 0;
            x = 0;
            round = 1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BullsAndCows
{
    public partial class Form1 : Form
    {
        string mysteryNumbers = "";
        const int mysteryNumbersLong = 4;
        int stepCount = 0;

        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Random random = new Random();
            for (int i = 0; i < mysteryNumbersLong; i++)
            {
                int nIndex = random.Next(0, numbers.Count);
                mysteryNumbers += numbers[nIndex].ToString();
                numbers.RemoveAt(nIndex);
            }
            label1.Text = mysteryNumbers;
        }

        private void buttonroll_Click(object sender, EventArgs e)
        {
            string playerNumber = inputtextBox.Text;

            if (!numbersControl(playerNumber))
            {
                return;
            }

            stepCount++;

            int bullsCount = CalculateBulls(playerNumber);
            int cowsCount = CalculateCows(playerNumber);

            bullcountlabel.Text = $"bulls = {bullsCount}";
            cowcountlabel.Text = $"cows = {cowsCount}";

            dataGridView1.Rows.Add(stepCount, playerNumber, bullsCount, cowsCount);

            if(bullsCount == mysteryNumbersLong)
            {
                MessageBox.Show("Hell yeah, You win with" + stepCount + "step(s)!");
                buttonroll.Enabled = false;
                inputtextBox.Enabled = false;
            }
        }

        private int CalculateBulls(string playerNumber)
        {
            int y = 0;
            for (int i = 0; i < mysteryNumbersLong; i++)
            {
                if (mysteryNumbers[i] == playerNumber[i])
                {
                    y++;
                }
            }
            return y;
        }

        private int CalculateCows(string playerNumber)
        {
            int x = 0;
            for (int i = 0; i < mysteryNumbersLong; i++)
            {
                for (int j = 0; j < mysteryNumbersLong; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    if (mysteryNumbers[i] == playerNumber[j])
                    {
                        x++;
                    }
                }
            }
            return x;
        }

        private bool numbersControl(string playerNumber)
        {
            if (playerNumber.Length != mysteryNumbersLong)
            {
                MessageBox.Show("Incorrect value!\nTry another one!");
                return false;
            }

            for (int i = 0; i < mysteryNumbersLong; i++)
            {
                if (!char.IsDigit(playerNumber[i]))
                {
                    MessageBox.Show("Incorrect value!\nTry another one!");
                    return false;
                }
            }

            for (int i = 0; i < playerNumber.Length; i++)
            {
                for (int j = i + 1; j < playerNumber.Length; j++)
                {
                    if (playerNumber[i] == playerNumber[j])
                    {
                        MessageBox.Show("Incorrect value!\nTry another one!");
                        return false;
                    }
                }
            }
            return true;
        }

        private void playbutton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}

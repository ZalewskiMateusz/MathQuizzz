using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuizzz
{
    public partial class Form1 : Form
    {
        Random randomizer = new Random();
        int leftNumber;
        int rightNumber;
        int timeLeft;
        public Form1()
        {
            InitializeComponent();
        }

        private void startTheQuizzBtn_Click(object sender, EventArgs e)
        {
            //here enter rest calculation
            leftNumber = randomizer.Next(51);
            rightNumber = randomizer.Next(51);
            leftNumberLbl.Text = leftNumber.ToString();
            rightNumberLbl.Text = rightNumber.ToString();
            result.Value = 0;

            timeLeft = 30;
            timeLeftLbl.Text = "30 seconds";
            timer1.Start();

        }
        private bool CheckTheAnswer()
        {
            if (leftNumber + rightNumber == result.Value)
                return true;
            else
                return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {

                timer1.Stop();
                MessageBox.Show("You got all the answers right!",
                                "Congratulations!");
                // startTheQuizzBtn.Enabled = true;
            }
            else if (timeLeft > 0)
            {

                timeLeft = timeLeft - 1;
                timeLeftLbl.Text = timeLeft + " seconds";
            }
            else
            {

                timer1.Stop();
                timeLeftLbl.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                //startTheQuizzBtn.Enabled = true;
            }
        }
    }
}

using System;
using System.Windows.Forms;

namespace StudentProfile
{
    public partial class Form1 : Form
    {
        int currentNumber = 10000;
        int userNumber = 10004;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentNumber++;

            int difference = userNumber - currentNumber;

            if (difference <= 3 && difference > 0)
            {
                MessageBox.Show(
                    "Your turn is near!\nYour number is P - " + userNumber,
                    "LineUpNow",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Student:");
        }
    }

    }




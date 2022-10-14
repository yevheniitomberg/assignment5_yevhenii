using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment5_yevhenii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RandomNumber();
            this.label_guesses.Text = "0";
            this.label5.Text = "0";
        }

        private void button_guess_Click(object sender, EventArgs e)
        {
            this.label5.Text = (int.Parse(this.label5.Text) + 1).ToString();
            try
            {
                int guess = int.Parse(this.textBox1.Text);
                if (guess > this.randomNumber)
                {
                    this.label_status.Text = "Too high, try again";
                } else if (guess < this.randomNumber)
                {
                    this.label_status.Text = "Too low, try again";
                } else
                {
                    this.label_status.Text = "Congrats! New number is ready to guess";
                    this.label_guesses.Text = (int.Parse(this.label_guesses.Text) + 1).ToString();
                    RandomNumber();
                }
            } 
            catch
            {
                MessageBox.Show("Wrong input type!", "Input Error", MessageBoxButtons.OK);
            }
        }

        private void button_finish_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your num of guesses is " + this.label_guesses.Text, "Congrats!", MessageBoxButtons.OK);
            this.label_status.Text = "";
            this.label_guesses.Text = "0";
            this.label5.Text = "0";
            RandomNumber();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

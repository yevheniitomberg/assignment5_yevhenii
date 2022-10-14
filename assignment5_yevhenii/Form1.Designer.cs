using System;
using System.Security.Cryptography;

namespace assignment5_yevhenii
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 

        private void RandomNumber()
        {
            this.randomNumber = new Random().Next(1, 101);
        }

        private void InitializeComponent()
        {
            this.button_guess = new System.Windows.Forms.Button();
            this.button_finish = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_guesses = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_guess
            // 
            this.button_guess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_guess.Location = new System.Drawing.Point(153, 186);
            this.button_guess.Name = "button_guess";
            this.button_guess.Size = new System.Drawing.Size(139, 32);
            this.button_guess.TabIndex = 0;
            this.button_guess.Text = "Try to guess";
            this.button_guess.UseVisualStyleBackColor = true;
            this.button_guess.Click += new System.EventHandler(this.button_guess_Click);
            // 
            // button_finish
            // 
            this.button_finish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_finish.Location = new System.Drawing.Point(34, 186);
            this.button_finish.Name = "button_finish";
            this.button_finish.Size = new System.Drawing.Size(86, 32);
            this.button_finish.TabIndex = 1;
            this.button_finish.Text = "Finish the Game";
            this.button_finish.UseVisualStyleBackColor = true;
            this.button_finish.Click += new System.EventHandler(this.button_finish_Click);
            // 
            // button_exit
            // 
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_exit.Location = new System.Drawing.Point(326, 186);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(86, 32);
            this.button_exit.TabIndex = 2;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(125, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Your guess";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(160, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Status: ";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_status.Location = new System.Drawing.Point(225, 149);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(0, 20);
            this.label_status.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.Location = new System.Drawing.Point(224, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(111, 26);
            this.textBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Num of guesses: ";
            // 
            // label_guesses
            // 
            this.label_guesses.AutoSize = true;
            this.label_guesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_guesses.Location = new System.Drawing.Point(151, 4);
            this.label_guesses.Name = "label_guesses";
            this.label_guesses.Size = new System.Drawing.Size(0, 20);
            this.label_guesses.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(106, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Try to guess a number from 1 to 100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(151, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(4, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Num of tries: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 236);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_guesses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_finish);
            this.Controls.Add(this.button_guess);
            this.Name = "Form1";
            this.Text = "Guesser Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_guess;
        private System.Windows.Forms.Button button_finish;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_guesses;
        private int randomNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}


﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form : System.Windows.Forms.Form
    {
        bool Player1 = true;

        public Form()
        {
            InitializeComponent();
            b1.Click += ClickCheck;
            b2.Click += ClickCheck;
            b3.Click += ClickCheck;
            b4.Click += ClickCheck;
            b5.Click += ClickCheck;
            b6.Click += ClickCheck;
            b7.Click += ClickCheck;
            b8.Click += ClickCheck;
            b9.Click += ClickCheck;
        }

        private void bexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void babout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Kayleigh van de Wiel");
        }

        private void ClickCheck(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button b = sender as Button;

                if (Player1 == true && b.Text == "")
                {
                    b.Text = "X";
                    Player1 = false;
                }
                else if (b.Text == "X" || b.Text == "O") {
                    MessageBox.Show("Oops!");
                }
                else
                {
                    b.Text = "O";
                    Player1 = true;
                }
            }
            else
            {
                MessageBox.Show("Oops! Something went wrong!");
                Application.Exit();
            }
               
        }
    }
}

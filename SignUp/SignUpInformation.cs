﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NadhamniCSharp
{
    public partial class Signup1 : Form
    {
        public Signup1()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }


         SignUpChild f1;
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            f1 = new SignUpChild();
            f1.Show();

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Hide_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f1 = new LoginForm();
            f1.Show();
        }

        private void SignUp_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class SignUpChild : Form
    {
        public SignUpChild()
        {
            InitializeComponent();
        }
            
         SignUpPartner f1;
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            f1 = new SignUpPartner();
            f1.Show();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
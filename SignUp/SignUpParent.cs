using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NadhamniCSharp.SignUp
{
    public partial class SignUpParent : Form
    {
        public SignUpParent()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuRadioButton2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuRadioButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }
        private SingupInformation f1;
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            SingupInformation f1 = new SingupInformation();
            this.Hide();
            f1.Show();
        }

        private void SignUp_ImportImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.InitialDirectory = "c:\\";
            of.Title = "Choose a picture";
            of.Filter = "JPG & PNG images|*.png;*.jpg";
            if (of.ShowDialog() == DialogResult.OK)
            {
                Parent_Picture.Image = Image.FromFile(of.FileName);

            }
        }

        private void SignUp_Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You sure to exit application?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                Application.Exit();
        }
    }
 }


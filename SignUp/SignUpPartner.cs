using System;
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
    public partial class SignUpPartner : Form
    {
        public SignUpPartner()
        {
            InitializeComponent();
        }
        HomeForm f1;
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            f1 = new HomeForm();
            f1.Show();

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel15_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private SingupInformation f2;
        private void Partner_Cancel_Click(object sender, EventArgs e)
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
                Partner_Picture.Image = Image.FromFile(of.FileName);

            }
        }

        private void SignUp_Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You sure to exit application?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                Application.Exit();
        }
    }
}

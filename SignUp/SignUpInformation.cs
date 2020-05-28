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
    public partial class SingupInformation : Form
    {
        public SingupInformation()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

   
        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }


        SignUp.ParentChild f2;
        SignUpPartner f3;
        private void bunifuButton1_Click(object sender, EventArgs e)
        {

            if (!((string.IsNullOrWhiteSpace(SignUp_Username.Text)) | (string.IsNullOrWhiteSpace(SignUp_Password.Text)) | (string.IsNullOrWhiteSpace(SignUp_FamName.Text)) | (string.IsNullOrWhiteSpace(SignUp_FirstName.Text)) | (string.IsNullOrWhiteSpace(SignUp_Email.Text)) | (string.IsNullOrWhiteSpace(SignUp_AdressN.Text) | (string.IsNullOrWhiteSpace(SignUp_AdressA.Text)) | (string.IsNullOrWhiteSpace(SignUp_AdressZIP.Text)))))
            {
                if (SignUp_Status_Single.Checked == false)
                {
                    SignUpPartner f3 = new SignUpPartner();
                    this.Hide();
                    f3.Show();
                }
                else
                {
                    SignUp.ParentChild f2 = new SignUp.ParentChild();
                    this.Hide();
                    f2.Show();
                }
            }
            else
            {
                MessageBox.Show("All field must be filled");
            }

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
            if (MessageBox.Show("Are You sure to exit application?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog of = new OpenFileDialog();
            of.InitialDirectory = "c:\\";
            of.Title = "Choose a picture";
            of.Filter = "JPG & PNG images|*.png;*.jpg";
            if(of.ShowDialog() ==DialogResult.OK)
            {
                SignUp_Picture.Image = Image.FromFile(of.FileName);

            }
        }
    }
}

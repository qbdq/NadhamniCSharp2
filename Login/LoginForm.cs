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
    public partial class LoginForm : Form
    {

        static DataClasses1DataContext NadhamniDB = new DataClasses1DataContext();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
           
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void LoginUsername_OnValueChanged(object sender, EventArgs e)
        {

            
        }

        private void LoginPassword_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click_1(object sender, EventArgs e)
        {

        }
       

        private void bunifuButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void ForgetPassword_Click(object sender, EventArgs e)
        {

        }

        private HomeForm f2;
        private void LoginButton_Click(object sender, EventArgs e)
        {
            f2 = new HomeForm();
            f2.Show();
            this.Hide();
        }

        private void LoginClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void LoginHide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private SingupInformation f3;
        private void SinUpButton_Click(object sender, EventArgs e)
        {
            SingupInformation f3 = new SingupInformation();
            this.Hide();
            f3.Show();
            
        }
    }
}

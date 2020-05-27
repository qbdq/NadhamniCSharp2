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
        private HomeForm f2;
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
            f2 = new HomeForm();
            f2.Show();
            this.Hide();

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {

        }
        private Signup1 f3;
        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {
            f3 = new Signup1();
            f3.Show();
            this.Hide();
            
        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}

using NadhamniCSharp.UserControl_pages.Calandar;
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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
        
        }

        private void bunifuGradientPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePanel.Controls.Clear();
            SidePanel.Height = HomePage_Home.Height;
            SidePanel.Location = HomePage_Home.Location;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HomePanel.Controls.Clear();
            SidePanel.Height = HomePage_Profile.Height;
            SidePanel.Location = HomePage_Profile.Location;
            if (!HomePanel.Controls.Contains(Profile.Instance))
            {
                HomePanel.Controls.Clear();
                HomePanel.Controls.Add(Profile.Instance);
            }
     

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomePanel.Controls.Clear();
            SidePanel.Height = HomePage_Dashboard.Height;
            SidePanel.Location = HomePage_Dashboard.Location;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            HomePanel.Controls.Clear();
            SidePanel.Height = HomePage_Calendar.Height;
            SidePanel.Location = HomePage_Calendar.Location;
            if (!HomePanel.Controls.Contains(HomeCalander.Instance))
            {
                HomePanel.Controls.Clear();
                HomePanel.Controls.Add(HomeCalander.Instance);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomePanel.Controls.Clear();
            SidePanel.Height = HomePage_Thisweek.Height;
            SidePanel.Location = HomePage_Thisweek.Location;


        }



        private void bunifuButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {

        }

        private void profile1_Load(object sender, EventArgs e)
        {
            if (!HomePanel.Controls.Contains(Profile.Instance))
            {
                HomePanel.Controls.Clear();
                HomePanel.Controls.Add(Profile.Instance);
            }

        }

        private void homeUserControle1_Load(object sender, EventArgs e)
        {
                HomePanel.Controls.Clear();
                HomePanel.Controls.Add(Profile.Instance);
        }

        private void HomePanel_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}

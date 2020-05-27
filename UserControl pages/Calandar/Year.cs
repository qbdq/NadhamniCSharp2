using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace NadhamniCSharp.UserControl_pages.Calandar
{
    public partial class Year : UserControl
    {
        public static Year _instance;
        public static Year Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Year();
                return _instance;
            }
        }
        public Year()
        {
            InitializeComponent();
        }


    
        private void _Label13_Click(object sender, EventArgs e)
        {

        }

        private void _Label9_Click(object sender, EventArgs e)
        {

        }

        private void _Label5_Click(object sender, EventArgs e)
        {

        }

        private void _Label12_Click(object sender, EventArgs e)
        {

        }

        private void _Label4_Click(object sender, EventArgs e)
        {

        }

        private void _Label8_Click(object sender, EventArgs e)
        {

        }

        private void _Label11_Click(object sender, EventArgs e)
        {

        }

        private void _Label7_Click(object sender, EventArgs e)
        {

        }

        private void _Label1_Click(object sender, EventArgs e)
        {

        }

        private void _Label3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

            
            if (Conversions.ToDouble(Label2.Text) == DateTime.Today.Year)
            {
                int monthno = DateTime.Today.Month;
                transparentlabels();
                if (monthno == 1)
                {
                    Label2.BackColor = Color.FromArgb(176, 180, 43);
                    }
                    else if (monthno == 2)
                    {
                        Label3.BackColor = Color.FromArgb(176, 180, 43);
                    }
                    else if (monthno == 3)
                    {
                        Label4.BackColor = Color.FromArgb(176, 180, 43);
                    }
                    else if (monthno == 4)
                {
                    Label5.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 5)
                {
                    Label6.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 6)
                {
                    Label7.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 7)
                {
                    Label8.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 8)
                {
                    Label9.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 9)
                {
                    Label10.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 10)
                {
                    Label11.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 11)
                {
                    Label12.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 12)
                {
                    Label13.BackColor = Color.FromArgb(176, 180, 43);
                }
            }
            else
            {
                transparentlabels();
            }
        }
        private void transparentlabels()
        {
            Label2.BackColor = Color.FromArgb(255, 160 ,122);
            Label3.BackColor = Color.FromArgb(255, 160 ,122);
            Label4.BackColor = Color.FromArgb(255, 160 ,122);
            Label5.BackColor = Color.FromArgb(255, 160 ,122);
            Label6.BackColor = Color.FromArgb(255, 160 ,122);
            Label7.BackColor = Color.FromArgb(255, 160 ,122);
            Label8.BackColor = Color.FromArgb(255, 160 ,122);
            Label9.BackColor = Color.FromArgb(255, 160 ,122);
            Label10.BackColor = Color.FromArgb(255, 160 ,122);
            Label11.BackColor = Color.FromArgb(255, 160 ,122);
            Label12.BackColor = Color.FromArgb(255, 160 ,122);
            Label13.BackColor = Color.FromArgb(255, 160 ,122);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Year_Load(object sender, EventArgs e)
        {
            if (Conversions.ToDouble(Label1.Text) == DateTime.Today.Year)
            {
                int monthno = DateTime.Today.Month;
                transparentlabels();
                if (monthno == 1)
                {
                    Label2.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 2)
                {
                    Label3.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 3)
                {
                    Label4.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 4)
                {
                    Label5.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 5)
                {
                    Label6.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 6)
                {
                    Label7.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 7)
                {
                    Label8.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 8)
                {
                    Label9.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 9)
                {
                    Label10.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 10)
                {
                    Label11.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 11)
                {
                    Label12.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 12)
                {
                    Label13.BackColor = Color.FromArgb(176, 180, 43);
                }
            }
            else
            {
                transparentlabels();
            }
        }

   
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int userVal = int.Parse(Label1.Text) - 1;
            Label1.Text = userVal.ToString();

            if (Conversions.ToDouble(Label1.Text) == DateTime.Today.Year)
            {
                int monthno = DateTime.Today.Month;
                transparentlabels();
                if (monthno == 1)
                {
                    Label2.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 2)
                {
                    Label3.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 3)
                {
                    Label4.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 4)
                {
                    Label5.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 5)
                {
                    Label6.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 6)
                {
                    Label7.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 7)
                {
                    Label8.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 8)
                {
                    Label9.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 9)
                {
                    Label10.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 10)
                {
                    Label11.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 11)
                {
                    Label12.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 12)
                {
                    Label13.BackColor = Color.FromArgb(176, 180, 43);
                }
            }
            else
            {
                transparentlabels();
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

            int userVal = int.Parse(Label1.Text) + 1;
            Label1.Text = userVal.ToString();

            if (Conversions.ToDouble(Label1.Text) == DateTime.Today.Year)
            {
                int monthno = DateTime.Today.Month;
                transparentlabels();
                if (monthno == 1)
                {
                    Label2.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 2)
                {
                    Label3.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 3)
                {
                    Label4.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 4)
                {
                    Label5.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 5)
                {
                    Label6.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 6)
                {
                    Label7.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 7)
                {
                    Label8.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 8)
                {
                    Label9.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 9)
                {
                    Label10.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 10)
                {
                    Label11.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 11)
                {
                    Label12.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 12)
                {
                    Label13.BackColor = Color.FromArgb(176, 180, 43);
                }
            }
            else
            {
                transparentlabels();
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}

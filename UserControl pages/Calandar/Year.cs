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

            
            if (Conversions.ToDouble(Year_January.Text) == DateTime.Today.Year)
            {
                int monthno = DateTime.Today.Month;
                transparentlabels();
                if (monthno == 1)
                {
                    Year_January.BackColor = Color.FromArgb(176, 180, 43);
                    }
                    else if (monthno == 2)
                    {
                        Year_February.BackColor = Color.FromArgb(176, 180, 43);
                    }
                    else if (monthno == 3)
                    {
                        Year_March.BackColor = Color.FromArgb(176, 180, 43);
                    }
                    else if (monthno == 4)
                {
                    Year_April.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 5)
                {
                    Year_May.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 6)
                {
                    Year_June.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 7)
                {
                    Year_July.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 8)
                {
                    Year_August.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 9)
                {
                    Year_September.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 10)
                {
                    Year_October.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 11)
                {
                    Year_November.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 12)
                {
                    Year_December.BackColor = Color.FromArgb(176, 180, 43);
                }
            }
            else
            {
                transparentlabels();
            }
        }
        private void transparentlabels()
        {
            Year_January.BackColor = Color.FromArgb(255, 160 ,122);
            Year_February.BackColor = Color.FromArgb(255, 160 ,122);
            Year_March.BackColor = Color.FromArgb(255, 160 ,122);
            Year_April.BackColor = Color.FromArgb(255, 160 ,122);
            Year_May.BackColor = Color.FromArgb(255, 160 ,122);
            Year_June.BackColor = Color.FromArgb(255, 160 ,122);
            Year_July.BackColor = Color.FromArgb(255, 160 ,122);
            Year_August.BackColor = Color.FromArgb(255, 160 ,122);
            Year_September.BackColor = Color.FromArgb(255, 160 ,122);
            Year_October.BackColor = Color.FromArgb(255, 160 ,122);
            Year_November.BackColor = Color.FromArgb(255, 160 ,122);
            Year_December.BackColor = Color.FromArgb(255, 160 ,122);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Year_Load(object sender, EventArgs e)
        {
            if (Conversions.ToDouble(Year_Year.Text) == DateTime.Today.Year)
            {
                int monthno = DateTime.Today.Month;
                transparentlabels();
                if (monthno == 1)
                {
                    Year_January.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 2)
                {
                    Year_February.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 3)
                {
                    Year_March.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 4)
                {
                    Year_April.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 5)
                {
                    Year_May.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 6)
                {
                    Year_June.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 7)
                {
                    Year_July.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 8)
                {
                    Year_August.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 9)
                {
                    Year_September.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 10)
                {
                    Year_October.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 11)
                {
                    Year_November.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 12)
                {
                    Year_December.BackColor = Color.FromArgb(176, 180, 43);
                }
            }
            else
            {
                transparentlabels();
            }
        }

   
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int userVal = int.Parse(Year_Year.Text) - 1;
            Year_Year.Text = userVal.ToString();

            if (Conversions.ToDouble(Year_Year.Text) == DateTime.Today.Year)
            {
                int monthno = DateTime.Today.Month;
                transparentlabels();
                if (monthno == 1)
                {
                    Year_January.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 2)
                {
                    Year_February.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 3)
                {
                    Year_March.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 4)
                {
                    Year_April.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 5)
                {
                    Year_May.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 6)
                {
                    Year_June.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 7)
                {
                    Year_July.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 8)
                {
                    Year_August.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 9)
                {
                    Year_September.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 10)
                {
                    Year_October.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 11)
                {
                    Year_November.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 12)
                {
                    Year_December.BackColor = Color.FromArgb(176, 180, 43);
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

            int userVal = int.Parse(Year_Year.Text) + 1;
            Year_Year.Text = userVal.ToString();

            if (Conversions.ToDouble(Year_Year.Text) == DateTime.Today.Year)
            {
                int monthno = DateTime.Today.Month;
                transparentlabels();
                if (monthno == 1)
                {
                    Year_January.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 2)
                {
                    Year_February.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 3)
                {
                    Year_March.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 4)
                {
                    Year_April.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 5)
                {
                    Year_May.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 6)
                {
                    Year_June.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 7)
                {
                    Year_July.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 8)
                {
                    Year_August.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 9)
                {
                    Year_September.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 10)
                {
                    Year_October.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 11)
                {
                    Year_November.BackColor = Color.FromArgb(176, 180, 43);
                }
                else if (monthno == 12)
                {
                    Year_December.BackColor = Color.FromArgb(176, 180, 43);
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

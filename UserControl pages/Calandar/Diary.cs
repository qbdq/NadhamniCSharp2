using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NadhamniCSharp.UserControl_pages.Calandar
{
    public partial class Diary : UserControl
    {
        public static HomeCalander _instance;
        public static HomeCalander Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HomeCalander();
                return _instance;
            }
        }
        public Diary()
        {
            InitializeComponent();
        }

        private void Diary_Load(object sender, EventArgs e)
        {
            DateTime aDate = DateTime.Now;
            LabelDate.Text = aDate.ToString("dddd, dd MMMM yyyy");


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}

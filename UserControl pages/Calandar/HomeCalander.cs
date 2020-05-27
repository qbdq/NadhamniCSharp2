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
    public partial class HomeCalander : UserControl
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
        public HomeCalander()
        {
            InitializeComponent();
        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void HomeCalander_Load(object sender, EventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel7_Click(object sender, EventArgs e)
        {
            
        }
    }
}

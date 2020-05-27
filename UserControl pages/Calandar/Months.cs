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
    public partial class Months : UserControl
    {
        public static Months _instance;
        public static Months Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Months();
                return _instance;
            }
        }
        public Months()
        {
            InitializeComponent();
        }

        private void _Label46_Click(object sender, EventArgs e)
        {

        }
    }
}

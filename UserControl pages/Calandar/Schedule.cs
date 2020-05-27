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
    public partial class Schedule : UserControl
    {
        public static Schedule _instance;
        public static Schedule Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Schedule();
                return _instance;
            }
        }
        public Schedule()
        {
            InitializeComponent();
        }
    }
}

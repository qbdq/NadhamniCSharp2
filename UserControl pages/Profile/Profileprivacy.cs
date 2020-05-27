using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NadhamniCSharp.Login
{
    public partial class Profileprivacy : UserControl
    {
        public static Profileprivacy _instance;
        public static Profileprivacy Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Profileprivacy();
                return _instance;
            }
        }
        public Profileprivacy()
        {
            InitializeComponent();
        }

        private void Profileprivacy_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NadhamniCSharp.UserControl_pages.Profile
{
    public partial class ProfileProfile : UserControl
    {
        public static ProfileProfile _instance;
        public static ProfileProfile Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProfileProfile();
                return _instance;
            }
        }
        public ProfileProfile()
        {
            InitializeComponent();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            ProfileProfile_Next.Show();
            ProfileProfile_Cancer.Show();
        }

        private void ProfileProfile_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;


        }
    }
}

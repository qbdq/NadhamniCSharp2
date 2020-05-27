using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NadhamniCSharp.Login;
using NadhamniCSharp.UserControl_pages.Profile;

namespace NadhamniCSharp
{
    public partial class Profile : UserControl
    {
        public static Profile _instance;
        public static Profile Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Profile();
                return _instance;
            }
        }
        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            if (!ProfilePanel.Controls.Contains(ProfileProfile.Instance))
            {
                ProfilePanel.Controls.Add(ProfileProfile.Instance);
            }
        }





        private void PrivacyLabel_Click_1(object sender, EventArgs e)
        {
            if (!ProfilePanel.Controls.Contains(Profileprivacy.Instance))
            {
                ProfilePanel.Controls.Clear();
                ProfilePanel.Controls.Add(Profileprivacy.Instance);
            }

        }

        private void PrivacyLabel_Click_2(object sender, EventArgs e)
        {
            if (!ProfilePanel.Controls.Contains(Profileprivacy.Instance))
            {
                ProfilePanel.Controls.Clear();
                ProfilePanel.Controls.Add(Profileprivacy.Instance);
            }
        }
 
        private void ProfileLabel_Click(object sender, EventArgs e)
        {
            if (!ProfilePanel.Controls.Contains(Profileprivacy.Instance))
            {
                ProfilePanel.Controls.Clear();
                ProfilePanel.Controls.Add(Profileprivacy.Instance);
            }
        }

        private void ProfilePanel_Paint(object sender, PaintEventArgs e)
        {
      

        }

        private void ProfilePanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void ProfileLabel_Click_1(object sender, EventArgs e)
        {
            if (!ProfilePanel.Controls.Contains(ProfileProfile.Instance))
            {
                ProfilePanel.Controls.Clear();
                ProfilePanel.Controls.Add(ProfileProfile.Instance);
            }
        }
    }
}

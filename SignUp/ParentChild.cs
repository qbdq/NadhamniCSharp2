using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NadhamniCSharp.SignUp
{
    public partial class ParentChild : UserControl
    {
        public ParentChild()
        {
            InitializeComponent();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private SignUpChild f1;
        private SignUpParent f2;
        private void AddChild_Click(object sender, EventArgs e)
        {
            SignUpChild f1 = new SignUpChild();
            f1.Show();

        }

        private void AddParent_Click(object sender, EventArgs e)
        {
            SignUpParent f2 = new SignUpParent();
            f2.Show();
        }
    }
}

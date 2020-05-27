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
    public partial class ImageEventPicker : UserControl
    {
        public static ImageEventPicker _instance;
        public static ImageEventPicker Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ImageEventPicker();
                return _instance;
            }
        }
        public ImageEventPicker()
        {
            InitializeComponent();
        }
    }
}

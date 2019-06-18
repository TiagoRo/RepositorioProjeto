using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Info_User : UserControl
    {
        private static Info_User _instance;

        public static Info_User Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Info_User();
                return _instance;
            }
        }
        public Info_User()
        {
            InitializeComponent();
        }
    }
}

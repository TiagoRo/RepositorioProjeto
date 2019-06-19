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

        private void pic_back_Click(object sender, EventArgs e)
        {
            this.Hide();

            Destaques.Instance.pnl_receive.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(lbl_user.Text == "Username")
            {
                lbl_user.Text = ""+form_entrada.Instance.userinfo;
            }

            if (lbl_pass.Text == "Pass")
            {
                lbl_pass.Text = "" + form_entrada.Instance.passinfo;
            }

            if (lbl_email.Text == "Email")
            {
                lbl_email.Text = "" + form_entrada.Instance.emailinfo;
            }

            if (lbl_telemovel.Text == "Telemóvel")
            {
                lbl_telemovel.Text = "" + form_entrada.Instance.telemovelinfo;
            }

            if (lbl_sexo.Text == "Sexo")
            {
                lbl_sexo.Text = "" + form_entrada.Instance.sexoinfo;
            }
        }
    }
}

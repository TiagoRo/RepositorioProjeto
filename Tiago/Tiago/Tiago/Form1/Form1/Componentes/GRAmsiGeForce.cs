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
    public partial class GRAmsiGeForce : UserControl
    {
        public GRAmsiGeForce()
        {
            InitializeComponent();
        }

        private static GRAmsiGeForce _instance;

        public static GRAmsiGeForce Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GRAmsiGeForce();
                return _instance;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Destaques.Instance.pnl_receive.Show();
        }

        private void btn_Comprar_Click(object sender, EventArgs e)
        {
            int id = Utils.readIdComponente("GRAmsiGeForce");

            if(id < 0)
            {
                Console.WriteLine("Erro ao ler o ID!");
            }
            else
            {
                if (Utils.ComprarComponente(id))
                {
                    Console.WriteLine("Componente comprado!");
                }
            }
        }
    }
}

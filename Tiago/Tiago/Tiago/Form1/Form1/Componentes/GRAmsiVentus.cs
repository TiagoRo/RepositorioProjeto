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
    public partial class GRAmsiVentus : UserControl
    {
        public GRAmsiVentus()
        {
            InitializeComponent();
        }

        private static GRAmsiVentus _instance;

        public static GRAmsiVentus Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GRAmsiVentus();
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
            int id = Utils.readIdComponente("GRAmsiVentus");

            if (id < 0)
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

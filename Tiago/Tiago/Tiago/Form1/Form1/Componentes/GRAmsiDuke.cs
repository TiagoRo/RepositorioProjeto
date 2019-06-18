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
    public partial class GRAmsiDuke : UserControl
    {
        public GRAmsiDuke()
        {
            InitializeComponent();
        }

        private static GRAmsiDuke _instance;

        public static GRAmsiDuke Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GRAmsiDuke();
                return _instance;
            }
        }

        private void pic_back_Click(object sender, EventArgs e)
        {
                Destaques.Instance.pnl_receive.Show();
        }

        private void btn_Comprar_Click(object sender, EventArgs e)
        {
            int id = Utils.readIdComponente("GRAmsiDuke");

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

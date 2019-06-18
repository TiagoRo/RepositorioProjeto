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
    public partial class FACorsairTX550M : UserControl
    {
        public FACorsairTX550M()
        {
            InitializeComponent();
        }

        private static FACorsairTX550M _instance;

        public static FACorsairTX550M Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FACorsairTX550M();
                return _instance;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Destaques.Instance.pnl_receive.Show();
        }

        private void btn_Comprar_Click(object sender, EventArgs e)
        {
            int id = Utils.readIdComponente("FACorsairTX550M");

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

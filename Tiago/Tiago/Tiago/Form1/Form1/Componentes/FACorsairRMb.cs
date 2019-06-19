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
    public partial class FACorsair850x : UserControl
    {
        public FACorsair850x()
        {
            InitializeComponent();
        }

        private static FACorsair850x _instance;

        public static FACorsair850x Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FACorsair850x();
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
            int id = Utils.readIdComponente("FACorsair850x");

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

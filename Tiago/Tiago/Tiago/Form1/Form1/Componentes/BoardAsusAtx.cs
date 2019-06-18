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
    public partial class BoardAsusAtx : UserControl
    {
        public BoardAsusAtx()
        {
            InitializeComponent();
        }

        private static BoardAsusAtx _instance;

        public static BoardAsusAtx Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BoardAsusAtx();
                return _instance;
            }
        }

        private void btn_Comprar_Click(object sender, EventArgs e)
        {
            int id = Utils.readIdComponente("BoardAsusAtx");

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Destaques.Instance.pnl_receive.Show();
        }
    }
}

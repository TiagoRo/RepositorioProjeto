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
    public partial class CPUintel_i5 : UserControl
    {
        public CPUintel_i5()
        {
            InitializeComponent();
        }

        private static CPUintel_i5 _instance;

        public static CPUintel_i5 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CPUintel_i5();
                return _instance;
            }
        }

        private void btn_Comprar_Click(object sender, EventArgs e)
        {
            int id = Utils.readIdComponente("CPUintel_i5");

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
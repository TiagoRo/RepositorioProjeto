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
    public partial class FACorsairAX1000 : UserControl
    {
        public FACorsairAX1000()
        {
            InitializeComponent();
        }

        private static FACorsairAX1000 _instance;

        public static FACorsairAX1000 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FACorsairAX1000();
                return _instance;
            }
        }

        private void Btn_Comprar_Click(object sender, EventArgs e)
        {
            int id = Utils.readIdComponente("FACorsairAX1000");

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

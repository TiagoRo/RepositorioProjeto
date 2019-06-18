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
    public partial class Destaques : UserControl
    {
        public Destaques()
        {
            InitializeComponent();
        }

        private static Destaques _instance;

        public static Destaques Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Destaques();
                return _instance;
            }
        }

        private void lbl_msi_geForce_Click(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(GRAmsiGeForce.Instance))
            {
                this.pnl_receive.Hide();
                
                this.Controls.Add(GRAmsiGeForce.Instance);
                GRAmsiGeForce.Instance.Dock = DockStyle.Fill;
                GRAmsiGeForce.Instance.BringToFront();
                Console.WriteLine("Novo form aberto");
            }
            else
            {
                GRAmsiGeForce.Instance.Show();
                GRAmsiGeForce.Instance.BringToFront();
                Console.WriteLine("Form reaberto");
            }
        }

        private void lbl_proc_in_i5_Click(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(CPUintel_i5.Instance))
            {
                this.pnl_receive.Hide();

                this.Controls.Add(CPUintel_i5.Instance);
                CPUintel_i5.Instance.Dock = DockStyle.Fill;
                CPUintel_i5.Instance.BringToFront();
                Console.WriteLine("Novo form aberto");
            }
            else
            {
                CPUintel_i5.Instance.Show();
                CPUintel_i5.Instance.BringToFront();
                Console.WriteLine("Form reaberto");
            }
        }

        private void lbl_msi_armor_Click(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(GRAmsiArmor.Instance))
            {
                this.pnl_receive.Hide();

                this.Controls.Add(GRAmsiArmor.Instance);
                GRAmsiArmor.Instance.Dock = DockStyle.Fill;
                GRAmsiArmor.Instance.BringToFront();
                Console.WriteLine("Novo form aberto");
            }
            else
            {
                GRAmsiArmor.Instance.Show();
                GRAmsiArmor.Instance.BringToFront();
                Console.WriteLine("Form reaberto");
            }
        }

        private void lbl_Fon_Corsair_Click(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(FACorsair850x.Instance))
            {
                this.pnl_receive.Hide();

                this.Controls.Add(FACorsair850x.Instance);
                FACorsair850x.Instance.Dock = DockStyle.Fill;
                FACorsair850x.Instance.BringToFront();
                Console.WriteLine("Novo form aberto");
            }
            else
            {
                FACorsair850x.Instance.Show();
                FACorsair850x.Instance.BringToFront();
                Console.WriteLine("Form reaberto");
            }
        }

        private void lbl_Board_Asus_Click(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(BoardAsusAtx.Instance))
            {
                this.pnl_receive.Hide();

                this.Controls.Add(BoardAsusAtx.Instance);
                BoardAsusAtx.Instance.Dock = DockStyle.Fill;
                BoardAsusAtx.Instance.BringToFront();
                Console.WriteLine("Novo form aberto");
            }
            else
            {
                BoardAsusAtx.Instance.Show();
                BoardAsusAtx.Instance.BringToFront();
                Console.WriteLine("Form reaberto");
            }
        }

        private void lbl_CPU_intel_i7_Click(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(CPUintel_i7.Instance))
            {
                this.pnl_receive.Hide();

                this.Controls.Add(CPUintel_i7.Instance);
                CPUintel_i7.Instance.Dock = DockStyle.Fill;
                CPUintel_i7.Instance.BringToFront();
                Console.WriteLine("Novo form aberto");
            }
            else
            {
                CPUintel_i7.Instance.Show();
                CPUintel_i7.Instance.BringToFront();
                Console.WriteLine("Form reaberto");
            }
        }
    }
}

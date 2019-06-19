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
    public partial class userControlGraficas : UserControl
    {
        public userControlGraficas()
        {
            InitializeComponent();
        }

        private static userControlGraficas _instance;

        public static userControlGraficas Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new userControlGraficas();
                return _instance;
            }
        }
        
        private void lbl_GRAmsiArmor_Click(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(GRAmsiArmor.Instance))
            {

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

        private void lbl_graGeForce_Click(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(GRAmsiGeForce.Instance))
            {

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

        private void lbl_GRAmsiVentus_Click(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(GRAmsiVentus.Instance))
            {

                this.Controls.Add(GRAmsiVentus.Instance);
                GRAmsiVentus.Instance.Dock = DockStyle.Fill;
                GRAmsiVentus.Instance.BringToFront();
                Console.WriteLine("Novo form aberto");
            }
            else
            {
                GRAmsiVentus.Instance.Show();
                GRAmsiVentus.Instance.BringToFront();
                Console.WriteLine("Form reaberto");
            }
        }

        private void lbl_GRAmsiDuke_Click(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(GRAmsiDuke.Instance))
            {

                this.Controls.Add(GRAmsiDuke.Instance);
                GRAmsiDuke.Instance.Dock = DockStyle.Fill;
                GRAmsiDuke.Instance.BringToFront();
                Console.WriteLine("Novo form aberto");
            }
            else
            {
                GRAmsiDuke.Instance.Show();
                GRAmsiDuke.Instance.BringToFront();
                Console.WriteLine("Form reaberto");
            }
        }
    }
}

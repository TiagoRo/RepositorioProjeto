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
    public partial class userControlFonteA : UserControl
    {
        public userControlFonteA()
        {
            InitializeComponent();
        }

        private static userControlFonteA _instance;

        public static userControlFonteA Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new userControlFonteA();
                return _instance;
            }
        }

        private void lbl_FACorsairTX_Click(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(FACorsairTX550M.Instance))
            {

                this.Controls.Add(FACorsairTX550M.Instance);
                FACorsairTX550M.Instance.Dock = DockStyle.Fill;
                FACorsairTX550M.Instance.BringToFront();
                Console.WriteLine("Novo form aberto");
            }
            else
            {
                FACorsairTX550M.Instance.Show();
                FACorsairTX550M.Instance.BringToFront();
                Console.WriteLine("Form reaberto");
            }
        }

        private void lbl_FACorsairRMb_Click(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(FACorsair850x.Instance))
            {

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

        private void lbl_FACorsairRMw_Click(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(FACorsairRM850x.Instance))
            {

                this.Controls.Add(FACorsairRM850x.Instance);
                FACorsairRM850x.Instance.Dock = DockStyle.Fill;
                FACorsairRM850x.Instance.BringToFront();
                Console.WriteLine("Novo form aberto");
            }
            else
            {
                FACorsairRM850x.Instance.Show();
                FACorsairRM850x.Instance.BringToFront();
                Console.WriteLine("Form reaberto");
            }
        }

        private void FACorsairRMw_Click(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(FACorsairAX1000.Instance))
            {

                this.Controls.Add(FACorsairAX1000.Instance);
                FACorsairAX1000.Instance.Dock = DockStyle.Fill;
                FACorsairAX1000.Instance.BringToFront();
                Console.WriteLine("Novo form aberto");
            }
            else
            {
                FACorsairAX1000.Instance.Show();
                FACorsairAX1000.Instance.BringToFront();
                Console.WriteLine("Form reaberto");
            }
        }
    }
}

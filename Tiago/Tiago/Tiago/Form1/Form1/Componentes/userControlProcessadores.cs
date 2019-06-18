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
    public partial class userControlProcessadores : UserControl
    {
        public userControlProcessadores()
        {
            InitializeComponent();
        }

        private static userControlProcessadores _instance;

        public static userControlProcessadores Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new userControlProcessadores();
                return _instance;
            }
        }

        private void lbl_CPUintel_i3_MouseHover(object sender, EventArgs e)
        {
            if (lbl_CPUintel_i3.ForeColor == Color.Black)
            {
                lbl_CPUintel_i3.ForeColor = Color.Orange;
            }
        }

        private void lbl_CPUintel_i3_MouseLeave(object sender, EventArgs e)
        {
            if (lbl_CPUintel_i3.ForeColor == Color.Orange)
            {
                lbl_CPUintel_i3.ForeColor = Color.Black;
            }
        }

        private void lbl_proc_in_i5_MouseHover(object sender, EventArgs e)
        {
            if (lbl_proc_in_i5.ForeColor == Color.Black)
            {
                lbl_proc_in_i5.ForeColor = Color.Orange;
            }
        }

        private void lbl_proc_in_i5_MouseLeave(object sender, EventArgs e)
        {
            if (lbl_proc_in_i5.ForeColor == Color.Orange)
            {
                lbl_proc_in_i5.ForeColor = Color.Black;
            }
        }

        private void lbl_CPUintel_i7_MouseHover(object sender, EventArgs e)
        {
            if (lbl_CPUintel_i7.ForeColor == Color.Black)
            {
                lbl_CPUintel_i7.ForeColor = Color.Orange;
            }
        }

        private void lbl_CPUintel_i7_MouseLeave(object sender, EventArgs e)
        {
            if (lbl_CPUintel_i7.ForeColor == Color.Orange)
            {
                lbl_CPUintel_i7.ForeColor = Color.Black;
            }
        }

        private void lbl_CPUintel_i9_MouseHover(object sender, EventArgs e)
        {
            if (lbl_CPUintel_i9.ForeColor == Color.Black)
            {
                lbl_CPUintel_i9.ForeColor = Color.Orange;
            }
        }

        private void lbl_CPUintel_i9_MouseLeave(object sender, EventArgs e)
        {
            if (lbl_CPUintel_i9.ForeColor == Color.Orange)
            {
                lbl_CPUintel_i9.ForeColor = Color.Black;
            }
        }

        private void lbl_CPUintel_i3_Click(object sender, EventArgs e)
        {
            if (!this.pnl_receive.Controls.Contains(CPUintel_i3.Instance))
            {

                this.pnl_receive.Controls.Add(CPUintel_i3.Instance);
                CPUintel_i3.Instance.Dock = DockStyle.Fill;
                CPUintel_i3.Instance.BringToFront();
                Console.WriteLine("Novo form aberto");
            }
            else
            {
                CPUintel_i3.Instance.Show();
                CPUintel_i3.Instance.BringToFront();
                Console.WriteLine("Form reaberto");
            }
        }

        private void Lbl_proc_in_i5_Click(object sender, EventArgs e)
        {
            if (!this.pnl_receive.Controls.Contains(CPUintel_i5.Instance))
            {

                this.pnl_receive.Controls.Add(CPUintel_i5.Instance);
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

        private void Lbl_CPUintel_i7_Click(object sender, EventArgs e)
        {
            if (!this.pnl_receive.Controls.Contains(CPUintel_i7.Instance))
            {

                this.pnl_receive.Controls.Add(CPUintel_i7.Instance);
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

        private void Lbl_CPUintel_i9_Click(object sender, EventArgs e)
        {
            if (!this.pnl_receive.Controls.Contains(CPUintel_i9.Instance))
            {

                this.pnl_receive.Controls.Add(CPUintel_i9.Instance);
                CPUintel_i9.Instance.Dock = DockStyle.Fill;
                CPUintel_i9.Instance.BringToFront();
                Console.WriteLine("Novo form aberto");
            }
            else
            {
                CPUintel_i9.Instance.Show();
                CPUintel_i9.Instance.BringToFront();
                Console.WriteLine("Form reaberto");
            }
        }
    }
}

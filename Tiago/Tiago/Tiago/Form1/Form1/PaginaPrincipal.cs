using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Form1
{
    public partial class PaginaPrincipal : Form
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
        }
        //
        //Minimizar pagina
        //
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void up_panel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_componentes_MouseHover(object sender, EventArgs e)
        {
            panelDropDown.Size = panelDropDown.MaximumSize;
            pnl_menu.Size = panelDropDown.MaximumSize;
        }

        private void panelDropDown_MouseLeave(object sender, EventArgs e)
        {
            panelDropDown.Size = panelDropDown.MinimumSize;
            pnl_menu.Size = panelDropDown.MinimumSize;
        }

        private void btn_imagem_MouseHover(object sender, EventArgs e)
        {
            panel_drop_imagens.Size = panel_drop_imagens.MaximumSize;
            pnl_menu.Size = panelDropDown.MaximumSize;
        }

        private void panel_drop_imagens_MouseLeave(object sender, EventArgs e)
        {
            panel_drop_imagens.Size = panel_drop_imagens.MinimumSize;
            pnl_menu.Size = panelDropDown.MinimumSize;
        }
        //
        private void btn_exitt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Ver_Conta_Click(object sender, EventArgs e)
        {
            if (!pnl_receive_home.Controls.Contains(Info_User.Instance))
            {
                pnl_receive_home.Controls.Add(Info_User.Instance);
                Info_User.Instance.Dock = DockStyle.Fill;
                Info_User.Instance.BringToFront();
                Console.WriteLine("Novo form aberto");
            }
            else
            {
                Info_User.Instance.Show();
                Info_User.Instance.BringToFront();
                Console.WriteLine("Form reaberto");
            }
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_processadores_Click(object sender, EventArgs e)
        {
            if (!pnl_receive_home.Controls.Contains(userControlProcessadores.Instance))
            {

                pnl_receive_home.Controls.Add(userControlProcessadores.Instance);
                userControlProcessadores.Instance.Dock = DockStyle.Fill;
                userControlProcessadores.Instance.BringToFront();
                Console.WriteLine("Novo form aberto");
            }
            else
            {
                userControlProcessadores.Instance.Show();
                userControlProcessadores.Instance.BringToFront();
                Console.WriteLine("Form reaberto");
            }
        }

        private void btn_Graficas_Click(object sender, EventArgs e)
        {
            if (!this.pnl_receive_home.Controls.Contains(userControlGraficas.Instance))
            {
                this.pnl_receive_home.Controls.Add(userControlGraficas.Instance);
                userControlGraficas.Instance.Dock = DockStyle.Fill;
                userControlGraficas.Instance.BringToFront();
                Console.WriteLine("Novo form aberto");
            }
            else
            {
                userControlGraficas.Instance.Show();
                userControlGraficas.Instance.BringToFront();
                Console.WriteLine("Form reaberto");
            }
        }

        private void Lbl_PlacaGraf_MSI_Click(object sender, EventArgs e)
        {
            if (!this.pnl_receive_home.Controls.Contains(GRAmsiGeForce.Instance))
            {

                this.pnl_receive_home.Controls.Add(GRAmsiGeForce.Instance);
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

        private void Lbl_proc_in_i5_Click(object sender, EventArgs e)
        {
            if (!this.pnl_receive_home.Controls.Contains(CPUintel_i5.Instance))
            {

                this.pnl_receive_home.Controls.Add(CPUintel_i5.Instance);
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

        private void Lbl_msi_armor_Click(object sender, EventArgs e)
        {
            if (!this.pnl_receive_home.Controls.Contains(GRAmsiArmor.Instance))
            {

                this.pnl_receive_home.Controls.Add(GRAmsiArmor.Instance);
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

        private void Lbl_FaCorsairRM_Click(object sender, EventArgs e)
        {
            if (!this.pnl_receive_home.Controls.Contains(FACorsair850x.Instance))
            {

                this.pnl_receive_home.Controls.Add(FACorsair850x.Instance);
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

        private void Lbl_BoardAsus_Click(object sender, EventArgs e)
        {
            if (!this.pnl_receive_home.Controls.Contains(BoardAsusAtx.Instance))
            {

                this.pnl_receive_home.Controls.Add(BoardAsusAtx.Instance);
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

        private void Lbl_CPU_i7_Click(object sender, EventArgs e)
        {
            if (!this.pnl_receive_home.Controls.Contains(CPUintel_i7.Instance))
            {

                this.pnl_receive_home.Controls.Add(CPUintel_i7.Instance);
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

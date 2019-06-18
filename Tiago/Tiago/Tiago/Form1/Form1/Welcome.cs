using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;

namespace Form1
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        
        private void Comecar()
        {
            if (!panel_receive.Controls.Contains(BoardAsusAtx.Instance))
            {
                panel_receive.Controls.Add(BoardAsusAtx.Instance);
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
        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar a aplicação ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //codigo para fazer mover o form
        private void Pnl_btnTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Btn_menu_slide_Click(object sender, EventArgs e)
        {
            if (pnl_menu.Width == 250)
            {
                pnl_menu.Width = 40;
            }
            else
            {
                pnl_menu.Width = 250;
            }
        }

        //Abrir o userControl do login
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if (!panel_receive.Controls.Contains(form_entrada.Instance))
            {
                panel_receive.Controls.Add(form_entrada.Instance);
                form_entrada.Instance.Dock = DockStyle.Fill;
                form_entrada.Instance.BringToFront();
                Console.WriteLine("Novo form aberto");
            }
            else
            {
                form_entrada.Instance.Show();
                form_entrada.Instance.BringToFront();
                Console.WriteLine("Form reaberto");
            }
        }
        //Abrir o userControl do registo
        private void Btn_registar_Click(object sender, EventArgs e)
        {
            if (!panel_receive.Controls.Contains(Registar.Instance))
            {
                panel_receive.Controls.Add(Registar.Instance);
                Registar.Instance.Dock = DockStyle.Fill;
                Registar.Instance.BringToFront();
                Console.WriteLine("Novo form aberto");
            }
            else
            {
                Registar.Instance.Show();
                Registar.Instance.BringToFront();
                Console.WriteLine("Form reaberto");
            }
        }

        private void btn_Comecar_Click(object sender, EventArgs e)
        {
            this.btn_Comecar.Visible = false;
            this.lbl_comecar.Visible = false;
            if (!panel_receive.Controls.Contains(Destaques.Instance))
            {
                panel_receive.Controls.Add(Destaques.Instance);
                Destaques.Instance.Dock = DockStyle.Fill;
                Destaques.Instance.BringToFront();
                Console.WriteLine("Novo form aberto");
            }
            else
            {
                Destaques.Instance.Show();
                Destaques.Instance.BringToFront();
                Console.WriteLine("Form reaberto");
            }
        }

        private void lbl_comecar_Click(object sender, EventArgs e)
        {

        }
    }
}

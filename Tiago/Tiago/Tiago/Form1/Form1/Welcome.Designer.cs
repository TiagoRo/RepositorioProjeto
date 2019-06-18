namespace Form1
{
    partial class Welcome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.btn_registar = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.pnl_btnTop = new System.Windows.Forms.Panel();
            this.btn_menu_slide = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_proc_in_i5 = new System.Windows.Forms.Label();
            this.lbl_msi_geForce = new System.Windows.Forms.Label();
            this.lbl_msi_armor = new System.Windows.Forms.Label();
            this.lbl_Fon_Corsair = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_Board_Asus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel_receive = new System.Windows.Forms.Panel();
            this.lbl_comecar = new System.Windows.Forms.Label();
            this.btn_Comecar = new System.Windows.Forms.Button();
            this.pnl_menu.SuspendLayout();
            this.pnl_btnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu_slide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            this.panel_receive.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.pnl_menu.Controls.Add(this.btn_registar);
            this.pnl_menu.Controls.Add(this.btn_Login);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(250, 700);
            this.pnl_menu.TabIndex = 78;
            // 
            // btn_registar
            // 
            this.btn_registar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.btn_registar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registar.Image = ((System.Drawing.Image)(resources.GetObject("btn_registar.Image")));
            this.btn_registar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_registar.Location = new System.Drawing.Point(0, 131);
            this.btn_registar.Name = "btn_registar";
            this.btn_registar.Size = new System.Drawing.Size(251, 40);
            this.btn_registar.TabIndex = 1;
            this.btn_registar.Text = "Registar";
            this.btn_registar.UseVisualStyleBackColor = true;
            this.btn_registar.Click += new System.EventHandler(this.Btn_registar_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Image = ((System.Drawing.Image)(resources.GetObject("btn_Login.Image")));
            this.btn_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Login.Location = new System.Drawing.Point(0, 95);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Login.Size = new System.Drawing.Size(251, 40);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Entrar";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // pnl_btnTop
            // 
            this.pnl_btnTop.Controls.Add(this.btn_menu_slide);
            this.pnl_btnTop.Controls.Add(this.pictureBox1);
            this.pnl_btnTop.Controls.Add(this.minimizar);
            this.pnl_btnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_btnTop.Location = new System.Drawing.Point(250, 0);
            this.pnl_btnTop.Name = "pnl_btnTop";
            this.pnl_btnTop.Size = new System.Drawing.Size(950, 70);
            this.pnl_btnTop.TabIndex = 79;
            this.pnl_btnTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pnl_btnTop_MouseDown);
            // 
            // btn_menu_slide
            // 
            this.btn_menu_slide.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu_slide.Image")));
            this.btn_menu_slide.Location = new System.Drawing.Point(6, 8);
            this.btn_menu_slide.Name = "btn_menu_slide";
            this.btn_menu_slide.Size = new System.Drawing.Size(38, 35);
            this.btn_menu_slide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_menu_slide.TabIndex = 72;
            this.btn_menu_slide.TabStop = false;
            this.btn_menu_slide.Click += new System.EventHandler(this.Btn_menu_slide_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(912, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.exit_Click);
            // 
            // minimizar
            // 
            this.minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizar.Image = ((System.Drawing.Image)(resources.GetObject("minimizar.Image")));
            this.minimizar.Location = new System.Drawing.Point(871, 8);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(35, 35);
            this.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizar.TabIndex = 70;
            this.minimizar.TabStop = false;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 31;
            // 
            // lbl_proc_in_i5
            // 
            this.lbl_proc_in_i5.Location = new System.Drawing.Point(0, 0);
            this.lbl_proc_in_i5.Name = "lbl_proc_in_i5";
            this.lbl_proc_in_i5.Size = new System.Drawing.Size(100, 23);
            this.lbl_proc_in_i5.TabIndex = 30;
            // 
            // lbl_msi_geForce
            // 
            this.lbl_msi_geForce.Location = new System.Drawing.Point(0, 0);
            this.lbl_msi_geForce.Name = "lbl_msi_geForce";
            this.lbl_msi_geForce.Size = new System.Drawing.Size(100, 23);
            this.lbl_msi_geForce.TabIndex = 29;
            // 
            // lbl_msi_armor
            // 
            this.lbl_msi_armor.Location = new System.Drawing.Point(0, 0);
            this.lbl_msi_armor.Name = "lbl_msi_armor";
            this.lbl_msi_armor.Size = new System.Drawing.Size(100, 23);
            this.lbl_msi_armor.TabIndex = 28;
            // 
            // lbl_Fon_Corsair
            // 
            this.lbl_Fon_Corsair.Location = new System.Drawing.Point(0, 0);
            this.lbl_Fon_Corsair.Name = "lbl_Fon_Corsair";
            this.lbl_Fon_Corsair.Size = new System.Drawing.Size(100, 23);
            this.lbl_Fon_Corsair.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 23);
            this.label15.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 23;
            // 
            // lbl_Board_Asus
            // 
            this.lbl_Board_Asus.Location = new System.Drawing.Point(0, 0);
            this.lbl_Board_Asus.Name = "lbl_Board_Asus";
            this.lbl_Board_Asus.Size = new System.Drawing.Size(100, 23);
            this.lbl_Board_Asus.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 19;
            // 
            // panel_receive
            // 
            this.panel_receive.Controls.Add(this.lbl_comecar);
            this.panel_receive.Controls.Add(this.btn_Comecar);
            this.panel_receive.Controls.Add(this.label8);
            this.panel_receive.Controls.Add(this.label9);
            this.panel_receive.Controls.Add(this.label5);
            this.panel_receive.Controls.Add(this.lbl_Board_Asus);
            this.panel_receive.Controls.Add(this.label7);
            this.panel_receive.Controls.Add(this.label4);
            this.panel_receive.Controls.Add(this.label2);
            this.panel_receive.Controls.Add(this.label15);
            this.panel_receive.Controls.Add(this.lbl_Fon_Corsair);
            this.panel_receive.Controls.Add(this.lbl_msi_armor);
            this.panel_receive.Controls.Add(this.lbl_msi_geForce);
            this.panel_receive.Controls.Add(this.lbl_proc_in_i5);
            this.panel_receive.Controls.Add(this.label3);
            this.panel_receive.Location = new System.Drawing.Point(250, 70);
            this.panel_receive.Name = "panel_receive";
            this.panel_receive.Size = new System.Drawing.Size(950, 630);
            this.panel_receive.TabIndex = 77;
            // 
            // lbl_comecar
            // 
            this.lbl_comecar.AutoSize = true;
            this.lbl_comecar.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_comecar.Location = new System.Drawing.Point(146, 153);
            this.lbl_comecar.Name = "lbl_comecar";
            this.lbl_comecar.Size = new System.Drawing.Size(521, 33);
            this.lbl_comecar.TabIndex = 18;
            this.lbl_comecar.Text = "Bem vindo/a á sua loja de Informática";
            this.lbl_comecar.Click += new System.EventHandler(this.lbl_comecar_Click);
            // 
            // btn_Comecar
            // 
            this.btn_Comecar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Comecar.Location = new System.Drawing.Point(344, 274);
            this.btn_Comecar.Name = "btn_Comecar";
            this.btn_Comecar.Size = new System.Drawing.Size(110, 46);
            this.btn_Comecar.TabIndex = 17;
            this.btn_Comecar.Text = "Comecar";
            this.btn_Comecar.UseVisualStyleBackColor = true;
            this.btn_Comecar.Click += new System.EventHandler(this.btn_Comecar_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.pnl_btnTop);
            this.Controls.Add(this.pnl_menu);
            this.Controls.Add(this.panel_receive);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.pnl_menu.ResumeLayout(false);
            this.pnl_btnTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu_slide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            this.panel_receive.ResumeLayout(false);
            this.panel_receive.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_registar;
        private System.Windows.Forms.PictureBox btn_menu_slide;
        private System.Windows.Forms.Panel pnl_btnTop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_proc_in_i5;
        private System.Windows.Forms.Label lbl_msi_geForce;
        private System.Windows.Forms.Label lbl_msi_armor;
        private System.Windows.Forms.Label lbl_Fon_Corsair;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_Board_Asus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Panel panel_receive;
        private System.Windows.Forms.Label lbl_comecar;
        private System.Windows.Forms.Button btn_Comecar;
    }
}
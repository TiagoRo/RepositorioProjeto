namespace Form1
{
    partial class Registar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registar));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_registar = new System.Windows.Forms.Button();
            this.txtBox_password = new System.Windows.Forms.TextBox();
            this.txtBox_email = new System.Windows.Forms.TextBox();
            this.txtBox_telemovel = new System.Windows.Forms.TextBox();
            this.lbl_sexo = new System.Windows.Forms.Label();
            this.txtBox_username = new System.Windows.Forms.TextBox();
            this.radioBtn_Masculino = new System.Windows.Forms.RadioButton();
            this.radioBtn_Femenino = new System.Windows.Forms.RadioButton();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.tl_username = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.pic_back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_back)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(362, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 21);
            this.label2.TabIndex = 71;
            this.label2.Text = "Registe se na PCStore";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 62);
            this.label1.TabIndex = 70;
            this.label1.Text = "Logotipo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_registar
            // 
            this.btn_registar.BackColor = System.Drawing.Color.DarkGray;
            this.btn_registar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_registar.Location = new System.Drawing.Point(379, 478);
            this.btn_registar.Name = "btn_registar";
            this.btn_registar.Size = new System.Drawing.Size(87, 34);
            this.btn_registar.TabIndex = 73;
            this.btn_registar.Text = "Registar";
            this.btn_registar.UseVisualStyleBackColor = false;
            this.btn_registar.Click += new System.EventHandler(this.btn_registar_Click);
            // 
            // txtBox_password
            // 
            this.txtBox_password.BackColor = System.Drawing.SystemColors.Control;
            this.txtBox_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_password.Location = new System.Drawing.Point(278, 304);
            this.txtBox_password.Name = "txtBox_password";
            this.txtBox_password.Size = new System.Drawing.Size(325, 15);
            this.txtBox_password.TabIndex = 75;
            this.txtBox_password.Text = "Palavra-passe";
            this.txtBox_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_password.TextChanged += new System.EventHandler(this.txtBox_password_TextChanged);
            this.txtBox_password.Enter += new System.EventHandler(this.txtBox_password_Enter);
            this.txtBox_password.Leave += new System.EventHandler(this.txtBox_password_Leave);
            // 
            // txtBox_email
            // 
            this.txtBox_email.BackColor = System.Drawing.SystemColors.Control;
            this.txtBox_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_email.Location = new System.Drawing.Point(278, 342);
            this.txtBox_email.Name = "txtBox_email";
            this.txtBox_email.Size = new System.Drawing.Size(325, 15);
            this.txtBox_email.TabIndex = 76;
            this.txtBox_email.Text = "Email";
            this.txtBox_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_email.TextChanged += new System.EventHandler(this.txtBox_email_TextChanged);
            this.txtBox_email.Enter += new System.EventHandler(this.txtBox_email_Enter);
            this.txtBox_email.Leave += new System.EventHandler(this.txtBox_email_Leave);
            // 
            // txtBox_telemovel
            // 
            this.txtBox_telemovel.BackColor = System.Drawing.SystemColors.Control;
            this.txtBox_telemovel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_telemovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_telemovel.Location = new System.Drawing.Point(281, 385);
            this.txtBox_telemovel.Name = "txtBox_telemovel";
            this.txtBox_telemovel.Size = new System.Drawing.Size(325, 15);
            this.txtBox_telemovel.TabIndex = 77;
            this.txtBox_telemovel.Text = "Nº Telemovel";
            this.txtBox_telemovel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_telemovel.TextChanged += new System.EventHandler(this.txtBox_telemovel_TextChanged);
            this.txtBox_telemovel.Enter += new System.EventHandler(this.txtBox_telemovel_Enter);
            this.txtBox_telemovel.Leave += new System.EventHandler(this.txtBox_telemovel_Leave);
            // 
            // lbl_sexo
            // 
            this.lbl_sexo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sexo.Location = new System.Drawing.Point(275, 417);
            this.lbl_sexo.Name = "lbl_sexo";
            this.lbl_sexo.Size = new System.Drawing.Size(72, 29);
            this.lbl_sexo.TabIndex = 79;
            this.lbl_sexo.Text = "Sexo:";
            this.lbl_sexo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBox_username
            // 
            this.txtBox_username.BackColor = System.Drawing.SystemColors.Control;
            this.txtBox_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_username.Location = new System.Drawing.Point(280, 260);
            this.txtBox_username.Name = "txtBox_username";
            this.txtBox_username.Size = new System.Drawing.Size(325, 15);
            this.txtBox_username.TabIndex = 80;
            this.txtBox_username.Text = "Nome de Utilizador";
            this.txtBox_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_username.TextChanged += new System.EventHandler(this.txtBox_username_TextChanged);
            this.txtBox_username.Enter += new System.EventHandler(this.txtBox_username_Enter);
            this.txtBox_username.Leave += new System.EventHandler(this.txtBox_username_Leave);
            // 
            // radioBtn_Masculino
            // 
            this.radioBtn_Masculino.AutoSize = true;
            this.radioBtn_Masculino.Location = new System.Drawing.Point(353, 422);
            this.radioBtn_Masculino.Name = "radioBtn_Masculino";
            this.radioBtn_Masculino.Size = new System.Drawing.Size(73, 17);
            this.radioBtn_Masculino.TabIndex = 81;
            this.radioBtn_Masculino.TabStop = true;
            this.radioBtn_Masculino.Text = "Masculino";
            this.radioBtn_Masculino.UseVisualStyleBackColor = true;
            this.radioBtn_Masculino.CheckedChanged += new System.EventHandler(this.radioBtn_Masculino_CheckedChanged);
            // 
            // radioBtn_Femenino
            // 
            this.radioBtn_Femenino.AutoSize = true;
            this.radioBtn_Femenino.Location = new System.Drawing.Point(462, 422);
            this.radioBtn_Femenino.Name = "radioBtn_Femenino";
            this.radioBtn_Femenino.Size = new System.Drawing.Size(67, 17);
            this.radioBtn_Femenino.TabIndex = 82;
            this.radioBtn_Femenino.TabStop = true;
            this.radioBtn_Femenino.Text = "Feminino";
            this.radioBtn_Femenino.UseVisualStyleBackColor = true;
            this.radioBtn_Femenino.CheckedChanged += new System.EventHandler(this.radioBtn_Femenino_CheckedChanged);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape3,
            this.tl_username,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(950, 630);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 287;
            this.lineShape4.X2 = 608;
            this.lineShape4.Y1 = 277;
            this.lineShape4.Y2 = 277;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 288;
            this.lineShape3.X2 = 609;
            this.lineShape3.Y1 = 399;
            this.lineShape3.Y2 = 399;
            // 
            // tl_username
            // 
            this.tl_username.Name = "tl_username";
            this.tl_username.X1 = 289;
            this.tl_username.X2 = 610;
            this.tl_username.Y1 = 358;
            this.tl_username.Y2 = 358;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 288;
            this.lineShape1.X2 = 609;
            this.lineShape1.Y1 = 320;
            this.lineShape1.Y2 = 320;
            // 
            // pic_back
            // 
            this.pic_back.Image = ((System.Drawing.Image)(resources.GetObject("pic_back.Image")));
            this.pic_back.Location = new System.Drawing.Point(23, 35);
            this.pic_back.Name = "pic_back";
            this.pic_back.Size = new System.Drawing.Size(35, 35);
            this.pic_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_back.TabIndex = 133;
            this.pic_back.TabStop = false;
            this.pic_back.Click += new System.EventHandler(this.pic_back_Click);
            // 
            // Registar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pic_back);
            this.Controls.Add(this.radioBtn_Femenino);
            this.Controls.Add(this.radioBtn_Masculino);
            this.Controls.Add(this.txtBox_username);
            this.Controls.Add(this.lbl_sexo);
            this.Controls.Add(this.txtBox_email);
            this.Controls.Add(this.txtBox_password);
            this.Controls.Add(this.btn_registar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.Controls.Add(this.txtBox_telemovel);
            this.Name = "Registar";
            this.Size = new System.Drawing.Size(950, 630);
            ((System.ComponentModel.ISupportInitialize)(this.pic_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_registar;
        private System.Windows.Forms.TextBox txtBox_password;
        private System.Windows.Forms.TextBox txtBox_email;
        private System.Windows.Forms.TextBox txtBox_telemovel;
        private System.Windows.Forms.Label lbl_sexo;
        private System.Windows.Forms.TextBox txtBox_username;
        private System.Windows.Forms.RadioButton radioBtn_Masculino;
        private System.Windows.Forms.RadioButton radioBtn_Femenino;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape tl_username;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.PictureBox pic_back;
    }
}

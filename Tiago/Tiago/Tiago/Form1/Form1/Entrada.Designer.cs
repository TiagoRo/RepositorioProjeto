namespace Form1
{
    partial class form_entrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_entrada));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.Entrar = new System.Windows.Forms.Button();
            this.tl_username = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.pic_back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_back)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 21);
            this.label2.TabIndex = 69;
            this.label2.Text = "Faça login com a sua conta da PCStore";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 62);
            this.label1.TabIndex = 68;
            this.label1.Text = "Logotipo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userTextBox
            // 
            this.userTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.userTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userTextBox.Location = new System.Drawing.Point(287, 336);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(325, 13);
            this.userTextBox.TabIndex = 70;
            this.userTextBox.Text = "Nome de Utilizador";
            this.userTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userTextBox.TextChanged += new System.EventHandler(this.userTextBox_TextChanged);
            this.userTextBox.Enter += new System.EventHandler(this.userTextBox_Enter);
            this.userTextBox.Leave += new System.EventHandler(this.userTextBox_Leave);
            // 
            // passTextBox
            // 
            this.passTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.passTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passTextBox.Location = new System.Drawing.Point(287, 392);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(325, 13);
            this.passTextBox.TabIndex = 71;
            this.passTextBox.Text = "Palavra-passe";
            this.passTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passTextBox.TextChanged += new System.EventHandler(this.passTextBox_TextChanged);
            this.passTextBox.Enter += new System.EventHandler(this.passTextBox_Enter);
            this.passTextBox.Leave += new System.EventHandler(this.passTextBox_Leave);
            // 
            // Entrar
            // 
            this.Entrar.BackColor = System.Drawing.Color.DarkGray;
            this.Entrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Entrar.Location = new System.Drawing.Point(408, 457);
            this.Entrar.Name = "Entrar";
            this.Entrar.Size = new System.Drawing.Size(87, 34);
            this.Entrar.TabIndex = 72;
            this.Entrar.Text = "Entrar";
            this.Entrar.UseVisualStyleBackColor = false;
            this.Entrar.Click += new System.EventHandler(this.Entrar_Click);
            // 
            // tl_username
            // 
            this.tl_username.Name = "tl_username";
            this.tl_username.X1 = 291;
            this.tl_username.X2 = 612;
            this.tl_username.Y1 = 350;
            this.tl_username.Y2 = 350;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.tl_username});
            this.shapeContainer1.Size = new System.Drawing.Size(950, 630);
            this.shapeContainer1.TabIndex = 74;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 292;
            this.lineShape1.X2 = 613;
            this.lineShape1.Y1 = 405;
            this.lineShape1.Y2 = 405;
            // 
            // pic_back
            // 
            this.pic_back.Image = ((System.Drawing.Image)(resources.GetObject("pic_back.Image")));
            this.pic_back.Location = new System.Drawing.Point(22, 31);
            this.pic_back.Name = "pic_back";
            this.pic_back.Size = new System.Drawing.Size(35, 35);
            this.pic_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_back.TabIndex = 75;
            this.pic_back.TabStop = false;
            this.pic_back.Click += new System.EventHandler(this.pic_back_Click);
            // 
            // form_entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pic_back);
            this.Controls.Add(this.Entrar);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "form_entrada";
            this.Size = new System.Drawing.Size(950, 630);
            ((System.ComponentModel.ISupportInitialize)(this.pic_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Button Entrar;
        private Microsoft.VisualBasic.PowerPacks.LineShape tl_username;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.PictureBox pic_back;
    }
}

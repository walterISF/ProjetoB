namespace Projeto_B
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.PB_logo = new System.Windows.Forms.PictureBox();
            this.LBL_login = new System.Windows.Forms.Label();
            this.LBL_sair = new System.Windows.Forms.Label();
            this.LBL_sobre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_logo
            // 
            this.PB_logo.BackColor = System.Drawing.Color.Transparent;
            this.PB_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_logo.Image = global::Projeto_B.Properties.Resources.Logo;
            this.PB_logo.Location = new System.Drawing.Point(49, 44);
            this.PB_logo.Name = "PB_logo";
            this.PB_logo.Size = new System.Drawing.Size(400, 235);
            this.PB_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_logo.TabIndex = 5;
            this.PB_logo.TabStop = false;
            // 
            // LBL_login
            // 
            this.LBL_login.AutoSize = true;
            this.LBL_login.BackColor = System.Drawing.Color.Transparent;
            this.LBL_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBL_login.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_login.ForeColor = System.Drawing.Color.White;
            this.LBL_login.Location = new System.Drawing.Point(165, 390);
            this.LBL_login.Name = "LBL_login";
            this.LBL_login.Size = new System.Drawing.Size(111, 39);
            this.LBL_login.TabIndex = 7;
            this.LBL_login.Text = "Entrar..";
            this.LBL_login.Click += new System.EventHandler(this.LBL_login_Click);
            // 
            // LBL_sair
            // 
            this.LBL_sair.AutoSize = true;
            this.LBL_sair.BackColor = System.Drawing.Color.Transparent;
            this.LBL_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBL_sair.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_sair.ForeColor = System.Drawing.Color.White;
            this.LBL_sair.Location = new System.Drawing.Point(165, 441);
            this.LBL_sair.Name = "LBL_sair";
            this.LBL_sair.Size = new System.Drawing.Size(65, 39);
            this.LBL_sair.TabIndex = 8;
            this.LBL_sair.Text = "Sair";
            this.LBL_sair.Click += new System.EventHandler(this.LBL_sair_Click);
            // 
            // LBL_sobre
            // 
            this.LBL_sobre.AutoSize = true;
            this.LBL_sobre.BackColor = System.Drawing.Color.Transparent;
            this.LBL_sobre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBL_sobre.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_sobre.ForeColor = System.Drawing.Color.White;
            this.LBL_sobre.Location = new System.Drawing.Point(44, 555);
            this.LBL_sobre.Name = "LBL_sobre";
            this.LBL_sobre.Size = new System.Drawing.Size(165, 29);
            this.LBL_sobre.TabIndex = 9;
            this.LBL_sobre.Text = "Sobre o Sistema";
            this.LBL_sobre.Click += new System.EventHandler(this.LBL_sobre_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(531, 560);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(351, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "copyright 2015 Todos os direitos reservados.";
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(882, 593);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LBL_sobre);
            this.Controls.Add(this.LBL_sair);
            this.Controls.Add(this.LBL_login);
            this.Controls.Add(this.PB_logo);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SICAD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_logo;
        private System.Windows.Forms.Label LBL_login;
        private System.Windows.Forms.Label LBL_sair;
        private System.Windows.Forms.Label LBL_sobre;
        private System.Windows.Forms.Label label3;


    }
}


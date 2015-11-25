namespace Projeto_B
{
    partial class FrmBloq
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
            this.RBTN_bloq = new System.Windows.Forms.RadioButton();
            this.RBTN_desbloq = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_usuario = new System.Windows.Forms.TextBox();
            this.BTN_confirma = new System.Windows.Forms.Button();
            this.BTN_cancela = new System.Windows.Forms.Button();
            this.LBL_usuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RBTN_bloq
            // 
            this.RBTN_bloq.AutoSize = true;
            this.RBTN_bloq.Location = new System.Drawing.Point(45, 43);
            this.RBTN_bloq.Name = "RBTN_bloq";
            this.RBTN_bloq.Size = new System.Drawing.Size(100, 27);
            this.RBTN_bloq.TabIndex = 0;
            this.RBTN_bloq.TabStop = true;
            this.RBTN_bloq.Text = "Bloquear";
            this.RBTN_bloq.UseVisualStyleBackColor = true;
            // 
            // RBTN_desbloq
            // 
            this.RBTN_desbloq.AutoSize = true;
            this.RBTN_desbloq.Location = new System.Drawing.Point(169, 43);
            this.RBTN_desbloq.Name = "RBTN_desbloq";
            this.RBTN_desbloq.Size = new System.Drawing.Size(129, 27);
            this.RBTN_desbloq.TabIndex = 1;
            this.RBTN_desbloq.TabStop = true;
            this.RBTN_desbloq.Text = "Desbloquear";
            this.RBTN_desbloq.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código do usuario:";
            // 
            // TXT_usuario
            // 
            this.TXT_usuario.Location = new System.Drawing.Point(95, 106);
            this.TXT_usuario.Name = "TXT_usuario";
            this.TXT_usuario.Size = new System.Drawing.Size(150, 29);
            this.TXT_usuario.TabIndex = 3;
            // 
            // BTN_confirma
            // 
            this.BTN_confirma.Location = new System.Drawing.Point(36, 165);
            this.BTN_confirma.Name = "BTN_confirma";
            this.BTN_confirma.Size = new System.Drawing.Size(117, 34);
            this.BTN_confirma.TabIndex = 4;
            this.BTN_confirma.Text = "Confirmar";
            this.BTN_confirma.UseVisualStyleBackColor = true;
            this.BTN_confirma.Click += new System.EventHandler(this.BTN_confirma_Click);
            // 
            // BTN_cancela
            // 
            this.BTN_cancela.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_cancela.Location = new System.Drawing.Point(192, 165);
            this.BTN_cancela.Name = "BTN_cancela";
            this.BTN_cancela.Size = new System.Drawing.Size(117, 34);
            this.BTN_cancela.TabIndex = 5;
            this.BTN_cancela.Text = "Cancelar";
            this.BTN_cancela.UseVisualStyleBackColor = true;
            this.BTN_cancela.Click += new System.EventHandler(this.button2_Click);
            // 
            // LBL_usuario
            // 
            this.LBL_usuario.AutoSize = true;
            this.LBL_usuario.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_usuario.Location = new System.Drawing.Point(97, 136);
            this.LBL_usuario.Name = "LBL_usuario";
            this.LBL_usuario.Size = new System.Drawing.Size(0, 18);
            this.LBL_usuario.TabIndex = 6;
            // 
            // FrmBloq
            // 
            this.AcceptButton = this.BTN_confirma;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_cancela;
            this.ClientSize = new System.Drawing.Size(345, 235);
            this.Controls.Add(this.LBL_usuario);
            this.Controls.Add(this.BTN_cancela);
            this.Controls.Add(this.BTN_confirma);
            this.Controls.Add(this.TXT_usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RBTN_desbloq);
            this.Controls.Add(this.RBTN_bloq);
            this.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmBloq";
            this.Text = "FrmBloq";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RBTN_bloq;
        private System.Windows.Forms.RadioButton RBTN_desbloq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_usuario;
        private System.Windows.Forms.Button BTN_confirma;
        private System.Windows.Forms.Button BTN_cancela;
        private System.Windows.Forms.Label LBL_usuario;
    }
}
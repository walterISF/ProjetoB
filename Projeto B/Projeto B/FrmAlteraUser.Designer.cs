namespace Projeto_B
{
    partial class FrmAlteraUser
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
            this.BTN_alterar = new System.Windows.Forms.Button();
            this.BTN_cancelar = new System.Windows.Forms.Button();
            this.TXT_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CBOX_perfil = new System.Windows.Forms.ComboBox();
            this.TXT_codigo = new System.Windows.Forms.MaskedTextBox();
            this.TXT_nascimento = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // BTN_alterar
            // 
            this.BTN_alterar.Location = new System.Drawing.Point(150, 227);
            this.BTN_alterar.Name = "BTN_alterar";
            this.BTN_alterar.Size = new System.Drawing.Size(120, 44);
            this.BTN_alterar.TabIndex = 0;
            this.BTN_alterar.Text = "Alterar";
            this.BTN_alterar.UseVisualStyleBackColor = true;
            this.BTN_alterar.Click += new System.EventHandler(this.BTN_alterar_Click);
            // 
            // BTN_cancelar
            // 
            this.BTN_cancelar.Location = new System.Drawing.Point(321, 227);
            this.BTN_cancelar.Name = "BTN_cancelar";
            this.BTN_cancelar.Size = new System.Drawing.Size(120, 44);
            this.BTN_cancelar.TabIndex = 1;
            this.BTN_cancelar.Text = "Cancelar";
            this.BTN_cancelar.UseVisualStyleBackColor = true;
            this.BTN_cancelar.Click += new System.EventHandler(this.BTN_cancelar_Click);
            // 
            // TXT_nome
            // 
            this.TXT_nome.Enabled = false;
            this.TXT_nome.Location = new System.Drawing.Point(35, 104);
            this.TXT_nome.Name = "TXT_nome";
            this.TXT_nome.Size = new System.Drawing.Size(348, 29);
            this.TXT_nome.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Codigo do usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data de nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Perfil";
            // 
            // CBOX_perfil
            // 
            this.CBOX_perfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOX_perfil.Enabled = false;
            this.CBOX_perfil.FormattingEnabled = true;
            this.CBOX_perfil.Items.AddRange(new object[] {
            "1 - Administrados",
            "2 - Operador",
            "3 - Auxiliar",
            " "});
            this.CBOX_perfil.Location = new System.Drawing.Point(35, 172);
            this.CBOX_perfil.Name = "CBOX_perfil";
            this.CBOX_perfil.Size = new System.Drawing.Size(214, 30);
            this.CBOX_perfil.TabIndex = 9;
            // 
            // TXT_codigo
            // 
            this.TXT_codigo.Location = new System.Drawing.Point(186, 32);
            this.TXT_codigo.Mask = "000000";
            this.TXT_codigo.Name = "TXT_codigo";
            this.TXT_codigo.Size = new System.Drawing.Size(100, 29);
            this.TXT_codigo.TabIndex = 10;
            this.TXT_codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_codigo.Leave += new System.EventHandler(this.TXT_codigo_Leave);
            // 
            // TXT_nascimento
            // 
            this.TXT_nascimento.Enabled = false;
            this.TXT_nascimento.Location = new System.Drawing.Point(389, 104);
            this.TXT_nascimento.Mask = "00/00/0000";
            this.TXT_nascimento.Name = "TXT_nascimento";
            this.TXT_nascimento.Size = new System.Drawing.Size(158, 29);
            this.TXT_nascimento.TabIndex = 11;
            this.TXT_nascimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmAlteraUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 293);
            this.Controls.Add(this.TXT_nascimento);
            this.Controls.Add(this.TXT_codigo);
            this.Controls.Add(this.CBOX_perfil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_nome);
            this.Controls.Add(this.BTN_cancelar);
            this.Controls.Add(this.BTN_alterar);
            this.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmAlteraUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAlteraUser";
            this.Load += new System.EventHandler(this.FrmAlteraUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_alterar;
        private System.Windows.Forms.Button BTN_cancelar;
        private System.Windows.Forms.TextBox TXT_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBOX_perfil;
        private System.Windows.Forms.MaskedTextBox TXT_codigo;
        private System.Windows.Forms.MaskedTextBox TXT_nascimento;
    }
}
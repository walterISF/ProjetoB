namespace Projeto_B
{
    partial class FrmNovoUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LBL_codUsuario = new System.Windows.Forms.Label();
            this.TXT_nome = new System.Windows.Forms.TextBox();
            this.TXT_nascimento = new System.Windows.Forms.MaskedTextBox();
            this.CBOX_perfil = new System.Windows.Forms.ComboBox();
            this.BTN_salvar = new System.Windows.Forms.Button();
            this.BTN_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código do Usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data de Nascimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Perfil de Usuário:";
            // 
            // LBL_codUsuario
            // 
            this.LBL_codUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_codUsuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_codUsuario.Location = new System.Drawing.Point(192, 31);
            this.LBL_codUsuario.Name = "LBL_codUsuario";
            this.LBL_codUsuario.Size = new System.Drawing.Size(118, 29);
            this.LBL_codUsuario.TabIndex = 4;
            this.LBL_codUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_nome
            // 
            this.TXT_nome.Location = new System.Drawing.Point(192, 81);
            this.TXT_nome.MaxLength = 80;
            this.TXT_nome.Name = "TXT_nome";
            this.TXT_nome.Size = new System.Drawing.Size(316, 29);
            this.TXT_nome.TabIndex = 5;
            // 
            // TXT_nascimento
            // 
            this.TXT_nascimento.Location = new System.Drawing.Point(192, 127);
            this.TXT_nascimento.Mask = "00/00/0000";
            this.TXT_nascimento.Name = "TXT_nascimento";
            this.TXT_nascimento.Size = new System.Drawing.Size(100, 29);
            this.TXT_nascimento.TabIndex = 6;
            // 
            // CBOX_perfil
            // 
            this.CBOX_perfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOX_perfil.Items.AddRange(new object[] {
            "1 - Adiministrador",
            "2 - Operador",
            "3 - Auxiliar",
            " "});
            this.CBOX_perfil.Location = new System.Drawing.Point(192, 171);
            this.CBOX_perfil.Name = "CBOX_perfil";
            this.CBOX_perfil.Size = new System.Drawing.Size(204, 30);
            this.CBOX_perfil.TabIndex = 7;
            // 
            // BTN_salvar
            // 
            this.BTN_salvar.Location = new System.Drawing.Point(120, 239);
            this.BTN_salvar.Name = "BTN_salvar";
            this.BTN_salvar.Size = new System.Drawing.Size(125, 37);
            this.BTN_salvar.TabIndex = 8;
            this.BTN_salvar.Text = "Salvar";
            this.BTN_salvar.UseVisualStyleBackColor = true;
            this.BTN_salvar.Click += new System.EventHandler(this.BTN_salvar_Click);
            // 
            // BTN_cancelar
            // 
            this.BTN_cancelar.Location = new System.Drawing.Point(256, 239);
            this.BTN_cancelar.Name = "BTN_cancelar";
            this.BTN_cancelar.Size = new System.Drawing.Size(125, 37);
            this.BTN_cancelar.TabIndex = 9;
            this.BTN_cancelar.Text = "Cancelar";
            this.BTN_cancelar.UseVisualStyleBackColor = true;
            this.BTN_cancelar.Click += new System.EventHandler(this.BTN_cancelar_Click);
            // 
            // FrmNovoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 306);
            this.Controls.Add(this.BTN_cancelar);
            this.Controls.Add(this.BTN_salvar);
            this.Controls.Add(this.CBOX_perfil);
            this.Controls.Add(this.TXT_nascimento);
            this.Controls.Add(this.TXT_nome);
            this.Controls.Add(this.LBL_codUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmNovoUsuario";
            this.Text = "FrmNovoUsuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmNovoUsuario_FormClosing);
            this.Load += new System.EventHandler(this.FrmNovoUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LBL_codUsuario;
        private System.Windows.Forms.TextBox TXT_nome;
        private System.Windows.Forms.MaskedTextBox TXT_nascimento;
        private System.Windows.Forms.ComboBox CBOX_perfil;
        private System.Windows.Forms.Button BTN_salvar;
        private System.Windows.Forms.Button BTN_cancelar;

    }
}
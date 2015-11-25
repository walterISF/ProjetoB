namespace Projeto_B
{
    partial class FrmSenha
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
            this.BTN_salvar = new System.Windows.Forms.Button();
            this.TXT_senha = new System.Windows.Forms.TextBox();
            this.TXT_nsenha = new System.Windows.Forms.TextBox();
            this.TXT_rnsenha = new System.Windows.Forms.TextBox();
            this.LBL_n1 = new System.Windows.Forms.Label();
            this.LBL_n2 = new System.Windows.Forms.Label();
            this.LBL_n4 = new System.Windows.Forms.Label();
            this.LBL_n3 = new System.Windows.Forms.Label();
            this.LBL_n5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BTN_cancelar = new System.Windows.Forms.Button();
            this.LBL_mensagem = new System.Windows.Forms.Label();
            this.LBL_usuario = new System.Windows.Forms.Label();
            this.LBL_forca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_salvar
            // 
            this.BTN_salvar.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_salvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.BTN_salvar.Location = new System.Drawing.Point(76, 327);
            this.BTN_salvar.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_salvar.Name = "BTN_salvar";
            this.BTN_salvar.Size = new System.Drawing.Size(107, 36);
            this.BTN_salvar.TabIndex = 0;
            this.BTN_salvar.Text = "Salvar";
            this.BTN_salvar.UseVisualStyleBackColor = true;
            this.BTN_salvar.Click += new System.EventHandler(this.BTN_salvar_Click);
            // 
            // TXT_senha
            // 
            this.TXT_senha.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_senha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TXT_senha.Location = new System.Drawing.Point(43, 106);
            this.TXT_senha.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_senha.Name = "TXT_senha";
            this.TXT_senha.PasswordChar = '●';
            this.TXT_senha.Size = new System.Drawing.Size(132, 29);
            this.TXT_senha.TabIndex = 2;
            this.TXT_senha.UseSystemPasswordChar = true;
            // 
            // TXT_nsenha
            // 
            this.TXT_nsenha.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_nsenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TXT_nsenha.Location = new System.Drawing.Point(43, 170);
            this.TXT_nsenha.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_nsenha.Name = "TXT_nsenha";
            this.TXT_nsenha.PasswordChar = '●';
            this.TXT_nsenha.Size = new System.Drawing.Size(132, 29);
            this.TXT_nsenha.TabIndex = 3;
            this.TXT_nsenha.UseSystemPasswordChar = true;
            this.TXT_nsenha.TextChanged += new System.EventHandler(this.TXT_nsenha_TextChanged);
            this.TXT_nsenha.Leave += new System.EventHandler(this.TXT_nsenha_Leave);
            // 
            // TXT_rnsenha
            // 
            this.TXT_rnsenha.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_rnsenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TXT_rnsenha.Location = new System.Drawing.Point(221, 170);
            this.TXT_rnsenha.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_rnsenha.Name = "TXT_rnsenha";
            this.TXT_rnsenha.PasswordChar = '●';
            this.TXT_rnsenha.Size = new System.Drawing.Size(132, 29);
            this.TXT_rnsenha.TabIndex = 4;
            this.TXT_rnsenha.UseSystemPasswordChar = true;
            // 
            // LBL_n1
            // 
            this.LBL_n1.BackColor = System.Drawing.Color.Red;
            this.LBL_n1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_n1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.LBL_n1.Location = new System.Drawing.Point(43, 260);
            this.LBL_n1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_n1.Name = "LBL_n1";
            this.LBL_n1.Size = new System.Drawing.Size(61, 20);
            this.LBL_n1.TabIndex = 5;
            this.LBL_n1.Visible = false;
            // 
            // LBL_n2
            // 
            this.LBL_n2.BackColor = System.Drawing.Color.Orange;
            this.LBL_n2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_n2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.LBL_n2.Location = new System.Drawing.Point(105, 260);
            this.LBL_n2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_n2.Name = "LBL_n2";
            this.LBL_n2.Size = new System.Drawing.Size(61, 20);
            this.LBL_n2.TabIndex = 12;
            this.LBL_n2.Visible = false;
            // 
            // LBL_n4
            // 
            this.LBL_n4.BackColor = System.Drawing.Color.Green;
            this.LBL_n4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_n4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.LBL_n4.Location = new System.Drawing.Point(231, 260);
            this.LBL_n4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_n4.Name = "LBL_n4";
            this.LBL_n4.Size = new System.Drawing.Size(61, 20);
            this.LBL_n4.TabIndex = 14;
            this.LBL_n4.Visible = false;
            // 
            // LBL_n3
            // 
            this.LBL_n3.BackColor = System.Drawing.Color.Yellow;
            this.LBL_n3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_n3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.LBL_n3.Location = new System.Drawing.Point(168, 260);
            this.LBL_n3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_n3.Name = "LBL_n3";
            this.LBL_n3.Size = new System.Drawing.Size(61, 20);
            this.LBL_n3.TabIndex = 13;
            this.LBL_n3.Visible = false;
            // 
            // LBL_n5
            // 
            this.LBL_n5.BackColor = System.Drawing.Color.Blue;
            this.LBL_n5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_n5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.LBL_n5.Location = new System.Drawing.Point(293, 260);
            this.LBL_n5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_n5.Name = "LBL_n5";
            this.LBL_n5.Size = new System.Drawing.Size(61, 20);
            this.LBL_n5.TabIndex = 15;
            this.LBL_n5.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(39, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Senha Atual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(39, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nova Senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label5.Location = new System.Drawing.Point(39, 235);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "Força da Senha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label6.Location = new System.Drawing.Point(217, 143);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "Repetir Nova Senha";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label9.Location = new System.Drawing.Point(39, 27);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 23);
            this.label9.TabIndex = 20;
            this.label9.Text = "Usuário:";
            // 
            // BTN_cancelar
            // 
            this.BTN_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_cancelar.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_cancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.BTN_cancelar.Location = new System.Drawing.Point(221, 327);
            this.BTN_cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_cancelar.Name = "BTN_cancelar";
            this.BTN_cancelar.Size = new System.Drawing.Size(107, 36);
            this.BTN_cancelar.TabIndex = 21;
            this.BTN_cancelar.Text = "Cancelar";
            this.BTN_cancelar.UseVisualStyleBackColor = true;
            this.BTN_cancelar.Click += new System.EventHandler(this.BTN_cancelar_Click);
            // 
            // LBL_mensagem
            // 
            this.LBL_mensagem.AutoSize = true;
            this.LBL_mensagem.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_mensagem.ForeColor = System.Drawing.Color.Red;
            this.LBL_mensagem.Location = new System.Drawing.Point(13, 203);
            this.LBL_mensagem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_mensagem.Name = "LBL_mensagem";
            this.LBL_mensagem.Size = new System.Drawing.Size(0, 18);
            this.LBL_mensagem.TabIndex = 23;
            // 
            // LBL_usuario
            // 
            this.LBL_usuario.AutoSize = true;
            this.LBL_usuario.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.LBL_usuario.Location = new System.Drawing.Point(122, 27);
            this.LBL_usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_usuario.Name = "LBL_usuario";
            this.LBL_usuario.Size = new System.Drawing.Size(0, 23);
            this.LBL_usuario.TabIndex = 25;
            // 
            // LBL_forca
            // 
            this.LBL_forca.AutoSize = true;
            this.LBL_forca.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_forca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.LBL_forca.Location = new System.Drawing.Point(45, 282);
            this.LBL_forca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_forca.Name = "LBL_forca";
            this.LBL_forca.Size = new System.Drawing.Size(0, 18);
            this.LBL_forca.TabIndex = 26;
            // 
            // FrmSenha
            // 
            this.AcceptButton = this.BTN_salvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_cancelar;
            this.ClientSize = new System.Drawing.Size(406, 376);
            this.Controls.Add(this.LBL_forca);
            this.Controls.Add(this.LBL_usuario);
            this.Controls.Add(this.LBL_mensagem);
            this.Controls.Add(this.BTN_cancelar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBL_n5);
            this.Controls.Add(this.LBL_n4);
            this.Controls.Add(this.LBL_n3);
            this.Controls.Add(this.LBL_n2);
            this.Controls.Add(this.LBL_n1);
            this.Controls.Add(this.TXT_rnsenha);
            this.Controls.Add(this.TXT_nsenha);
            this.Controls.Add(this.TXT_senha);
            this.Controls.Add(this.BTN_salvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSenha";
            this.Load += new System.EventHandler(this.FrmSenha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_salvar;
        private System.Windows.Forms.TextBox TXT_senha;
        private System.Windows.Forms.TextBox TXT_nsenha;
        private System.Windows.Forms.TextBox TXT_rnsenha;
        private System.Windows.Forms.Label LBL_n1;
        private System.Windows.Forms.Label LBL_n2;
        private System.Windows.Forms.Label LBL_n4;
        private System.Windows.Forms.Label LBL_n3;
        private System.Windows.Forms.Label LBL_n5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BTN_cancelar;
        private System.Windows.Forms.Label LBL_mensagem;
        private System.Windows.Forms.Label LBL_usuario;
        private System.Windows.Forms.Label LBL_forca;
    }
}
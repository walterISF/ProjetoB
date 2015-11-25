namespace Projeto_B
{
    partial class FrmCalc
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GBOX_resultados = new System.Windows.Forms.GroupBox();
            this.LBL_resultados = new System.Windows.Forms.Label();
            this.GBOX_entrada = new System.Windows.Forms.GroupBox();
            this.LBL_entradas = new System.Windows.Forms.Label();
            this.LBOX_calendarios = new System.Windows.Forms.ListBox();
            this.LBL_dataA = new System.Windows.Forms.Label();
            this.LBL_dataB = new System.Windows.Forms.Label();
            this.GBOX_incrementos = new System.Windows.Forms.GroupBox();
            this.TXT_meses = new System.Windows.Forms.MaskedTextBox();
            this.TXT_semanas = new System.Windows.Forms.MaskedTextBox();
            this.TXT_dias = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_dataA = new System.Windows.Forms.MaskedTextBox();
            this.TXT_dataB = new System.Windows.Forms.MaskedTextBox();
            this.RBTN_calculo = new System.Windows.Forms.RadioButton();
            this.RBTN_diferenca = new System.Windows.Forms.RadioButton();
            this.RBTN_incremento = new System.Windows.Forms.RadioButton();
            this.RBTN_decremento = new System.Windows.Forms.RadioButton();
            this.RBTN_info = new System.Windows.Forms.RadioButton();
            this.RBTN_outros = new System.Windows.Forms.RadioButton();
            this.BTN_validar = new System.Windows.Forms.Button();
            this.CBOX_datas = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GBOX_resultados.SuspendLayout();
            this.GBOX_entrada.SuspendLayout();
            this.GBOX_incrementos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Image = global::Projeto_B.Properties.Resources.Divisor;
            this.pictureBox1.Location = new System.Drawing.Point(205, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2, 341);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // GBOX_resultados
            // 
            this.GBOX_resultados.BackColor = System.Drawing.SystemColors.Control;
            this.GBOX_resultados.Controls.Add(this.LBL_resultados);
            this.GBOX_resultados.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBOX_resultados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.GBOX_resultados.Location = new System.Drawing.Point(217, 206);
            this.GBOX_resultados.Margin = new System.Windows.Forms.Padding(2);
            this.GBOX_resultados.Name = "GBOX_resultados";
            this.GBOX_resultados.Padding = new System.Windows.Forms.Padding(2);
            this.GBOX_resultados.Size = new System.Drawing.Size(253, 133);
            this.GBOX_resultados.TabIndex = 8;
            this.GBOX_resultados.TabStop = false;
            this.GBOX_resultados.Text = "Resultados";
            // 
            // LBL_resultados
            // 
            this.LBL_resultados.Location = new System.Drawing.Point(14, 24);
            this.LBL_resultados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_resultados.Name = "LBL_resultados";
            this.LBL_resultados.Size = new System.Drawing.Size(228, 96);
            this.LBL_resultados.TabIndex = 0;
            // 
            // GBOX_entrada
            // 
            this.GBOX_entrada.Controls.Add(this.LBL_entradas);
            this.GBOX_entrada.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBOX_entrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.GBOX_entrada.Location = new System.Drawing.Point(217, 63);
            this.GBOX_entrada.Margin = new System.Windows.Forms.Padding(2);
            this.GBOX_entrada.Name = "GBOX_entrada";
            this.GBOX_entrada.Padding = new System.Windows.Forms.Padding(2);
            this.GBOX_entrada.Size = new System.Drawing.Size(253, 129);
            this.GBOX_entrada.TabIndex = 16;
            this.GBOX_entrada.TabStop = false;
            this.GBOX_entrada.Text = "Entrada";
            // 
            // LBL_entradas
            // 
            this.LBL_entradas.Location = new System.Drawing.Point(11, 17);
            this.LBL_entradas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_entradas.Name = "LBL_entradas";
            this.LBL_entradas.Size = new System.Drawing.Size(230, 101);
            this.LBL_entradas.TabIndex = 1;
            // 
            // LBOX_calendarios
            // 
            this.LBOX_calendarios.BackColor = System.Drawing.Color.Gainsboro;
            this.LBOX_calendarios.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBOX_calendarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.LBOX_calendarios.FormattingEnabled = true;
            this.LBOX_calendarios.ItemHeight = 17;
            this.LBOX_calendarios.Items.AddRange(new object[] {
            "Calendarios:",
            "Judaico",
            "Islamico",
            "Chines"});
            this.LBOX_calendarios.Location = new System.Drawing.Point(217, 98);
            this.LBOX_calendarios.Margin = new System.Windows.Forms.Padding(2);
            this.LBOX_calendarios.Name = "LBOX_calendarios";
            this.LBOX_calendarios.Size = new System.Drawing.Size(254, 89);
            this.LBOX_calendarios.TabIndex = 41;
            this.LBOX_calendarios.Visible = false;
            // 
            // LBL_dataA
            // 
            this.LBL_dataA.AutoSize = true;
            this.LBL_dataA.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_dataA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.LBL_dataA.Location = new System.Drawing.Point(10, 12);
            this.LBL_dataA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_dataA.Name = "LBL_dataA";
            this.LBL_dataA.Size = new System.Drawing.Size(0, 18);
            this.LBL_dataA.TabIndex = 23;
            // 
            // LBL_dataB
            // 
            this.LBL_dataB.AutoSize = true;
            this.LBL_dataB.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_dataB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.LBL_dataB.Location = new System.Drawing.Point(10, 86);
            this.LBL_dataB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_dataB.Name = "LBL_dataB";
            this.LBL_dataB.Size = new System.Drawing.Size(0, 18);
            this.LBL_dataB.TabIndex = 25;
            // 
            // GBOX_incrementos
            // 
            this.GBOX_incrementos.Controls.Add(this.TXT_meses);
            this.GBOX_incrementos.Controls.Add(this.TXT_semanas);
            this.GBOX_incrementos.Controls.Add(this.TXT_dias);
            this.GBOX_incrementos.Controls.Add(this.label4);
            this.GBOX_incrementos.Controls.Add(this.label3);
            this.GBOX_incrementos.Controls.Add(this.label2);
            this.GBOX_incrementos.Location = new System.Drawing.Point(12, 78);
            this.GBOX_incrementos.Margin = new System.Windows.Forms.Padding(2);
            this.GBOX_incrementos.Name = "GBOX_incrementos";
            this.GBOX_incrementos.Padding = new System.Windows.Forms.Padding(2);
            this.GBOX_incrementos.Size = new System.Drawing.Size(181, 53);
            this.GBOX_incrementos.TabIndex = 30;
            this.GBOX_incrementos.TabStop = false;
            this.GBOX_incrementos.Visible = false;
            // 
            // TXT_meses
            // 
            this.TXT_meses.BackColor = System.Drawing.Color.Gainsboro;
            this.TXT_meses.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_meses.Location = new System.Drawing.Point(136, 25);
            this.TXT_meses.Margin = new System.Windows.Forms.Padding(2);
            this.TXT_meses.Mask = "00";
            this.TXT_meses.Name = "TXT_meses";
            this.TXT_meses.Size = new System.Drawing.Size(37, 22);
            this.TXT_meses.TabIndex = 34;
            this.TXT_meses.Text = "00";
            this.TXT_meses.Click += new System.EventHandler(this.TXT_meses_Click);
            this.TXT_meses.TextChanged += new System.EventHandler(this.TXT_meses_TextChanged);
            // 
            // TXT_semanas
            // 
            this.TXT_semanas.BackColor = System.Drawing.Color.Gainsboro;
            this.TXT_semanas.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_semanas.Location = new System.Drawing.Point(68, 25);
            this.TXT_semanas.Margin = new System.Windows.Forms.Padding(2);
            this.TXT_semanas.Mask = "00";
            this.TXT_semanas.Name = "TXT_semanas";
            this.TXT_semanas.Size = new System.Drawing.Size(37, 22);
            this.TXT_semanas.TabIndex = 35;
            this.TXT_semanas.Text = "00";
            this.TXT_semanas.Click += new System.EventHandler(this.TXT_semanas_Click);
            this.TXT_semanas.TextChanged += new System.EventHandler(this.TXT_semanas_TextChanged);
            // 
            // TXT_dias
            // 
            this.TXT_dias.BackColor = System.Drawing.Color.Gainsboro;
            this.TXT_dias.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_dias.Location = new System.Drawing.Point(7, 25);
            this.TXT_dias.Margin = new System.Windows.Forms.Padding(2);
            this.TXT_dias.Mask = "000";
            this.TXT_dias.Name = "TXT_dias";
            this.TXT_dias.Size = new System.Drawing.Size(37, 22);
            this.TXT_dias.TabIndex = 33;
            this.TXT_dias.Text = "000";
            this.TXT_dias.Click += new System.EventHandler(this.TXT_dias_Click);
            this.TXT_dias.TextChanged += new System.EventHandler(this.TXT_dias_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(134, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "Meses";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(66, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "Semanas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(5, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dias";
            // 
            // TXT_dataA
            // 
            this.TXT_dataA.BackColor = System.Drawing.Color.Gainsboro;
            this.TXT_dataA.Enabled = false;
            this.TXT_dataA.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_dataA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TXT_dataA.Location = new System.Drawing.Point(12, 33);
            this.TXT_dataA.Margin = new System.Windows.Forms.Padding(2);
            this.TXT_dataA.Mask = "00/00/0000";
            this.TXT_dataA.Name = "TXT_dataA";
            this.TXT_dataA.Size = new System.Drawing.Size(182, 25);
            this.TXT_dataA.TabIndex = 31;
            this.TXT_dataA.TextChanged += new System.EventHandler(this.TXT_dataA_TextChanged);
            // 
            // TXT_dataB
            // 
            this.TXT_dataB.BackColor = System.Drawing.Color.Gainsboro;
            this.TXT_dataB.Enabled = false;
            this.TXT_dataB.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_dataB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TXT_dataB.Location = new System.Drawing.Point(10, 106);
            this.TXT_dataB.Margin = new System.Windows.Forms.Padding(2);
            this.TXT_dataB.Mask = "00/00/0000";
            this.TXT_dataB.Name = "TXT_dataB";
            this.TXT_dataB.Size = new System.Drawing.Size(182, 25);
            this.TXT_dataB.TabIndex = 32;
            this.TXT_dataB.TextChanged += new System.EventHandler(this.TXT_dataB_TextChanged);
            // 
            // RBTN_calculo
            // 
            this.RBTN_calculo.Appearance = System.Windows.Forms.Appearance.Button;
            this.RBTN_calculo.AutoSize = true;
            this.RBTN_calculo.FlatAppearance.BorderSize = 0;
            this.RBTN_calculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.RBTN_calculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RBTN_calculo.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTN_calculo.Location = new System.Drawing.Point(71, 154);
            this.RBTN_calculo.Margin = new System.Windows.Forms.Padding(2);
            this.RBTN_calculo.Name = "RBTN_calculo";
            this.RBTN_calculo.Size = new System.Drawing.Size(120, 28);
            this.RBTN_calculo.TabIndex = 33;
            this.RBTN_calculo.Text = "Cálculo de idade";
            this.RBTN_calculo.UseVisualStyleBackColor = true;
            this.RBTN_calculo.CheckedChanged += new System.EventHandler(this.RBTN_calculo_CheckedChanged);
            // 
            // RBTN_diferenca
            // 
            this.RBTN_diferenca.Appearance = System.Windows.Forms.Appearance.Button;
            this.RBTN_diferenca.AutoSize = true;
            this.RBTN_diferenca.FlatAppearance.BorderSize = 0;
            this.RBTN_diferenca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.RBTN_diferenca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RBTN_diferenca.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTN_diferenca.Location = new System.Drawing.Point(40, 184);
            this.RBTN_diferenca.Margin = new System.Windows.Forms.Padding(2);
            this.RBTN_diferenca.Name = "RBTN_diferenca";
            this.RBTN_diferenca.Size = new System.Drawing.Size(151, 28);
            this.RBTN_diferenca.TabIndex = 34;
            this.RBTN_diferenca.Text = "Diferença entre datas";
            this.RBTN_diferenca.UseVisualStyleBackColor = true;
            this.RBTN_diferenca.CheckedChanged += new System.EventHandler(this.RBTN_diferenca_CheckedChanged);
            // 
            // RBTN_incremento
            // 
            this.RBTN_incremento.Appearance = System.Windows.Forms.Appearance.Button;
            this.RBTN_incremento.AutoSize = true;
            this.RBTN_incremento.FlatAppearance.BorderSize = 0;
            this.RBTN_incremento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.RBTN_incremento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RBTN_incremento.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTN_incremento.Location = new System.Drawing.Point(45, 215);
            this.RBTN_incremento.Margin = new System.Windows.Forms.Padding(2);
            this.RBTN_incremento.Name = "RBTN_incremento";
            this.RBTN_incremento.Size = new System.Drawing.Size(145, 28);
            this.RBTN_incremento.TabIndex = 35;
            this.RBTN_incremento.Text = "Incremento de datas";
            this.RBTN_incremento.UseVisualStyleBackColor = true;
            this.RBTN_incremento.CheckedChanged += new System.EventHandler(this.RBTN_incremento_CheckedChanged);
            // 
            // RBTN_decremento
            // 
            this.RBTN_decremento.Appearance = System.Windows.Forms.Appearance.Button;
            this.RBTN_decremento.AutoSize = true;
            this.RBTN_decremento.FlatAppearance.BorderSize = 0;
            this.RBTN_decremento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.RBTN_decremento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RBTN_decremento.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTN_decremento.Location = new System.Drawing.Point(41, 246);
            this.RBTN_decremento.Margin = new System.Windows.Forms.Padding(2);
            this.RBTN_decremento.Name = "RBTN_decremento";
            this.RBTN_decremento.Size = new System.Drawing.Size(150, 28);
            this.RBTN_decremento.TabIndex = 36;
            this.RBTN_decremento.Text = "Decremento de datas";
            this.RBTN_decremento.UseVisualStyleBackColor = true;
            this.RBTN_decremento.CheckedChanged += new System.EventHandler(this.RBTN_decremento_CheckedChanged);
            // 
            // RBTN_info
            // 
            this.RBTN_info.Appearance = System.Windows.Forms.Appearance.Button;
            this.RBTN_info.AutoSize = true;
            this.RBTN_info.FlatAppearance.BorderSize = 0;
            this.RBTN_info.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.RBTN_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RBTN_info.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTN_info.Location = new System.Drawing.Point(20, 277);
            this.RBTN_info.Margin = new System.Windows.Forms.Padding(2);
            this.RBTN_info.Name = "RBTN_info";
            this.RBTN_info.Size = new System.Drawing.Size(169, 28);
            this.RBTN_info.TabIndex = 37;
            this.RBTN_info.Text = "Informações sobre datas";
            this.RBTN_info.UseVisualStyleBackColor = true;
            this.RBTN_info.CheckedChanged += new System.EventHandler(this.RBTN_info_CheckedChanged);
            // 
            // RBTN_outros
            // 
            this.RBTN_outros.Appearance = System.Windows.Forms.Appearance.Button;
            this.RBTN_outros.AutoSize = true;
            this.RBTN_outros.FlatAppearance.BorderSize = 0;
            this.RBTN_outros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.RBTN_outros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RBTN_outros.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTN_outros.Location = new System.Drawing.Point(55, 308);
            this.RBTN_outros.Margin = new System.Windows.Forms.Padding(2);
            this.RBTN_outros.Name = "RBTN_outros";
            this.RBTN_outros.Size = new System.Drawing.Size(134, 28);
            this.RBTN_outros.TabIndex = 38;
            this.RBTN_outros.Text = "Outros calendários";
            this.RBTN_outros.UseVisualStyleBackColor = true;
            this.RBTN_outros.CheckedChanged += new System.EventHandler(this.RBTN_outros_CheckedChanged);
            // 
            // BTN_validar
            // 
            this.BTN_validar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BTN_validar.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_validar.Location = new System.Drawing.Point(217, 16);
            this.BTN_validar.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_validar.Name = "BTN_validar";
            this.BTN_validar.Size = new System.Drawing.Size(89, 35);
            this.BTN_validar.TabIndex = 39;
            this.BTN_validar.Text = "Validar";
            this.BTN_validar.UseVisualStyleBackColor = true;
            this.BTN_validar.Click += new System.EventHandler(this.BTN_validar_Click);
            // 
            // CBOX_datas
            // 
            this.CBOX_datas.BackColor = System.Drawing.Color.Gainsboro;
            this.CBOX_datas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBOX_datas.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOX_datas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.CBOX_datas.Items.AddRange(new object[] {
            "06/04/1990",
            "13/08/1995",
            "23/09/2011",
            "31/05/2012",
            "18/05/2015",
            "12/12/2018",
            "31/12/2022"});
            this.CBOX_datas.Location = new System.Drawing.Point(217, 33);
            this.CBOX_datas.Margin = new System.Windows.Forms.Padding(2);
            this.CBOX_datas.Name = "CBOX_datas";
            this.CBOX_datas.Size = new System.Drawing.Size(130, 25);
            this.CBOX_datas.TabIndex = 40;
            this.CBOX_datas.Text = "Escolha uma data";
            this.CBOX_datas.Visible = false;
            this.CBOX_datas.SelectedIndexChanged += new System.EventHandler(this.CBOX_datas_SelectedIndexChanged);
            // 
            // FrmCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(490, 368);
            this.Controls.Add(this.LBOX_calendarios);
            this.Controls.Add(this.CBOX_datas);
            this.Controls.Add(this.BTN_validar);
            this.Controls.Add(this.RBTN_outros);
            this.Controls.Add(this.RBTN_info);
            this.Controls.Add(this.RBTN_decremento);
            this.Controls.Add(this.RBTN_incremento);
            this.Controls.Add(this.RBTN_diferenca);
            this.Controls.Add(this.RBTN_calculo);
            this.Controls.Add(this.TXT_dataB);
            this.Controls.Add(this.TXT_dataA);
            this.Controls.Add(this.LBL_dataB);
            this.Controls.Add(this.LBL_dataA);
            this.Controls.Add(this.GBOX_entrada);
            this.Controls.Add(this.GBOX_resultados);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GBOX_incrementos);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de datas";
            this.Load += new System.EventHandler(this.FrmCalc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GBOX_resultados.ResumeLayout(false);
            this.GBOX_entrada.ResumeLayout(false);
            this.GBOX_incrementos.ResumeLayout(false);
            this.GBOX_incrementos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox GBOX_resultados;
        private System.Windows.Forms.Label LBL_resultados;
        private System.Windows.Forms.GroupBox GBOX_entrada;
        private System.Windows.Forms.Label LBL_dataA;
        private System.Windows.Forms.Label LBL_dataB;
        private System.Windows.Forms.Label LBL_entradas;
        private System.Windows.Forms.GroupBox GBOX_incrementos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox TXT_dataA;
        private System.Windows.Forms.MaskedTextBox TXT_dataB;
        private System.Windows.Forms.MaskedTextBox TXT_meses;
        private System.Windows.Forms.MaskedTextBox TXT_semanas;
        private System.Windows.Forms.MaskedTextBox TXT_dias;
        private System.Windows.Forms.RadioButton RBTN_calculo;
        private System.Windows.Forms.RadioButton RBTN_diferenca;
        private System.Windows.Forms.RadioButton RBTN_incremento;
        private System.Windows.Forms.RadioButton RBTN_decremento;
        private System.Windows.Forms.RadioButton RBTN_info;
        private System.Windows.Forms.Button BTN_validar;
        public System.Windows.Forms.ComboBox CBOX_datas;
        public System.Windows.Forms.ListBox LBOX_calendarios;
        public System.Windows.Forms.RadioButton RBTN_outros;
    }
}


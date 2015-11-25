using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_B
{
    public partial class FrmCalc : Form
    {
        DateTime datasistema = System.DateTime.Now;
        TimeSpan ts;
        string resultados = "";
        string resultadosAux = "";
        string resultadosAux2 = "";
        string resultadosAux3 = "";
        int anos, meses, semanas, dias, horas;
        public FrmCalc()
        {
            InitializeComponent();
        }

        private void RBTN_calculo_CheckedChanged(object sender, EventArgs e)
        {
            resultados = "";
            LBL_entradas.Text = "";
            Point pt = new Point(9, 83);
            LBL_dataB.Location = pt;
            TXT_dataB.Visible = true;
            GBOX_entrada.Visible = true;
            GBOX_resultados.Visible = true;
            BTN_validar.Visible = true;
            GBOX_incrementos.Visible = false;
            CBOX_datas.Visible = false;
            LBOX_calendarios.Visible = false;
            TXT_dataA.Text = "";
            TXT_dataB.Text = "";
            TXT_dias.Text = "000";
            TXT_semanas.Text = "00";
            TXT_meses.Text = "00";

            LBL_dataA.Text = "Data nascimento:";
            TXT_dataA.Enabled = true;
            TXT_dataA.Focus();

            LBL_dataB.Text = "";
            TXT_dataB.Enabled = false;
        }
        private void RBTN_diferenca_CheckedChanged(object sender, EventArgs e)
        {
            resultados = "";
            LBL_entradas.Text = "";
            Point pt = new Point(9, 83);
            LBL_dataB.Location = pt;
            TXT_dataB.Visible = true;
            GBOX_entrada.Visible = true;
            GBOX_resultados.Visible = true;
            BTN_validar.Visible = true;
            GBOX_incrementos.Visible = false;
            CBOX_datas.Visible = false;
            LBOX_calendarios.Visible = false;
            TXT_dataA.Text = "";
            TXT_dataB.Text = "";
            TXT_dias.Text = "000";
            TXT_semanas.Text = "00";
            TXT_meses.Text = "00";

            LBL_dataA.Text = "Data A:";
            TXT_dataA.Enabled = true;
            TXT_dataA.Focus();

            LBL_dataB.Text = "Data B:";
            TXT_dataB.Enabled = true;
        }
        private void RBTN_incremento_CheckedChanged(object sender, EventArgs e)
        {
            resultados = "";
            LBL_entradas.Text = "";
            Point pt = new Point(9, 62);
            LBL_dataB.Location = pt;
            TXT_dataB.Visible = false;
            GBOX_entrada.Visible = true;
            GBOX_resultados.Visible = true;
            BTN_validar.Visible = true;
            GBOX_incrementos.Visible = true;
            CBOX_datas.Visible = false;
            LBOX_calendarios.Visible = false;
            TXT_dataA.Text = "";
            TXT_dataB.Text = "";
            TXT_dias.Text = "000";
            TXT_semanas.Text = "00";
            TXT_meses.Text = "00";

            LBL_dataA.Text = "Data:";
            TXT_dataA.Enabled = true;
            TXT_dataA.Focus();

            LBL_dataB.Text = "Incrementar:";
            TXT_dataB.Enabled = true;

            LBL_entradas.Text = "MESES COM 30 DIAS";
        }
        private void RBTN_decremento_CheckedChanged(object sender, EventArgs e)
        {
            resultados = "";
            LBL_entradas.Text = "";
            Point pt = new Point(9, 62);
            LBL_dataB.Location = pt;
            TXT_dataB.Visible = false;
            GBOX_entrada.Visible = true;
            GBOX_resultados.Visible = true;
            BTN_validar.Visible = true;
            GBOX_incrementos.Visible = true;
            CBOX_datas.Visible = false;
            LBOX_calendarios.Visible = false;
            TXT_dataA.Text = "";
            TXT_dataB.Text = "";
            TXT_dias.Text = "000";
            TXT_semanas.Text = "00";
            TXT_meses.Text = "00";

            LBL_dataA.Text = "Data:";
            TXT_dataA.Enabled = true;
            TXT_dataA.Focus();

            LBL_dataB.Text = "Decrementar:";
            TXT_dataB.Enabled = true;

            LBL_entradas.Text = "MESES COM 30 DIAS";
        }
        private void RBTN_info_CheckedChanged(object sender, EventArgs e)
        {
            resultados = "";
            LBL_entradas.Text = "";
            Point pt = new Point(9, 83);
            LBL_dataB.Location = pt;
            TXT_dataB.Visible = true;
            GBOX_entrada.Visible = true;
            GBOX_resultados.Visible = true;
            BTN_validar.Visible = true;
            GBOX_incrementos.Visible = false;
            CBOX_datas.Visible = false;
            LBOX_calendarios.Visible = false;
            TXT_dataA.Text = "";
            TXT_dataB.Text = "";
            TXT_dias.Text = "000";
            TXT_semanas.Text = "00";
            TXT_meses.Text = "00";

            LBL_dataA.Text = "Data:";
            TXT_dataA.Enabled = true;
            TXT_dataA.Focus();

            LBL_dataB.Text = "";
            TXT_dataB.Enabled = false;
        }
        private void RBTN_outros_CheckedChanged(object sender, EventArgs e)
        {
            resultados = "";
            LBL_entradas.Text = "";
            TXT_dataB.Visible = true;
            GBOX_incrementos.Visible = false;
            GBOX_entrada.Visible = false;
            GBOX_resultados.Visible = false;
            BTN_validar.Visible = false;
            TXT_dataA.Text = "";
            TXT_dataB.Text = "";
            TXT_dias.Text = "000";
            TXT_semanas.Text = "00";
            TXT_meses.Text = "00";

            LBL_dataA.Text = "";
            TXT_dataA.Enabled = false;

            LBL_dataB.Text = "";
            TXT_dataB.Enabled = false;

            CBOX_datas.Visible = true;
            LBOX_calendarios.Visible = true;
        }
        private void TXT_dataA_TextChanged(object sender, EventArgs e)
        {
            LBL_resultados.Text = "";

            if (RBTN_calculo.Checked == true)
                resultados = "Data nascimento: " + TXT_dataA.Text;
            if (RBTN_diferenca.Checked == true)
                resultados = "Data A: " + TXT_dataA.Text;
            if (RBTN_incremento.Checked == true)
                resultados = "Data para incrementar: " + TXT_dataA.Text;
            if (RBTN_decremento.Checked == true)
                resultados = "Data para decrementar: " + TXT_dataA.Text;
            if (RBTN_info.Checked == true)
                resultados = "Informações sobre a data: " + TXT_dataA.Text;

            LBL_entradas.Text = resultados;
        }

        private void TXT_dataB_TextChanged(object sender, EventArgs e)
        {
            resultadosAux = "\nData B: " + TXT_dataB.Text;
            LBL_entradas.Text = resultados + resultadosAux;
        }

        private void TXT_dias_Click(object sender, EventArgs e)
        {
            TXT_dias.Text = "";
        }

        private void TXT_dias_TextChanged(object sender, EventArgs e)
        {
            LBL_resultados.Text = "";
            resultadosAux = "\nDias: " + TXT_dias.Text;
            LBL_entradas.Text = resultados + resultadosAux;
        }

        private void TXT_semanas_Click(object sender, EventArgs e)
        {
            TXT_semanas.Text = "";
        }

        private void TXT_semanas_TextChanged(object sender, EventArgs e)
        {
            LBL_resultados.Text = "";
            resultadosAux2 = "\nSemanas: " + TXT_semanas.Text;
            LBL_entradas.Text = resultados + resultadosAux + resultadosAux2;
        }

        private void TXT_meses_Click(object sender, EventArgs e)
        {
            TXT_meses.Text = "";
        }

        private void TXT_meses_TextChanged(object sender, EventArgs e)
        {
            LBL_resultados.Text = "";
            resultadosAux3 = "\nMeses: " + TXT_meses.Text;
            LBL_entradas.Text = resultados + resultadosAux + resultadosAux2 + resultadosAux3;
        }

        private void BTN_validar_Click(object sender, EventArgs e)
        {
            if (RBTN_calculo.Checked == true)
            {
                DateTime datacalculo;
                if (DateTime.TryParse(TXT_dataA.Text, out datacalculo))
                {
                    datacalculo = Convert.ToDateTime(TXT_dataA.Text);
                    ts = datasistema - datacalculo;

                    anos = datasistema.Year - datacalculo.Year;
                    meses = anos * 12;
                    dias = ts.Days;
                    horas = dias * 24;

                    LBL_resultados.Text = "Anos: " + anos + "\nMeses: " + meses + "\nDias: " + dias + "\nHoras: " + horas;
                }
                else
                    MessageBox.Show("Data de nascimento Invalida !\n" + TXT_dataA.Text, "Data Invalida",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
            }
            if (RBTN_diferenca.Checked == true)
            {
                DateTime datadiferencaA, datadiferencaB;
                if (DateTime.TryParse(TXT_dataA.Text, out datadiferencaA))
                {
                    if (DateTime.TryParse(TXT_dataB.Text, out datadiferencaB))
                    {
                        datadiferencaA = Convert.ToDateTime(TXT_dataA.Text);
                        datadiferencaB = Convert.ToDateTime(TXT_dataB.Text);
                        ts = datadiferencaB - datadiferencaA;

                        anos = datadiferencaB.Year - datadiferencaA.Year;
                        if (anos < 0)
                            anos *= -1;

                        meses = anos * 12;

                        dias = ts.Days;
                        if (dias < 0)
                            dias *= -1;

                        semanas = dias / 7;

                        horas = dias * 24;

                        LBL_resultados.Text = "Anos: " + anos + "\nMeses: " + meses + "\n Semanas: " + semanas + "\nDias: " + dias + "\nHoras: " + horas;
                    }
                    else
                        MessageBox.Show("Data B Invalida !\n" + TXT_dataB.Text, "Data Invalida",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Data A Invalida !\n" + TXT_dataA.Text, "Data Invalida",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
            }

            if (RBTN_incremento.Checked == true)
            {
                DateTime datainc;
                if (DateTime.TryParse(TXT_dataA.Text, out datainc))
                {
                    try
                    {
                        int auxdias, auxsemanas, auxmeses;
                        auxdias = int.Parse(TXT_dias.Text);
                        auxsemanas = int.Parse(TXT_semanas.Text);
                        auxsemanas *= 7;
                        auxmeses = int.Parse(TXT_meses.Text);
                        auxmeses *= 30;

                        dias = auxdias + auxsemanas + auxmeses;

                        datainc = datainc.AddDays(dias);

                        LBL_resultados.Text = "Data com incremento:\n" + datainc.ToShortDateString();
                    }
                    catch
                    {
                        MessageBox.Show("Insira valores nos campos em branco !\nMesmo que sejam 0\n", "Campo invalido",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                        
                }
                else
                    MessageBox.Show("Data Invalida !\n" + TXT_dataA.Text, "Data Invalida",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
            }
            if (RBTN_decremento.Checked == true)
            {
                DateTime datadec;
                if (DateTime.TryParse(TXT_dataA.Text, out datadec))
                {
                    int auxdias, auxsemanas, auxmeses;
                    auxdias = int.Parse(TXT_dias.Text);
                    auxsemanas = int.Parse(TXT_semanas.Text);
                    auxsemanas *= 7;
                    auxmeses = int.Parse(TXT_meses.Text);
                    auxmeses *= 30;

                    dias = auxdias + auxsemanas + auxmeses;

                    datadec = datadec.AddDays(-dias);

                    LBL_resultados.Text = "Data com decremento:\n" + datadec.ToShortDateString();
                }
                else
                    MessageBox.Show("Data Invalida !\n" + TXT_dataA.Text, "Data Invalida",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
            }
            if (RBTN_info.Checked == true)
            {
                DateTime datainfo, datainicio; ;
                if (DateTime.TryParse(TXT_dataA.Text, out datainfo))
                {
                    datainfo = Convert.ToDateTime(TXT_dataA.Text);
                    string bissexto = "";
                    string datainicial = "01/01/" + datainfo.Year;
                    datainicio = Convert.ToDateTime(datainicial);
                    ts = datainfo - datainicio;

                    if (DateTime.IsLeapYear(datainfo.Year))
                        bissexto = "Ano bissexto.";
                    else
                        bissexto = "Ano não bissexto.";

                    dias = ts.Days + 1;

                    LBL_resultados.Text = datainfo.ToLongDateString() + "\nDia juliano: " + dias + "\n" + bissexto;
                }
                else
                    MessageBox.Show("Data Invalida !\n" + TXT_dataA.Text, "Data Invalida",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
            }
        }

        private void CBOX_datas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBOX_datas.SelectedIndex == 0)
            {
                LBOX_calendarios.Items.Clear();
                LBOX_calendarios.Items.AddRange(new object[]{"Calendarios",
                                                             "Judaico: 11, Nissan 5750",
                                                             "Islamico: 10, Ramadan 1410",
                                                             "Chines: 1990 - ano do Cavalo"});
            }
            if (CBOX_datas.SelectedIndex == 1)
            {
                LBOX_calendarios.Items.Clear();
                LBOX_calendarios.Items.AddRange(new object[]{"Calendarios",
                                                             "Judaico: 17, Av 5755",
                                                             "Islamico: 16, Rabi al'Awwal 1416",
                                                             "Chines: 1995 - ano do Porco"});
            }
            if (CBOX_datas.SelectedIndex == 2)
            {
                LBOX_calendarios.Items.Clear();
                LBOX_calendarios.Items.AddRange(new object[]{"Calendarios",
                                                             "Judaico: 24, Elul 5771",
                                                             "Islamico: 24, Shawwal 1432",
                                                             "Chines: 2011 - ano da Lebre"});
            }
            if (CBOX_datas.SelectedIndex == 3)
            {
                LBOX_calendarios.Items.Clear();
                LBOX_calendarios.Items.AddRange(new object[]{"Calendarios",
                                                             "Judaico: 10, Sivan 5772",
                                                             "Islamico: 10, Rajab 1433",
                                                             "Chines: 2012 - ano do Dragão"});
            }
            if (CBOX_datas.SelectedIndex == 4)
            {
                LBOX_calendarios.Items.Clear();
                LBOX_calendarios.Items.AddRange(new object[]{"Calendarios",
                                                             "Judaico: 29, Lyar 5775",
                                                             "Islamico: 29, Rajab 1436",
                                                             "Chines: 2015 - ano da Ovelha"});
            }
            if (CBOX_datas.SelectedIndex == 5)
            {
                LBOX_calendarios.Items.Clear();
                LBOX_calendarios.Items.AddRange(new object[]{"Calendarios",
                                                             "Judaico: 28, Kislev 5773",
                                                             "Islamico: 3, Rabi'ath Thani 1440",
                                                             "Chines: 2018 - ano do Cão"});
            }
            if (CBOX_datas.SelectedIndex == 6)
            {
                LBOX_calendarios.Items.Clear();
                LBOX_calendarios.Items.AddRange(new object[]{"Calendarios",
                                                             "Judaico: 7, Tevet 5783",
                                                             "Islamico: 7, Jumada t-Tania 1444",
                                                             "Chines: 2022 - ano do Tigre"});
            }
        }

        private void FrmCalc_Load(object sender, EventArgs e)
        {
            usuarioLogado usuario = new usuarioLogado();
            int status = usuario.getPerfil();
            if (status == 2 || status == 3)
            {
                RBTN_outros.Enabled = false;
                RBTN_outros.Visible = false;

            }
        }
    }
}


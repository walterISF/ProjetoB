using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projeto_B
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.Focus();
            usuarioLogado usuario = new usuarioLogado();
            int perfil = usuario.getPerfil();

            if (perfil == 2 || perfil == 3)
            {
                extraToolStripMenuItem.Visible = false;
            }

        }

        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSenha formSenha = new FrmSenha();
            formSenha.ShowDialog();
        }

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNovoUsuario formNovoUsuario = new FrmNovoUsuario();
            formNovoUsuario.Show();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCalc calculadora = new FrmCalc();
            calculadora.ShowDialog();
        }

        private void bloquearUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBloq frmBloquear = new FrmBloq();
            frmBloquear.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Compra_Click(object sender, EventArgs e)
        {
            TXT_1.ReadOnly = false; TXT_2.ReadOnly = false; TXT_3.ReadOnly = false;
            TXT_4.ReadOnly = false; TXT_5.ReadOnly = false; TXT_6.ReadOnly = false;
            LBL_1.Text = "Codigo";
            LBL_2.Text = "Nome";
            LBL_3.Text = "Preço";
            LBL_4.Text = "Quantidade";
            LBL_5.Text = "Seção";
            LBL_6.Text = "Descrição";

            Coluna1.Text = "Codigo";
            Coluna2.Text = "Nome";
            Coluna3.Text = "Preço";
            Coluna4.Text = "Quantidade";
            Coluna5.Text = "Seção";
            Coluna6.Text = "Descrição";
            try { 
                    string[] Tudo = System.IO.File.ReadAllLines(@"C:\temp\arqProd.dat");
                    int numeroLinhas = System.IO.File.ReadAllLines(@"C:\temp\arqProd.dat").Length;
                    string linha;
                    for (int i = 0; i < numeroLinhas; i++)
                    {
                        linha = Tudo[i];

                        string[] colunas = linha.Split(';');
                        LB_registros.Items.Add(colunas[0], i);
                        LB_registros.Items[i].SubItems.Add(colunas[1]);
                        LB_registros.Items[i].SubItems.Add(colunas[2]);
                        LB_registros.Items[i].SubItems.Add(colunas[3]);
                        LB_registros.Items[i].SubItems.Add(colunas[4]);
                        LB_registros.Items[i].SubItems.Add(colunas[5]);
                    }
            }
            catch
            {

            }

        }

        private void BTN_addProduto_Click(object sender, EventArgs e)
        {
            TXT_1.ReadOnly = false; TXT_2.ReadOnly = false; TXT_3.ReadOnly = false;
            TXT_4.ReadOnly = false; TXT_5.ReadOnly = false; TXT_6.ReadOnly = false;
            LBL_1.Text = "Codigo";
            LBL_2.Text = "Codigo do Produto";
            LBL_3.Text = "Codigo do Cliente";
            LBL_4.Text = "Valor da Venda";
            LBL_5.Text = "Data da Venda";
            LBL_6.Text = "Descrição";


            Coluna1.Text = "Codigo";
            Coluna2.Text = "Codigo do Produto";
            Coluna3.Text = "Codigo do Cliente";
            Coluna4.Text = "Valor da Venda";
            Coluna5.Text = "Data da Venda";
            Coluna6.Text = "Descrição";

            try
            {
                string[] Tudo = System.IO.File.ReadAllLines(@"C:\temp\arqProd.dat");
                int numeroLinhas = System.IO.File.ReadAllLines(@"C:\temp\arqProd.dat").Length;
                string linha;
                for (int i = 0; i < numeroLinhas; i++)
                {
                    linha = Tudo[i];

                    string[] colunas = linha.Split(';');
                    LB_registros.Items.Add(colunas[0], i);
                    LB_registros.Items[i].SubItems.Add(colunas[1]);
                    LB_registros.Items[i].SubItems.Add(colunas[2]);
                    LB_registros.Items[i].SubItems.Add(colunas[3]);
                    LB_registros.Items[i].SubItems.Add(colunas[4]);
                    LB_registros.Items[i].SubItems.Add(colunas[5]);
                }
            }
            catch
            {

            }
        }

        private void BTN_addCliente_Click(object sender, EventArgs e)
        {
            LBL_1.Text = "Codigo";
            LBL_2.Text = "Nome";
            LBL_3.Text = "Endereço";
            LBL_4.Text = "Telefone";
            LBL_5.Text = "CPF";
            LBL_6.Text = "Descrição";
        }

        private void TXT_TextChanged(object sender, EventArgs e)
        {
            if (TXT_1.Text != "" && TXT_2.Text != "" && TXT_3.Text != "" && TXT_4.Text != "" && TXT_5.Text != "" && TXT_6.Text != "")
            {
                BTN_incluir.BackColor = SystemColors.Control;
                GPB_incluir.BackColor = SystemColors.Control;
                BTN_incluir.Enabled = true;
            }
            
            
        }

        private void BTN_incluir_Click(object sender, EventArgs e)
        {
            try
            {
                LB_registros.Items.Clear();
                produtos add = new produtos();
                add.cod = int.Parse(TXT_1.Text);
                add.nome = TXT_2.Text;
                add.valor = float.Parse(TXT_3.Text);
                add.quant = int.Parse(TXT_4.Text);
                add.secao = TXT_5.Text;
                add.descricao = TXT_6.Text;
                add.criarProd(add);
                TXT_1.Clear(); TXT_2.Clear(); TXT_3.Clear();
                TXT_4.Clear(); TXT_5.Clear(); TXT_6.Clear();

                string[] Tudo = System.IO.File.ReadAllLines(@"C:\temp\arqProd.dat");
                int numeroLinhas = System.IO.File.ReadAllLines(@"C:\temp\arqProd.dat").Length;
                string linha;
                for (int i = 0; i < numeroLinhas; i++)
                {
                    linha = Tudo[i];

                    string[] colunas = linha.Split(';');
                    if (colunas[i] != "")
                    {
                        LB_registros.Items.Add(colunas[0], i);
                        LB_registros.Items[i].SubItems.Add(colunas[1]);
                        LB_registros.Items[i].SubItems.Add(colunas[2]);
                        LB_registros.Items[i].SubItems.Add(colunas[3]);
                        LB_registros.Items[i].SubItems.Add(colunas[4]);
                        LB_registros.Items[i].SubItems.Add(colunas[5]);
                    }
                    else
                    {


                    }
                }
            }
            catch
            {
                MessageBox.Show("Digite Valores correspondentes aos campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void LB_registros_MouseClick(object sender, MouseEventArgs e)
        {
            TXT_1.ReadOnly = true;
            BTN_alterar.Enabled = true;
            BTN_excluir.Enabled = true;
            BTN_excluir.BackColor = SystemColors.Control;
            BTN_alterar.BackColor = SystemColors.Control;
            GPB_alterar.BackColor = SystemColors.Control;
            GPB_excluir.BackColor = SystemColors.Control;

            if (LB_registros.SelectedItems.Count != 0)
            {
                if (LB_registros.SelectedItems[0].Selected)
                {
                    TXT_1.Text = LB_registros.FocusedItem.SubItems[0].Text;
                    TXT_2.Text = LB_registros.FocusedItem.SubItems[1].Text;
                    TXT_3.Text = LB_registros.FocusedItem.SubItems[2].Text;
                    TXT_4.Text = LB_registros.FocusedItem.SubItems[3].Text;
                    TXT_5.Text = LB_registros.FocusedItem.SubItems[4].Text;
                    TXT_6.Text = LB_registros.FocusedItem.SubItems[5].Text;
                }
            }
            BTN_incluir.Enabled = false;
            BTN_incluir.BackColor = SystemColors.ControlLight;
            GPB_incluir.BackColor = SystemColors.ControlLight;
        }

        private void LB_registros_ColumnClick(object sender, ColumnClickEventArgs e)
        {

        }

        private void BTN_excluir_Click(object sender, EventArgs e)
        {
            LB_registros.Items.Clear();
            produtos remover = new produtos();
            int codigo = int.Parse(TXT_1.Text);
            remover.excluirProd(codigo);
            string[] Tudo = System.IO.File.ReadAllLines(@"C:\temp\arqProd.dat");
            int numeroLinhas = System.IO.File.ReadAllLines(@"C:\temp\arqProd.dat").Length;
            string linha;
            if (numeroLinhas != 0)
            {
                for (int i = 0; i < numeroLinhas; i++)
                {
                    linha = Tudo[i];

                    string[] colunas = linha.Split(';');
                    if (colunas[i] != "")
                    {
                        
                        LB_registros.Items.Add(colunas[0], i);
                        LB_registros.Items[i].SubItems.Add(colunas[1]);
                        LB_registros.Items[i].SubItems.Add(colunas[2]);
                        LB_registros.Items[i].SubItems.Add(colunas[3]);
                        LB_registros.Items[i].SubItems.Add(colunas[4]);
                        LB_registros.Items[i].SubItems.Add(colunas[5]);
                    }
                    else
                    {


                    }
                }
            }
            else
            {
                LB_registros.Items.Clear();
                TXT_1.Clear(); TXT_2.Clear(); TXT_3.Clear();
                TXT_4.Clear(); TXT_5.Clear(); TXT_6.Clear();
                TXT_1.ReadOnly = true;
            }
        }

        private void BTN_alterar_Click(object sender, EventArgs e)
        {
            LB_registros.Items.Clear();
            produtos alterar = new produtos();
            alterar.cod = int.Parse(TXT_1.Text);
            
            /* METODO DO ALLAN
            string[] Tudo = System.IO.File.ReadAllLines(@"C:\temp\arqProd.dat");
            int numeroLinhas = System.IO.File.ReadAllLines(@"C:\temp\arqProd.dat").Length;
            
            string linha;

            for (int i = 0; i < numeroLinhas; i++)
            {
                linha = Tudo[i];
                string[] colunas = linha.Split(';');
               if (colunas[0] == alterar.cod.ToString())
               {
                   alterar.alterarProduto(alterar.cod,i,linha);
                   if (colunas[i] != "")
                   {

                       LB_registros.Items.Add(colunas[0], i);
                       LB_registros.Items[i].SubItems.Add(colunas[1]);
                       LB_registros.Items[i].SubItems.Add(colunas[2]);
                       LB_registros.Items[i].SubItems.Add(colunas[3]);
                       LB_registros.Items[i].SubItems.Add(colunas[4]);
                       LB_registros.Items[i].SubItems.Add(colunas[5]);
                   }
                   else
                   {


                   }
               }


            }
            TXT_1.Clear(); TXT_2.Clear(); TXT_3.Clear();
            TXT_4.Clear(); TXT_5.Clear(); TXT_6.Clear();
            TXT_1.ReadOnly = true;*/

            /* MEU METODO*/
            string[] Tudo = System.IO.File.ReadAllLines(@"C:\temp\arqProd.dat");
            int numeroLinhas = System.IO.File.ReadAllLines(@"C:\temp\arqProd.dat").Length;
            string linha,novaLinha;

            for (int i = 0; i < numeroLinhas; i++)
            {
                linha = Tudo[i];
                string[] colunas = linha.Split(';');
                if (colunas[0] == alterar.cod.ToString())
                {
                    alterar.cod = int.Parse(TXT_1.Text);
                    alterar.nome = TXT_2.Text;
                    alterar.valor = float.Parse(TXT_3.Text);
                    alterar.quant = int.Parse(TXT_4.Text);
                    alterar.secao = TXT_5.Text;
                    alterar.descricao = TXT_6.Text;
                    novaLinha = alterar.cod + ";" + alterar.nome + ";" + alterar.valor * 1.00 + ";" + alterar.quant + ";" + alterar.secao + ";" + alterar.descricao;

                    alterar.excluirProd(alterar.cod);
                    alterar.criarProd(alterar);

                }

            }
            string[] TudoNovo = System.IO.File.ReadAllLines(@"C:\temp\arqProd.dat");
            for (int i = 0; i < numeroLinhas; i++)
            {
                linha = TudoNovo[i];

                string[] colunas = linha.Split(';');
                if (colunas[i] != "")
                {

                    LB_registros.Items.Add(colunas[0], i);
                    LB_registros.Items[i].SubItems.Add(colunas[1]);
                    LB_registros.Items[i].SubItems.Add(colunas[2]);
                    LB_registros.Items[i].SubItems.Add(colunas[3]);
                    LB_registros.Items[i].SubItems.Add(colunas[4]);
                    LB_registros.Items[i].SubItems.Add(colunas[5]);
                }
                else
                {


                }
                TXT_1.Clear(); TXT_2.Clear(); TXT_3.Clear();
                TXT_4.Clear(); TXT_5.Clear(); TXT_6.Clear();
                TXT_1.ReadOnly = false;
            }

        }


    }
}

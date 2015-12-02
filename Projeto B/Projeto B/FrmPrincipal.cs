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
        int flag = 0;
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
            flag = 2;
            LBL_1.Text = "Código Venda";
            LBL_2.Text = "Valor";
            LBL_3.Text = "Código do cliente";
            LBL_4.Text = "Código do Produto";
            LBL_5.Text = "Quantidade";
            LBL_6.Text = "Descrição";
            LB_registros.Items.Clear();
            TXT_2.Enabled = false;
            TXT_3.ReadOnly = false;
            TXT_4.ReadOnly = false;
            TXT_5.ReadOnly = false;
            TXT_6.ReadOnly = false;
            TXT_2.Enabled = true;
            BTN_incluir.Enabled = true;
            BTN_alterar.Enabled = true;
            BTN_excluir.Enabled = true;
            Coluna1.Text = "Código da venda";
            Coluna2.Text = "Valor";
            Coluna3.Text = "Cliente";
            Coluna4.Text = "Produto";
            Coluna5.Text = "Quantidade";
            Coluna6.Text = "Descrição";
        }

        private void BTN_addProduto_Click(object sender, EventArgs e)
        {
            flag = 1;
        }

        private void BTN_addCliente_Click(object sender, EventArgs e)
        {
            flag = 3;
            LBL_1.Text = "Codigo";
            LBL_2.Text = "Nome";
            LBL_3.Text = "Endereço";
            LBL_4.Text = "Telefone";
            LBL_5.Text = "CPF";
            LBL_6.Text = "Descrição";
            LB_registros.Items.Clear();
            TXT_2.ReadOnly = false;
            TXT_3.ReadOnly = false;
            TXT_4.ReadOnly = false;
            TXT_5.ReadOnly = false;
            TXT_6.ReadOnly = false;
            TXT_2.Enabled = true;
            BTN_incluir.Enabled = true;
            BTN_alterar.Enabled = true;
            BTN_excluir.Enabled = true;
            Coluna1.Text = "Codigo";
            Coluna2.Text = "Nome";
            Coluna3.Text = "Endereço";
            Coluna4.Text = "Telefone";
            Coluna5.Text = "CPF";
            Coluna6.Text = "Descrição";

            clientes cod = new clientes();

            string[] tudo = cod.lerTodosClientes().Split('\n');

            for (int i = 0; i < tudo.Length - 1; i++)
            {
                string[] linha = tudo[i].Split(';');
                LB_registros.Items.Add(linha[0], i);
                LB_registros.Items[i].SubItems.Add(linha[2]);
                LB_registros.Items[i].SubItems.Add(linha[4]);
                LB_registros.Items[i].SubItems.Add(linha[3]);
                LB_registros.Items[i].SubItems.Add(linha[1]);
                LB_registros.Items[i].SubItems.Add(linha[5]);
            }

            
            string ult = cod.lerUltimoCliente();
            if (ult == "")
                TXT_1.Text = "1";
            else
            {
                int ultimo = int.Parse(ult);
                TXT_1.Text = (ultimo + 1).ToString();
            }
        }

        private void TXT_TextChanged(object sender, EventArgs e)
        {
            if (TXT_2.Text != "" && TXT_3.Text != "" && TXT_4.Text != "" && TXT_5.Text != "" && TXT_6.Text != "")
            {
                BTN_incluir.BackColor = SystemColors.Control;
                GPB_incluir.BackColor = SystemColors.Control;
                BTN_incluir.Enabled = true;
            }            
        }

        private void BTN_incluir_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                
            }
            //--------------------------------------------------------------------------------------
            if (flag == 2)
            {

            }
            //--------------------------------------------------------------------------------------
            if (flag == 3)
            {
                clientes cliente = new clientes();
                LB_registros.Items.Clear();

                cliente.cod = int.Parse(TXT_1.Text);
                cliente.cpf = long.Parse(TXT_5.Text);
                cliente.nome = TXT_2.Text;
                cliente.telefone = TXT_4.Text;
                cliente.endereco = TXT_3.Text;
                cliente.descricao = TXT_6.Text;

                cliente.criarCliente(cliente);
                int ult = int.Parse(cliente.lerUltimoCliente());
                ult += 1;
                TXT_1.Text = ult.ToString();

                string[] tudo = cliente.lerTodosClientes().Split('\n');

                for (int i = 0; i < tudo.Length - 1; i++)
                {
                    string[] linha = tudo[i].Split(';');
                    LB_registros.Items.Add(linha[0],i);
                    LB_registros.Items[i].SubItems.Add(linha[2]);
                    LB_registros.Items[i].SubItems.Add(linha[4]);
                    LB_registros.Items[i].SubItems.Add(linha[3]);
                    LB_registros.Items[i].SubItems.Add(linha[1]);
                    LB_registros.Items[i].SubItems.Add(linha[5]);
                }
                TXT_2.Text = "";
                TXT_3.Text = "";
                TXT_4.Text = "";
                TXT_5.Text = "";
                TXT_6.Text = "";
            }
            //-----------------------------------------------------------------------------------------------------
        }        

        private void BTN_alterar_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                produtos alt = new produtos();

                LB_registros.Items.Clear();

                if (MessageBox.Show("Confirma alterações.", "Alterando...",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string[] altCliente = alt.lerProd(int.Parse(TXT_1.Text)).Split(';');
                    if (altCliente[1] != TXT_4.Text)
                        alt.alterarProduto(int.Parse(TXT_1.Text), 1, TXT_4.Text);
                    if (altCliente[2] != TXT_2.Text)
                        alt.alterarProduto(int.Parse(TXT_1.Text), 2, TXT_2.Text);
                    if (altCliente[3] != TXT_3.Text)
                        alt.alterarProduto(int.Parse(TXT_1.Text), 3, TXT_3.Text);
                    if (altCliente[4] != TXT_5.Text)
                        alt.alterarProduto(int.Parse(TXT_1.Text), 4, TXT_5.Text);
                    if (altCliente[5] != TXT_6.Text)
                        alt.alterarProduto(int.Parse(TXT_1.Text), 5, TXT_6.Text);
                }
                
                string[] tudo = alt.lerTodosProd().Split('\n');

                for (int i = 0; i < tudo.Length - 1; i++)
                {
                    string[] linha = tudo[i].Split(';');
                    LB_registros.Items.Add(linha[0], i);
                    LB_registros.Items[i].SubItems.Add(linha[2]);
                    LB_registros.Items[i].SubItems.Add(linha[4]);
                    LB_registros.Items[i].SubItems.Add(linha[3]);
                    LB_registros.Items[i].SubItems.Add(linha[1]);
                    LB_registros.Items[i].SubItems.Add(linha[5]);
                }
                int ult = int.Parse(alt.lerUltimoProd());
                ult += 1;
                TXT_1.Text = ult.ToString();

                TXT_2.Text = "";
                TXT_3.Text = "";
                TXT_4.Text = "";
                TXT_5.Text = "";
                TXT_6.Text = "";   
            }
            //-----------------------------------------------------------------------------
            if (flag == 2)
            {
                vendas alt = new vendas();

                LB_registros.Items.Clear();

                if (MessageBox.Show("Confirma alterações.", "Alterando...",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string[] altCliente = alt.lerVenda(int.Parse(TXT_1.Text)).Split(';');
                    if (altCliente[1] != TXT_2.Text)
                        alt.alterarVenda(int.Parse(TXT_1.Text), 1, TXT_2.Text);
                    if (altCliente[2] != TXT_3.Text)
                        alt.alterarVenda(int.Parse(TXT_1.Text), 2, TXT_3.Text);
                    if (altCliente[3] != TXT_4.Text)
                        alt.alterarVenda(int.Parse(TXT_1.Text), 3, TXT_4.Text);
                    if (altCliente[4] != TXT_5.Text)
                        alt.alterarVenda(int.Parse(TXT_1.Text), 4, TXT_5.Text);
                    if (altCliente[5] != TXT_6.Text)
                        alt.alterarVenda(int.Parse(TXT_1.Text), 5, TXT_6.Text);
                }
                
                string[] tudo = alt.lerTodosVendas().Split('\n');

                for (int i = 0; i < tudo.Length - 1; i++)
                {
                    string[] linha = tudo[i].Split(';');
                    LB_registros.Items.Add(linha[0], i);
                    LB_registros.Items[i].SubItems.Add(linha[2]);
                    LB_registros.Items[i].SubItems.Add(linha[4]);
                    LB_registros.Items[i].SubItems.Add(linha[3]);
                    LB_registros.Items[i].SubItems.Add(linha[1]);
                    LB_registros.Items[i].SubItems.Add(linha[5]);
                }
                int ult = int.Parse(alt.lerUltimoVenda());
                ult += 1;
                TXT_1.Text = ult.ToString();

                TXT_2.Text = "";
                TXT_3.Text = "";
                TXT_4.Text = "";
                TXT_5.Text = "";
                TXT_6.Text = "";
            }
            //-----------------------------------------------------------------------------
            if (flag == 3)
            {                 
                clientes alt = new clientes();

                LB_registros.Items.Clear();

                if(MessageBox.Show("Confirma alterações.","Alterando...",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string[] altCliente = alt.lerCliente(int.Parse(TXT_1.Text)).Split(';');
                    if (altCliente[1] != TXT_5.Text)
                        alt.alterarCliente(int.Parse(TXT_1.Text), 1, TXT_5.Text);
                    if (altCliente[2] != TXT_2.Text)
                        alt.alterarCliente(int.Parse(TXT_1.Text), 2, TXT_2.Text);
                    if (altCliente[3] != TXT_4.Text)
                        alt.alterarCliente(int.Parse(TXT_1.Text), 3, TXT_4.Text);
                    if (altCliente[4] != TXT_3.Text)
                        alt.alterarCliente(int.Parse(TXT_1.Text), 4, TXT_3.Text);
                    if (altCliente[5] != TXT_6.Text)
                        alt.alterarCliente(int.Parse(TXT_1.Text), 5, TXT_6.Text);
                }
                string[] tudo = alt.lerTodosClientes().Split('\n');

                for (int i = 0; i < tudo.Length - 1; i++)
                {
                    string[] linha = tudo[i].Split(';');
                    LB_registros.Items.Add(linha[0],i);
                    LB_registros.Items[i].SubItems.Add(linha[2]);
                    LB_registros.Items[i].SubItems.Add(linha[4]);
                    LB_registros.Items[i].SubItems.Add(linha[3]);
                    LB_registros.Items[i].SubItems.Add(linha[1]);
                    LB_registros.Items[i].SubItems.Add(linha[5]);
                }
                int ult = int.Parse(alt.lerUltimoCliente());
                ult += 1;
                TXT_1.Text = ult.ToString();

                TXT_2.Text = "";
                TXT_3.Text = "";
                TXT_4.Text = "";
                TXT_5.Text = "";
                TXT_6.Text = "";
            }
            //------------------------------------------------------------------------------------
        }

        private void BTN_excluir_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                produtos exc = new produtos();

                if (MessageBox.Show("Confirma a exclusão", "excluindo...",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    exc.excluirProd(int.Parse(TXT_1.Text));

                    LB_registros.Items.Clear();
                    string[] tudo = exc.lerTodosProd().Split('\n');

                    for (int i = 0; i < tudo.Length - 1; i++)
                    {
                        string[] linha = tudo[i].Split(';');
                        LB_registros.Items.Add(linha[0], i);
                        LB_registros.Items[i].SubItems.Add(linha[2]);
                        LB_registros.Items[i].SubItems.Add(linha[4]);
                        LB_registros.Items[i].SubItems.Add(linha[3]);
                        LB_registros.Items[i].SubItems.Add(linha[1]);
                        LB_registros.Items[i].SubItems.Add(linha[5]);
                    }
                    int ult;
                    try { ult = int.Parse(exc.lerUltimoProd()); }
                    catch { ult = 0; }
                    ult += 1;
                    TXT_1.Text = ult.ToString();

                    TXT_2.Text = "";
                    TXT_3.Text = "";
                    TXT_4.Text = "";
                    TXT_5.Text = "";
                    TXT_6.Text = "";
                }
            }
            if (flag == 2)
            {
                vendas exc = new vendas();

                if (MessageBox.Show("Confirma a exclusão", "excluindo...",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    exc.excluirVenda(int.Parse(TXT_1.Text));

                    LB_registros.Items.Clear();
                    string[] tudo = exc.lerTodosVendas().Split('\n');

                    for (int i = 0; i < tudo.Length - 1; i++)
                    {
                        string[] linha = tudo[i].Split(';');
                        LB_registros.Items.Add(linha[0], i);
                        LB_registros.Items[i].SubItems.Add(linha[2]);
                        LB_registros.Items[i].SubItems.Add(linha[4]);
                        LB_registros.Items[i].SubItems.Add(linha[3]);
                        LB_registros.Items[i].SubItems.Add(linha[1]);
                        LB_registros.Items[i].SubItems.Add(linha[5]);
                    }
                    int ult;
                    try { ult = int.Parse(exc.lerUltimoVenda()); }
                    catch { ult = 0; }
                    ult += 1;
                    TXT_1.Text = ult.ToString();

                    TXT_2.Text = "";
                    TXT_3.Text = "";
                    TXT_4.Text = "";
                    TXT_5.Text = "";
                    TXT_6.Text = "";
                }
            }
            if (flag == 3)
            {
                clientes exc = new clientes();

                if(MessageBox.Show("Confirma a exclusão","excluindo...",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    exc.excluirCliente(int.Parse(TXT_1.Text));

                    LB_registros.Items.Clear();
                    string[] tudo = exc.lerTodosClientes().Split('\n');
                    
                    for (int i = 0; i < tudo.Length - 1; i++)
                    {
                        string[] linha = tudo[i].Split(';');
                        LB_registros.Items.Add(linha[0], i);
                        LB_registros.Items[i].SubItems.Add(linha[2]);
                        LB_registros.Items[i].SubItems.Add(linha[4]);
                        LB_registros.Items[i].SubItems.Add(linha[3]);
                        LB_registros.Items[i].SubItems.Add(linha[1]);
                        LB_registros.Items[i].SubItems.Add(linha[5]);
                    }
                    int ult;
                    try { ult = int.Parse(exc.lerUltimoCliente()); }
                    catch { ult = 0; }
                    ult += 1;
                    TXT_1.Text = ult.ToString();

                    TXT_2.Text = "";
                    TXT_3.Text = "";
                    TXT_4.Text = "";
                    TXT_5.Text = "";
                    TXT_6.Text = "";
                }
            }
        }

        private void LB_registros_MouseClick(object sender, MouseEventArgs e)
        {

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

        private void TXT_3_Leave(object sender, EventArgs e)
        {
            if (flag == 2)
            {
                clientes client = new clientes();

                string[] cli = client.lerCliente(int.Parse(TXT_3.Text)).Split(';');

                if (cli[0] != "" && cli != null)
                    TXT_3.Text = cli[2];
                else
                {
                    MessageBox.Show("Cliente não encontrado", "Erro",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    TXT_3.Text = "";
                }
            }
        }

        private void TXT_4_Leave(object sender, EventArgs e)
        {
            if (flag == 2)
            {
                produtos prod = new produtos();

                string[] produto = prod.lerProd(int.Parse(TXT_4.Text)).Split(';');

                if (produto[0] != "" && produto != null)
                    TXT_3.Text = produto[2];
                else
                {
                    MessageBox.Show("Produto não encontrado", "Erro",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    TXT_4.Text = "";
                }
            }
        }
        //---FIM------------------------------------------------------------------------------
    }
}

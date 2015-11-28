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

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

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
            LBL_1.Text = "Codigo";
            LBL_2.Text = "Nome";
            LBL_3.Text = "Preço";
            LBL_4.Text = "Quantidade";
            LBL_5.Text = "Seção";
            LBL_6.Text = "Descrição";


            LB_registros.Items.AddRange(new object[] {
            "Item 1, column 1",
            "Item 2, column 1",
            "Item 3, column 1",
            "Item 4, column 1",
            "Item 5, column 1",
            "Item 1, column 2",
            "Item 2, column 2",
            "Item 3, column 2",
            "Item 1, column 2",
            "Item 2, column 2",
            "Item 3, column 2"});
        }

        private void BTN_addProduto_Click(object sender, EventArgs e)
        {
            LBL_1.Text = "Codigo";
            LBL_2.Text = "Codigo do Produto";
            LBL_3.Text = "Codigo do Cliente";
            LBL_4.Text = "Valor da Venda";
            LBL_5.Text = "Data da Venda";
            LBL_6.Text = "Descrição";
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
                BTN_alterar.BackColor = SystemColors.Control;
                GPB_incluir.BackColor = SystemColors.Control;
            }

            
                BTN_excluir.BackColor = SystemColors.Control;
                BTN_incluir.BackColor = SystemColors.Control;
            
            
        }


    }
}

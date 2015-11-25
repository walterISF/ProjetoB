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
            int status = usuario.getPerfil();

            if (status == 2 || status == 3)
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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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

    }
}

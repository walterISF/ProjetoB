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
    public partial class FrmNovoUsuario : Form
    {
        usuarios user = new usuarios();
        
        public FrmNovoUsuario()
        {
            InitializeComponent();
        }

        private void FrmNovoUsuario_Load(object sender, EventArgs e)
        {
            DateTime dataAtual = DateTime.Now;               
            int codUser = int.Parse(user.lerUltimoUser(0))+1;
            LBL_codUsuario.Text = codUser.ToString();
            user.cod = int.Parse(LBL_codUsuario.Text);
            user.pswAtual = "Ini123";
            user.pswAnterior = "";
            user.pswAlteracao = dataAtual.ToString();
            user.status = 3;
        }

        private void FrmNovoUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Cancela a inclusão de novo usuario ?", "Cancelar...",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void BTN_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_salvar_Click(object sender, EventArgs e)
        {
            user.nome = TXT_nome.Text;
            user.nascimento = TXT_nascimento.Text;
            if (CBOX_perfil.SelectedIndex == 0)
                user.perfil = 1;
            if (CBOX_perfil.SelectedIndex == 1)
                user.perfil = 2;
            if (CBOX_perfil.SelectedIndex == 2)
                user.perfil = 3;
            user.criarUsuario(user);            

            MessageBox.Show("Novo Usuario criado com sucesso!\nSenha inicial: Ini123", "Sucesso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
           
            int codUser = int.Parse(user.lerUltimoUser(0)) + 1;
            LBL_codUsuario.Text = codUser.ToString();
            TXT_nome.Text = "";
            TXT_nascimento.Text = "";
            CBOX_perfil.SelectedIndex = 3;            
        }
    }
}

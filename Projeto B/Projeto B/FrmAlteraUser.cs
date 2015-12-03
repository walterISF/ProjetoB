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
    public partial class FrmAlteraUser : Form
    {
        public FrmAlteraUser()
        {
            InitializeComponent();
        }

        private void FrmAlteraUser_Load(object sender, EventArgs e)
        {
            TXT_codigo.Focus();
            usuarioLogado usuario = new usuarioLogado();
            int perfil = usuario.getPerfil();
            if (perfil == 3)
            {
                CBOX_perfil.Visible = false;
                label4.Visible = false;
            }
        }

        private void BTN_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TXT_codigo_Leave(object sender, EventArgs e)
        {
            usuarios user = new usuarios();
            if (TXT_codigo.Text != "")
            {
                if (user.lerUsuario(int.Parse(TXT_codigo.Text)) == "")
                {
                    MessageBox.Show("Usuario invalido");
                    TXT_codigo.Text = "";
                }
                else
                {
                    string[] altUser = user.lerUsuario(int.Parse(TXT_codigo.Text)).Split(';');
                    TXT_nome.Text = altUser[3];
                    TXT_nome.Enabled = true;
                    TXT_nascimento.Text = altUser[4];
                    TXT_nascimento.Enabled = true;
                    if (altUser[2] == "1")
                        CBOX_perfil.SelectedIndex = 0;
                    if (altUser[2] == "2")
                        CBOX_perfil.SelectedIndex = 1;
                    if (altUser[2] == "3")
                        CBOX_perfil.SelectedIndex = 2;
                    CBOX_perfil.Enabled = true;
                }
            }
        }

        private void BTN_alterar_Click(object sender, EventArgs e)
        {
            usuarios user = new usuarios();
            
            if(MessageBox.Show("Confirma alterações.","Alterando...",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string[] altUser = user.lerUsuario(int.Parse(TXT_codigo.Text)).Split(';');
                if (TXT_nome.Text != altUser[3])
                    user.alterarUsuario(int.Parse(TXT_codigo.Text), 3, TXT_nome.Text);
                if (TXT_nascimento.Text != altUser[4])
                    user.alterarUsuario(int.Parse(TXT_codigo.Text), 4, TXT_nascimento.Text);

                if (CBOX_perfil.SelectedIndex == 0)
                    user.alterarUsuario(int.Parse(TXT_codigo.Text), 2, "1");
                if (CBOX_perfil.SelectedIndex == 1)
                    user.alterarUsuario(int.Parse(TXT_codigo.Text), 2, "2");
                if (CBOX_perfil.SelectedIndex == 2)
                    user.alterarUsuario(int.Parse(TXT_codigo.Text), 2, "3");
                if (CBOX_perfil.SelectedIndex == 3)
                    MessageBox.Show("Perfil de usuario invalido.");

                MessageBox.Show("Alteração efetuada com sucesso", "Alterado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                TXT_codigo.Text = "";
                TXT_nome.Text = "";
                TXT_nome.Enabled = false;
                TXT_nascimento.Text = "";
                TXT_nascimento.Enabled = false;
                CBOX_perfil.SelectedIndex = 3;
                CBOX_perfil.Enabled = false;
                TXT_codigo.Focus();
            }
            else
            {
                TXT_codigo.Text = "";
                TXT_nome.Text = "";
                TXT_nome.Enabled = false;
                TXT_nascimento.Text = "";
                TXT_nascimento.Enabled = false;
                CBOX_perfil.SelectedIndex = 3;
                CBOX_perfil.Enabled = false;
                TXT_codigo.Focus();
            }
        }        
    }
}

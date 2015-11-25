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
    public partial class FrmLogin : Form
    {
        usuarioLogado usrLogado = new usuarioLogado();
        usuarios usuario = new usuarios();

        public FrmLogin()
        {
            InitializeComponent();
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            TXT_senha.Focus();
        }

        private void BTN_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_login_Click(object sender, EventArgs e)
        {
            LBL_usuario.Text = "";
            LBL_senha.Text = "";
            string aux = usuario.lerUsuario(int.Parse(TXT_usuario.Text));
            if(aux == "")
            {
                LBL_usuario.Text = "Usuario Invalido";
                TXT_usuario.Text = "";
            }
            else
            {
                string[] userInfo = aux.Split(';'); 
                if (TXT_senha.Text == userInfo[5])
                {
                    FrmPrincipal principal = new FrmPrincipal();
                    FrmSenha alterarSenha = new FrmSenha();
                    DateTime dataAtual = DateTime.Now;
                    DateTime dataAlteracao = Convert.ToDateTime(userInfo[7]);
                    dataAlteracao = dataAlteracao.AddDays(90);
                    
                    usrLogado.setLogin(int.Parse(userInfo[0]));
                    usrLogado.setStatus(int.Parse(userInfo[1]));
                    usrLogado.setPerfil(int.Parse(userInfo[2]));
                    usrLogado.setName(userInfo[3]);                    
                    usrLogado.setBirth(userInfo[4]);
                    usrLogado.setPswAtual(userInfo[5]);
                    usrLogado.setPswAnterior(userInfo[6]);
                    usrLogado.setPswData(userInfo[7]);
                    if (int.Parse(userInfo[1]) == 2)
                        MessageBox.Show("Usuario bloqueado!", "Bloqueado",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    else
                        if (int.Parse(userInfo[1]) == 3)
                            alterarSenha.ShowDialog();
                        else
                            if (dataAlteracao < dataAtual)
                                if (MessageBox.Show("A senha não é alterada a mais de 90 dias!\nDeseja alterar.", "Alterar senha",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question) == DialogResult.Yes)
                                    alterarSenha.ShowDialog();
                                else
                                    principal.Show();
                            else
                                principal.Show();

                    this.Close();
                }
                else
                {
                    LBL_senha.Text = "Senha Invalida";
                    TXT_senha.Text = "";
                }                 
            }
        }
    }
}

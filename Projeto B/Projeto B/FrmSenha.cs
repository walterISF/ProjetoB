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
    public partial class FrmSenha : Form
    {
        usuarioLogado usrLogin = new usuarioLogado();
        usuarios usuario = new usuarios();

        public FrmSenha()
        {
            InitializeComponent();
        }

        private void FrmSenha_Load(object sender, EventArgs e)
        {
            LBL_usuario.Text = usrLogin.getLogin().ToString();
        }

        private void TXT_nsenha_TextChanged(object sender, EventArgs e)
        {
            LBL_mensagem.Text = "";
        }

        private void BTN_salvar_Click(object sender, EventArgs e)
        {
            if (TXT_nsenha.Text == TXT_rnsenha.Text)
            {
                if (TXT_senha.Text == usrLogin.getPswAtual())
                {
                    if(TXT_nsenha.Text != usrLogin.getPswAnterior())
                    {
                        usuario.trocarSenha(int.Parse(LBL_usuario.Text), TXT_nsenha.Text);
                        MessageBox.Show("Senha alterada com sucesso!", "Senha alterada",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Senha igual a senha anterior!", "Erro de validação",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        TXT_nsenha.Text = "";
                        TXT_rnsenha.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Senha não confere!", "Erro de validação",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    TXT_senha.Text = "";
                }
            }
            else
                MessageBox.Show("Nova senha e Repetir nova senha não conferem!", "Erro de validação",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);       
        }

        private void TXT_nsenha_Leave(object sender, EventArgs e)
        {
            LBL_n1.Visible = false;
            LBL_n2.Visible = false;
            LBL_n3.Visible = false;
            LBL_n4.Visible = false;
            LBL_n5.Visible = false;
            LBL_forca.Text = "";
            BTN_salvar.Enabled = true;
            verificaSenha ver = new verificaSenha();
            verificaForca verForca = new verificaForca();
            int forca = 10;
            int penaliza = 0;            
            string nomeUser = usrLogin.getName();
            string birthUser = usrLogin.getBirth();
            if (TXT_nsenha.Text != "")
            {
                //----Verifica a restrições------------------------------------
                if (ver.tamanho(TXT_nsenha.Text))
                {
                    MessageBox.Show("Tamanho da senha fora do padrão!\nMinimo: 6 digitos.\nMaximo: 10 digitos.", "Alerta",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    TXT_nsenha.Text = "";
                }
                else
                    if (ver.especialChar(TXT_nsenha.Text))
                    {
                        MessageBox.Show("Não são aceitos caracteres especiais!", "Alerta",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                        TXT_nsenha.Text = "";
                    }
                    else
                        if (ver.letrasNumeros(TXT_nsenha.Text))
                        {
                            MessageBox.Show("A senha de conter no minimo 2 letras e 2 digitos!", "Alerta",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            TXT_nsenha.Text = "";
                        }
                        else
                            if (ver.repeticoes(TXT_nsenha.Text))
                            {
                                MessageBox.Show("A senha não deve conter 3 caracteres iguais em sequencia!", "Alerta",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                TXT_nsenha.Text = "";
                            }
                            else
                                if (ver.senhaUsuario(TXT_nsenha.Text, TXT_senha.Text))
                                {
                                    MessageBox.Show("Nova senha igual a anterior!", "Alerta",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                    TXT_nsenha.Text = "";
                                }
                                else
                                    if (ver.senhaUsuario(TXT_nsenha.Text, LBL_usuario.Text))
                                    {
                                        MessageBox.Show("Nova senha igual ao código de usuário!", "Alerta",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                        TXT_nsenha.Text = "";
                                    }
                //----Verifica a força------------------------------------
                
                
                if (verForca.sequenciaNumeros(TXT_nsenha.Text) != 0)
                { 
                    penaliza += verForca.sequenciaNumeros(TXT_nsenha.Text);
                    MessageBox.Show(penaliza.ToString() + "\nsequenciaNumeros");
                }
                
                penaliza += verForca.qtdLetrasNumeros(TXT_nsenha.Text);
                penaliza += verForca.usuario(TXT_nsenha.Text, LBL_usuario.Text);
                penaliza += verForca.nomeUsuario(TXT_nsenha.Text, nomeUser);
                penaliza += verForca.iniciais(TXT_nsenha.Text, nomeUser);                 
                penaliza += verForca.dataNascimento(TXT_nsenha.Text, birthUser);

                forca -= penaliza;

                if(forca >= 9)
                {
                    LBL_n1.Visible = true;
                    LBL_n2.Visible = true;
                    LBL_n3.Visible = true;
                    LBL_n4.Visible = true;
                    LBL_n5.Visible = true;
                    LBL_forca.Text = "Muito Forte";
                }
                else
                    if(forca < 9 && forca >= 7)
                    {
                        LBL_n1.Visible = true;
                        LBL_n2.Visible = true;
                        LBL_n3.Visible = true;
                        LBL_n4.Visible = true;
                        LBL_forca.Text = "Forte";
                    }
                    else
                        if(forca < 7 && forca >= 5)
                        {
                            LBL_n1.Visible = true;
                            LBL_n2.Visible = true;
                            LBL_n3.Visible = true;
                            LBL_forca.Text = "Razoável";
                        }
                        else
                            if(forca < 5 && forca >= 3)
                            {
                                LBL_n1.Visible = true;
                                LBL_n2.Visible = true;
                                LBL_forca.Text = "Fraca";
                            }
                            else
                                if(forca < 3)
                                {
                                    LBL_n1.Visible = true;
                                    LBL_forca.Text = "Muito Fraca, digite nova senha";
                                    BTN_salvar.Enabled = false;
                                }            
            }
        }
        private void BTN_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class FrmBloq : Form
    {
        usuarios user = new usuarios();
        public FrmBloq()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_confirma_Click(object sender, EventArgs e)
        {
            LBL_usuario.Text = "";
            if (RBTN_bloq.Checked)
            {
                if (user.bloquearUser(int.Parse(TXT_usuario.Text), "2"))
                    MessageBox.Show("Usuario bloqueado!", "Sucesso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                else
                    LBL_usuario.Text = "Usuario invalido";
            }
            else
            {
                user.bloquearUser(int.Parse(TXT_usuario.Text), "1");
                MessageBox.Show("Usuario desbloqueado!", "Sucesso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
            }
        }
    }
}

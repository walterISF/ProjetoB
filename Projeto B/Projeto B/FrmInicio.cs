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
    public partial class FrmInicio : Form
    {
        
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Encerrar a aplicação ?", "Encerrando...",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }
        private void LBL_login_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
        }

        private void LBL_sobre_Click(object sender, EventArgs e)
        {
            FrmSobre sobre = new FrmSobre();
            sobre.ShowDialog();
        }

        private void LBL_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

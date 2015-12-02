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
    public partial class FrmInicio : Form
    {
        
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"c:/temp/arqUser.txt") == false)
            {
                FileStream a = File.Create(@"c:/temp/arqUser.txt");
            }
            if (File.Exists(@"c:/temp/arqMortoUser.txt") == false)
            {
                FileStream b = File.Create(@"c:/temp/arqMortoUser.txt");
            }
            if (File.Exists(@"c:/temp/arqClient.dat") == false)
            {
                FileStream c = File.Create(@"c:/temp/arqClient.dat");
            }
            if (File.Exists(@"c:/temp/arqMortoClient.dat") == false)
            {
                FileStream d = File.Create(@"c:/temp/arqMortoClient.dat");
            }
            if (File.Exists(@"c:/temp/arqProd.dat") == false)
            {
                FileStream f = File.Create(@"c:/temp/arqProd.dat");
            }
            if (File.Exists(@"c:/temp/arqMortoProd.dat") == false)
            {
                FileStream g = File.Create(@"c:/temp/arqMortoProd.dat");
            }
            if (File.Exists(@"c:/temp/arqVendas.dat") == false)
            {
                FileStream f = File.Create(@"c:/temp/arqVendas.dat");
            }
            if (File.Exists(@"c:/temp/arqMortoVendas.dat") == false)
            {
                FileStream g = File.Create(@"c:/temp/arqMortoVendas.dat");
            }  
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

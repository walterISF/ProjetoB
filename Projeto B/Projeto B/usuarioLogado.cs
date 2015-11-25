using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_B
{
    class usuarioLogado
    {
        static int usuario, status, perfil;        
        static string nome, nascimento, pswAtual, pswAnterior, pswDataAlteracao;        

        public void setLogin(int usr)
        {
            usuario = usr;
        }
        public void setStatus(int sts)
        {
            status = sts;
        }
        public void setPerfil(int prf)
        {
            perfil = prf;
        }
        public void setName(string name)
        {
            nome = name;
        }
        public void setBirth(string birth)
        {
            nascimento = birth;
        }
        public void setPswAtual(string psd)
        {
            pswAtual = psd;
        }
        public void setPswAnterior(string psa)
        {
            pswAnterior = psa;
        }
        public void setPswData(string psd)
        {
            pswDataAlteracao = psd;
        }       
        
        //-------------------------------------------------------------
        public int getLogin()
        {
            return usuario;
        }
        public int getStatus()
        {
            return status;
        }
        public int getPerfil()
        {
            return perfil;
        }
        public string getName()
        {
            return nome;
        }
        public string getBirth()
        {
            return nascimento;
        }
        public string getPswAtual()
        {
            return pswAtual;
        }
        public string getPswAnterior()
        {
            return pswAnterior;
        }
        public string getPswData()
        {
            return pswDataAlteracao;
        }
    }
}

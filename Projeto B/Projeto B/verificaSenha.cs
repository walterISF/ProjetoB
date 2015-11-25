using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_B
{
    class verificaSenha
    {
        public char retornaChar(string senha, int i)
        {
            int num = senha.Length;
            char[] pass = new char[num];
            pass = senha.ToCharArray();

            return pass[i];
        }
        public bool tamanho(string nsenha)
        {
            if (nsenha.Length < 6)
                return true;
            else 
                if (nsenha.Length > 10)
                    return true;
                else
                    return false;
        }
        public bool especialChar(string nsenha)
        {
            int i, num = nsenha.Length;
            for(i=0; i<num; i++)
            {
                if(!char.IsLetterOrDigit(retornaChar(nsenha,i)))
                    return true;
            }
            return false;
        }
        public bool letrasNumeros(string nsenha)
        {
            int l=0, n=0, i, num = nsenha.Length;
            for(i=0; i<num; i++)
            {
                if (char.IsLetter(retornaChar(nsenha, i)))
                    l++;
                else
                    if (char.IsNumber(retornaChar(nsenha, i)))
                        n++;
            }
            if (l < 2 || n < 2)
                return true;
            else
                return false;
        }
        public bool repeticoes(string nsenha)
        {
            int i, num = nsenha.Length;
            for (i=0; i<num-2; i++)
            {
                if(retornaChar(nsenha,i) == retornaChar(nsenha,i+1))
                {
                    if (retornaChar(nsenha, i + 1) == retornaChar(nsenha, 1 + 2))
                        return true;
                }                                   
            }
            return false;
        }
        public bool senhaUsuario(string nsenha, string passUser)
        {
            if (nsenha == passUser)
                return true;
            else
                return false;
        }
    //----------------------------------------------------------------------------------------
    }
}

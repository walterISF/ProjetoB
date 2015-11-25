using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_B
{
    class verificaForca
    {
        private bool acharSequencia(string nsenha, string seq)
        {
            int i,j,aux,cont=1, num = nsenha.Length, numSeq = seq.Length;
            for(i=0; i<num; i++)
            {
                if(retornaChar(nsenha, i) == retornaChar(seq, 0))
                {
                    aux = i+1;
                    {
                        for (j = 1; j < numSeq; j++)
                        {
                            if (aux < num)
                            {
                                if (retornaChar(nsenha, aux) == retornaChar(seq, j))
                                {
                                    cont++;
                                    aux++;
                                }
                            }
                        }
                    }
                    if (cont == numSeq)
                        return true;
                }
            }
            return false;
        }
        
        
        private char retornaChar(string senha, int i)
        {
            char[] pass = senha.ToCharArray();

                return senha[i];
        }
        //---------------------------------------------------------
        public int sequenciaNumeros(string nsenha)
        {
            int i, n1, n2, n3, n4, num = nsenha.Length;
            for(i=0; i<num-3; i++)
            {
                if (char.IsNumber(retornaChar(nsenha, i)))
                {
                    n1 = Convert.ToInt32(retornaChar(nsenha, i));
                    if(char.IsNumber(retornaChar(nsenha, i+1)))
                    {
                        n2 = Convert.ToInt32(retornaChar(nsenha, i + 1));
                        if(char.IsNumber(retornaChar(nsenha, i+2)))
                        {
                            n3 = Convert.ToInt32(retornaChar(nsenha, i + 2));
                            if(char.IsNumber(retornaChar(nsenha, i+3)))
                            {
                                n4 = Convert.ToInt32(retornaChar(nsenha, i + 3));
                                if (n2 == n1 + 1 && n3 == n2 + 1 && n4 == n3 + 1)
                                    return 1;
                                else
                                    return 0;
                            }                            
                        }                        
                    }                    
                }                
            }
            return 0;
        }
        public int qtdLetrasNumeros(string nsenha)
        {
            int i, l = 0, n = 0, num = nsenha.Length;
            for(i=0; i<num; i++)
            {
                if (char.IsLetter(retornaChar(nsenha, i)))
                    l++;
                if (char.IsNumber(retornaChar(nsenha, i)))
                    n++;
            }
            if (l == 2 || n == 2)
                return 1;
            else
                return 0;
        }
        public int usuario(string nsenha, string user)
        {
            int i, j, num = nsenha.Length, num2 = user.Length;
            nsenha = nsenha.ToLower();
            user = user.ToLower();
            for(i=0; i<num-2; i++)
            {
                for(j=0; j<num2-2;j++)
                {
                    if(retornaChar(nsenha,i) == retornaChar(user,j))
                        if(retornaChar(nsenha,i+1) == retornaChar(user,j+1))
                            if(retornaChar(nsenha,i+2) == retornaChar(user,j+2))
                                return 2;
                }
            }
            return 0;
        }
        public int nomeUsuario(string nsenha, string nome)
        {
            string[] name = nome.Split(' ');
            string firstName = name[0];
            firstName = firstName.ToLower();
            nsenha = nsenha.ToLower();

            if (acharSequencia(nsenha, firstName))
                return 2;
            else
                return 0;

        }

        public int iniciais(string nsenha, string nome)
        {
            string[] name = nome.Split(' ');
            string ini="";
            int i, numName = name.Length, num = nsenha.Length;
            for(i=0; i<numName; i++)
            {
                if(name[i] != "")
                    ini = ini + name[i].Substring(0, 1);
            }
            ini = ini.ToLower();
            nsenha = nsenha.ToLower();

            if (acharSequencia(nsenha, ini))
                return 2;
            else
                return 0;
        }
        public int dataNascimento(string nsenha, string data)
        {
            string[] birth = data.Split('/');
            string date = "", inverse = birth[2] + birth[1] + birth[0], inverse2 = "";
            int i, j, num = nsenha.Length;
            

            for(i=0,j=1; i<2; i++,j--)
            {
                date += birth[i];
                inverse2 += birth[j];
            }
            if (acharSequencia(nsenha, date))
                return 3;
            else
                if (acharSequencia(nsenha, inverse))
                    return 3;
                else
                    if (acharSequencia(nsenha, inverse2))
                        return 3;
                    else
                        return 0;           
        }
        //---------------------------------------------------------
    }
}

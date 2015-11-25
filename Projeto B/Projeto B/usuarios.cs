using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Projeto_B
{
    class usuarios
    {
        public int cod;
        public int status;
        public int perfil;
        public string nome;
        public string nascimento;
        public string pswAtual;
        public string pswAnterior;
        public string pswAlteracao;       
       
        //--------------------------------------------------------------

        public static string arqUser = @"c:/temp/arqUser.txt";
        public static string arqMortoUser = @"c:/temp/arqMortoUser.txt";
        public static string arqTmp = @"c:/temp/arqTmp.txt";
        
        //CRUD Usuarios

        public void criarUsuario(usuarios user)
        {
            StreamWriter gravar = new StreamWriter(arqUser, true);
            gravar.WriteLine(user.cod + ";" + user.status + ";" + user.perfil + ";" + user.nome + ";" + user.nascimento + ";" + user.pswAtual + ";" + user.pswAnterior + ";" + user.pswAlteracao);
            gravar.Close();
        }
        public string lerUsuario(int codUser)
        {
            StreamReader ler = new StreamReader(arqUser);
            string leitura;
            while((leitura = ler.ReadLine()) != null)
            {
                string [] user = leitura.Split(';');
                int cod = int.Parse(user[0]);
                if (cod == codUser)
                {
                    ler.Close();
                    return leitura;
                }
            }
            ler.Close();
            return "";
        }
        public string lerUltimoUser(int i)
        {
            StreamReader ler = new StreamReader(arqUser);
            string aux = ler.ReadToEnd();
            string[] usuario = aux.Split('\n');
            string[] user = new string[8];
            ler.Close();
            if(usuario.Length < 2)
                user = usuario[0].Split(';');
            else
                user = usuario[usuario.Length - 2].Split(';');
            return user[i];
        }  
        public bool bloquearUser(int codUser, string status)
        {
            string user = lerUsuario(codUser);
            if (user == null)
                return false;
            else
            {
                StreamReader ler = new StreamReader(arqUser);
                StreamWriter escrever = new StreamWriter(arqMortoUser, true);
                StreamWriter arqTemp = new StreamWriter(arqTmp);

                string[] bloq = user.Split(';');
                if(int.Parse(status) == 1)
                {
                    escrever.WriteLine("Desbloqueio de usuario: " + user);
                    bloq[1] = status;
                }
                else
                {
                    escrever.WriteLine("Bloqueio de usuario: " + user);
                    bloq[1] = status;
                }
                user = bloq[0] + ";" + bloq[1] + ";" + bloq[2] + ";" + bloq[3] + ";" + bloq[4] + ";" + bloq[5] + ";" + bloq[6] + ";" + bloq[7];
                string leitura;
                while ((leitura = ler.ReadLine()) != null)
                {
                    bloq = leitura.Split(';');
                    if (int.Parse(bloq[0]) == codUser)
                        arqTemp.WriteLine(user);
                    else
                        arqTemp.WriteLine(leitura);
                }
                ler.Close();
                escrever.Close();
                arqTemp.Close();

                File.Delete(arqUser);
                File.Copy(arqTmp, arqUser);
                File.Delete(arqTmp);

                return true;
            }
        }
        /*
         * 0 - cod usuario
         * 1 - status   1-normal 2-bloqueado 3-senha inicial
         * 2 - perfil   1-administrador 2-operador 3-auxiliar
         * 3 - nome
         * 4 - nascimento
         * 5 - psw atual
         * 6 - psw anterior
         * 7 - psw data da alteração
         */

        //---------------------------------------------------------------------

        public void trocarSenha(int codUser, string novaSenha)
        {
            DateTime data = DateTime.Now;
            StreamReader ler = new StreamReader(arqUser);
            StreamWriter escrever = new StreamWriter(arqMortoUser, true);
            StreamWriter arqTemp = new StreamWriter(arqTmp);
            string usuario = lerUsuario(codUser);
            string[] user = usuario.Split(';');
            escrever.WriteLine("Alteração de Senha: " + usuario);
            user[1] = "1";
            user[6] = user[5];
            user[5] = novaSenha;
            user[7] = data.ToString();
            string nSenha = user[0] + ";" + user[1] + ";" + user[2] + ";" + user[3] + ";" + user[4] + ";" + user[5] + ";" + user[6] + ";" + user[7];
            string leitura;
            while((leitura = ler.ReadLine()) != null)
            {
                string[] aux = leitura.Split(';');
                if (!(int.Parse(aux[0]) == codUser))
                {
                    arqTemp.WriteLine(leitura);
                }
                else
                {
                    arqTemp.WriteLine(nSenha);
                }
            }

            ler.Close();
            escrever.Close();
            arqTemp.Close();

            File.Delete(arqUser);
            File.Copy(arqTmp, arqUser);
            File.Delete(arqTmp);
        }
        
    }
}

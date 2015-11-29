using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Projeto_B
{
    class clientes
    {
        public int cod;
        public int cpf;
        public string nome;
        public string telefone;
        public string endereco;
        public string descricao;
        //------------------------------------------------------------------------
        //---ARQUIVO
        string arqClient = @"c:/temp/arqClient.dat";
        string arqMortoClient = @"c:/temp/arqMortoClient.dat";
        string arqTmp = @"c:/temp/arqTmp.dat";
        //------------------------------------------------------------------------
        //---CRIAR CLIENTE - parametros (classe clientes)
        public void criarCliente(clientes client)
        {
            StreamWriter gravar = new StreamWriter(arqClient, true);
            gravar.WriteLine(client.cod + ";" + client.cpf + ";" + client.nome + ";" + client.telefone + ";" + client.endereco + ";" + client.descricao);
            gravar.Close();
        }
        //------------------------------------------------------------------------
        //---LER CLIENTE - paramentros (int codigo do cliente) - retorna a string com o cliente se existir senão retorna uma string vazia "", a string deve ser partida pelo metodo .Split(';');
        public string lerCliente(int codClient)
        {
            StreamReader ler = new StreamReader(arqClient);
            string leitura;
            while ((leitura = ler.ReadLine()) != null)
            {
                string[] aux = leitura.Split(';');
                if (codClient == int.Parse(aux[0]))
                {
                    ler.Close();
                    return leitura;
                }
            }
            ler.Close();
            return "";
        }
        //-----------------------------------------------------------------------
        //---LER ULTIMO CLIENTE - nao recebe parametros - retorna uma string com o codigo do ultimo cliente cadastrado
        public string lerUltimoCliente()
        {
            StreamReader ler = new StreamReader(arqClient);
            string aux = ler.ReadToEnd();
            string[] usuario = aux.Split('\n');
            string[] user = new string[6];
            ler.Close();
            if (usuario.Length < 2)
                user = usuario[0].Split(';');
            else
                user = usuario[usuario.Length - 2].Split(';');
            return user[0];
        }
        //-----------------------------------------------------------------------
        //---EXCLUIR CLIENTE - parametros (int codigoCliente) - exclui do registro ativo de clientes e retorna true para sucesso
        public bool excluirCliente(int codClient)
        {
            string client = lerCliente(codClient);
            if (client == null)
                return false;
            else
            {
                StreamReader ler = new StreamReader(arqClient);
                StreamWriter escrever = new StreamWriter(arqMortoClient, true);
                StreamWriter arqTemp = new StreamWriter(arqTmp, true);
                DateTime data = DateTime.Now;

                escrever.WriteLine("Exclusão de cliente em " + data.ToString() + ":" + client);

                string leitura;
                while ((leitura = ler.ReadLine()) != null)
                {
                    string[] aux = leitura.Split(';');
                    if (int.Parse(aux[0]) != codClient)
                        arqTemp.WriteLine(leitura);
                }
                ler.Close();
                escrever.Close();
                arqTemp.Close();

                File.Delete(arqClient);
                File.Copy(arqTmp, arqClient);
                File.Delete(arqTmp);

                return true;
            }
        }
        /*
         * retornos:
         * 0 = codigo do cliente
         * 1 = cpf
         * 2 = nome
         * 3 = telefone
         * 4 = endereço
         * 5 = descrição
         */
        //----------------------------------------------------------------------
        //---ALTERAR CIENTE - parametros (int cod cliente, int campo para alterar, string novo campo) 2 param conforme tabela acima, retorna true para alteraçao bem sucedida e false para quando o campo ou o usario estao invalidos.
        public bool alterarCliente(int codClient, int camp, string novo)
        {
            StreamReader ler = new StreamReader(arqClient);
            StreamWriter arqTemp = new StreamWriter(arqTmp, true);

            string leitura;
            while ((leitura = ler.ReadLine()) != null)
            {
                string[] aux = leitura.Split(';');
                if (int.Parse(aux[0]) != codClient)
                {
                    aux[camp] = novo;
                    string cliente = aux[0] + ";" + aux[1] + ";" + aux[2] + ";" + aux[3] + ";" + aux[4] + ";" + aux[5];

                    while ((leitura = ler.ReadLine()) != null)
                    {
                        aux = leitura.Split(';');
                        if (codClient == int.Parse(aux[0]))
                            arqTemp.WriteLine(cliente);
                        else
                            arqTemp.WriteLine(leitura);
                    }
                    ler.Close();
                    arqTemp.Close();

                    File.Delete(arqClient);
                    File.Copy(arqTmp, arqClient);
                    File.Delete(arqTmp);

                    return true;
                }                    
            }
            return false;
        }
        //-----------------------------------------------------------------------------
    }
}

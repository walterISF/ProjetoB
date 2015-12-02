using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Projeto_B
{
    class vendas
    {
        public int cod;
        public int codClient;
        public int codProd;
        public float valor;
        public string data;
        public string descricao;
        //------------------------------------------------------------------------
        //---ARQUIVO
        string arqVendas = @"c:/temp/arqVendas.dat";
        string arqMortoVendas = @"c:/temp/arqMortoVendas.dat";
        string arqTmp = @"c:/temp/arqTmp.dat";
        //------------------------------------------------------------------------
        //---CRIAR VENDA - parametros (classe vendas)
        public void criarVenda(clientes client)
        {
            StreamWriter gravar = new StreamWriter(arqVendas, true);
            gravar.WriteLine(client.cod + ";" + client.cpf + ";" + client.nome + ";" + client.telefone + ";" + client.endereco + ";" + client.descricao);
            gravar.Close();
        }
        //------------------------------------------------------------------------
        //---LER VENDA - paramentros (int codigo da venda) - retorna a string com a venda se existir senão retorna uma string vazia "", a string deve ser partida pelo metodo .Split(';');
        public string lerVenda(int codClient)
        {
            StreamReader ler = new StreamReader(arqVendas);
            string leitura;
            while ((leitura = ler.ReadLine()) != "" && leitura != null)
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
        //---LER ULTIMA VENDA - nao recebe parametros - retorna uma string com o codigo da ultima venda cadastrada
        public string lerUltimoVenda()
        {
            StreamReader ler = new StreamReader(arqVendas);
            string aux = ler.ReadToEnd();
            string[] venda = aux.Split('\n');
            string[] ven = new string[6];
            ler.Close();
            if (venda.Length < 2)
                ven = venda[0].Split(';');
            else
                ven = venda[venda.Length - 2].Split(';');
            return ven[0];
        }
        //-----------------------------------------------------------------------
        //---EXCLUIR VENDA - parametros (int codigoVenda) - exclui do registro ativo de vendas e retorna true para sucesso
        public bool excluirVenda(int codVenda)
        {
            string venda = lerVenda(codVenda);
            if (venda == null)
                return false;
            else
            {
                StreamReader ler = new StreamReader(arqVendas);
                StreamWriter escrever = new StreamWriter(arqMortoVendas, true);
                StreamWriter arqTemp = new StreamWriter(arqTmp, true);
                DateTime data = DateTime.Now;

                escrever.WriteLine("Cancelamento de venda em " + data.ToString() + ":" + venda);

                string leitura;
                while ((leitura = ler.ReadLine()) != "" && leitura != null)
                {
                    string[] aux = leitura.Split(';');
                    if (int.Parse(aux[0]) != codVenda)
                        arqTemp.WriteLine(leitura);
                }
                ler.Close();
                escrever.Close();
                arqTemp.Close();

                File.Delete(arqVendas);
                File.Copy(arqTmp, arqVendas);
                File.Delete(arqTmp);

                return true;
            }
        }
        //-----------------------------------------------------------------------
        //---CANCELAR VENDA - parametros (int codigoVenda) - exclui do registro ativo de vendas e retorna true para sucesso
        public bool excluirCliente(int codVenda)
        {
            string venda = lerVenda(codVenda);
            if (venda == null)
                return false;
            else
            {
                StreamReader ler = new StreamReader(arqVendas);
                StreamWriter escrever = new StreamWriter(arqMortoVendas, true);
                StreamWriter arqTemp = new StreamWriter(arqTmp, true);
                DateTime data = DateTime.Now;

                escrever.WriteLine("Cancelamento da venda em " + data.ToString() + ":" + venda);

                string leitura;
                while ((leitura = ler.ReadLine()) != "" && leitura != null)
                {
                    string[] aux = leitura.Split(';');
                    if (int.Parse(aux[0]) != codVenda)
                        arqTemp.WriteLine(leitura);
                }
                ler.Close();
                escrever.Close();
                arqTemp.Close();

                File.Delete(arqVendas);
                File.Copy(arqTmp, arqVendas);
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
        //---ALTERAR VENDA - parametros (int cod venda, int campo para alterar, string novo campo) 2 param conforme tabela acima, retorna true para alteraçao bem sucedida e false para quando o campo ou o usario estao invalidos.
        public bool alterarVenda(int codVenda, int camp, string novo)
        {
            StreamReader ler = new StreamReader(arqVendas);
            StreamWriter arqTemp = new StreamWriter(arqTmp, true);

            string leitura;
            while ((leitura = ler.ReadLine()) != "" && leitura != null)
            {
                string[] aux = leitura.Split(';');
                if (int.Parse(aux[0]) != codVenda)
                {
                    aux[camp] = novo;
                    string cliente = aux[0] + ";" + aux[1] + ";" + aux[2] + ";" + aux[3] + ";" + aux[4] + ";" + aux[5];

                    ler.Close();
                    StreamReader ler2 = new StreamReader(arqVendas);
                    while ((leitura = ler2.ReadLine()) != "" && leitura != null)
                    {
                        aux = leitura.Split(';');
                        if (codVenda == int.Parse(aux[0]))
                            arqTemp.WriteLine(cliente);
                        else
                            arqTemp.WriteLine(leitura);
                    }
                    ler2.Close();
                    arqTemp.Close();

                    File.Delete(arqVendas);
                    File.Copy(arqTmp, arqVendas);
                    File.Delete(arqTmp);

                    return true;
                }
            }
            return false;
        }
        //---------------------------------------------------------------------------
    }
}

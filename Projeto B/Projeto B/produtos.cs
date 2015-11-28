using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Projeto_B
{
    class produtos
    {
        int cod;
        int quant;
        string nome;
        float valor;
        string secao;
        string descricao;
        //------------------------------------------------------------------------
        //---ARQUIVO
        string arqProd = @"c:/temp/arqProd.dat";
        string arqMortoProd = @"c:/temp/arqMortoProd.dat";
        string arqTmp = @"c:/temp/arqTmp.dat";
        //------------------------------------------------------------------------
        //---CRIAR PRODUTO - parametros (classe produtos)
        public void criarProd(produtos prod)
        {
            StreamWriter gravar = new StreamWriter(arqProd, true);
            gravar.WriteLine(prod.cod + ";" + prod.quant + ";" + prod.nome + ";" + prod.valor*1.00 + ";" + prod.secao + ";" + prod.descricao);
            gravar.Close();
        }
        //------------------------------------------------------------------------
        //---LER PRODUTO - paramentros (int codigo do produto) - retorna a string com o produto se existir senão retorna uma string vazia "", a string deve ser partida pelo metodo .Split(';');
        public string lerProd(int codClient)
        {
            StreamReader ler = new StreamReader(arqProd);
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
        /*
         * retornos:
         * 0 = codigo do cliente
         * 1 = quantidade
         * 2 = nome
         * 3 = valor
         * 4 = secao
         * 5 = descrição
         */
        //-----------------------------------------------------------------------
        //---LER ULTIMO PRODUTO - nao recebe parametros - retorna uma string com o codigo do ultimo produto cadastrado
        public string lerUltimoProd()
        {
            StreamReader ler = new StreamReader(arqProd);
            string aux = ler.ReadToEnd();
            string[] produto = aux.Split('\n');
            string[] prod = new string[6];
            ler.Close();
            if (produto.Length < 2)
                prod = produto[0].Split(';');
            else
                prod = produto[produto.Length - 2].Split(';');
            return prod[0];
        }
        //-----------------------------------------------------------------------
        //---EXCLUIR PRODUTO - parametros (int codigoProduto) - exclui do registro ativo de produtos
        public bool excluirProd(int codProd)
        {
            string client = lerProd(codProd);
            if (client == null)
                return false;
            else
            {
                StreamReader ler = new StreamReader(arqProd);
                StreamWriter escrever = new StreamWriter(arqMortoProd, true);
                StreamWriter arqTemp = new StreamWriter(arqTmp);
                DateTime data = DateTime.Now;

                escrever.WriteLine("Exclusão de produto em " + data.ToString() + ": " + client);

                string leitura;
                while ((leitura = ler.ReadLine()) != null)
                {
                    string[] aux = leitura.Split(';');
                    if (int.Parse(aux[0]) != codProd)
                        arqTemp.WriteLine(leitura);
                }
                ler.Close();
                escrever.Close();
                arqTemp.Close();

                File.Delete(arqProd);
                File.Copy(arqTmp, arqProd);
                File.Delete(arqTmp);

                return true;
            }
        }
        //---------------------------------------------------------------------
    }
}

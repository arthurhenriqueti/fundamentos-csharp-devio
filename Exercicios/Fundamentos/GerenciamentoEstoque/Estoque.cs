using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoEstoque
{
    public class Estoque
    {
        List<Produto> produtos = new List<Produto>();

        public void AdicionarProduto(Produto produto)
        {
            produtos.Add(produto);
        }

        public void RemoverProduto(int indice)
        {
            produtos.RemoveAt(indice);
        }

        public void ExibirProdutos()
        {
            foreach (Produto item in produtos)
            {
                item.ExibirDetalhes();
            }
        }

        public void AtualizarProduto(int indice, Produto produto)
        {
            produtos[indice] = produto;
        }
    }
}
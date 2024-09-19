using System;

namespace GerenciamentoEstoque
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Estoque estoque = new Estoque();

            Produto produto1 = new Produto("Notebook", "Tecnologia", 10, 2100.00);
            Produto produto2 = new Produto("Celular", "Tecnologia", 30, 800.00);
            Produto produto3 = new Produto("Tablete", "Tecnologia", 50, 1400.00);
            Produto produto4 = new Produto("IPhone", "Tecnologia", 50, 5800.00);

            estoque.AdicionarProduto(produto1);
            estoque.AdicionarProduto(produto2);
            estoque.AdicionarProduto(produto3);

            estoque.ExibirProdutos();

            estoque.RemoverProduto(0);

            estoque.AtualizarProduto(0, produto4);

            estoque.ExibirProdutos();
        }
    }
}
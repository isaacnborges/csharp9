using System;
using System.Text.Json;

namespace InitOnlyProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            var produto = new Produto(1, "produto");
            Console.WriteLine(JsonSerializer.Serialize(produto));

            var produtoNovo = new ProdutoNovo()
            {
                Codigo = 1,
                Descricao = "Novo produto"
            };
            Console.WriteLine(JsonSerializer.Serialize(produtoNovo));
        }
    }

    public class Produto
    {
        public int Codigo { get; private set; }
        public string Descricao { get; private set; }

        public Produto(int codigo, string descricao)
        {
            Codigo = codigo;
            Descricao = descricao;
        }
    }

    public class ProdutoNovo
    {
        public int Codigo { get; init; }
        public string Descricao { get; init; }
    }
}

using System;
using System.Text.Json;

namespace Init_onlyProperties
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
}

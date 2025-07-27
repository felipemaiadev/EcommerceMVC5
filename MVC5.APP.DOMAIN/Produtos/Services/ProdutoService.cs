using System;
using MVC5.APP.DOMAIN.Produtos.Entities;
using MVC5.APP.DOMAIN.Produtos.Repositories.Interfaces;
using MVC5.APP.DOMAIN.Produtos.Services.Interfaces;

namespace MVC5.APP.DOMAIN.Produtos.Services
{
    public class ProdutoService : IProdutoService
    {
        public IProdutoRepository _produtoRepository { get; set; }


        // Injeção de Dependencia

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public bool IsValidProduto(string sku)
        {
            // Vou no banco de dados 
            // Consulto a tabela de produtos
            // e retorno para o quem me chamou


            Produto produto1 = new Produto();

            Produto produto2 = new Produto();

            produto1.Descricao = "Batedeira";

            produto2 = produto1;

            Console.WriteLine(produto2.GetHashCode());

            _produtoRepository.RecuperarProdutoPorSKU(sku);

            return true;
        }
    }
}

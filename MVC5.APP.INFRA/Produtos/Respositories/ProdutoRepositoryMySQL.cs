using MVC5.APP.DOMAIN.Produtos.Entities;
using MVC5.APP.DOMAIN.Produtos.Repositories.Interfaces;
using System.Collections.Generic;

namespace MVC5.APP.INFRA.Produtos.Respositories
{
    public class ProdutoRepositoryMySQL : IProdutoRepository
    {

        Produto IProdutoRepository.RecuperarProdutoPorSKU(string sku)
        {
            // Producurar no MySql os produtos e retonrnar

            Produto produto =  new Produto { Descricao = "XPTO"} ;

            return produto;
        }

        public IEnumerable<Produto> RecuperarTodosProdutos()
        {
            // Producurar no MySql os produtos e retonrnar

            IEnumerable<Produto> produtos = new List<Produto> { new Produto { Descricao = "XPTO" } };

            return produtos;
        }

        public Produto SalvarProduto(Produto entidade)
        {
            throw new System.NotImplementedException();
        }
    }
}

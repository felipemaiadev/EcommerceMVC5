using MVC5.APP.DOMAIN.Produtos.Entities;
using MVC5.APP.DOMAIN.Produtos.Repositories.Interfaces;

namespace MVC5.APP.INFRA.Produtos.Respositories
{
    public class ProdutoRepositoryMySQL : IProdutoRepository
    {
        public Produto RecuperarProdutoPorSKU(string sku)
        {
            // Producurar no MySql os produtos e retonrnar

            Produto produto = new Produto();
                
            return produto;
        }
    }
}

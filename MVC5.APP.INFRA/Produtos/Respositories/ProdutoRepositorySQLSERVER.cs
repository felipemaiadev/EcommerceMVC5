using MVC5.APP.DOMAIN.Produtos.Entities;
using MVC5.APP.DOMAIN.Produtos.Repositories.Interfaces;

namespace MVC5.APP.INFRA.Produtos.Respositories
{
    public class ProdutoRepositorySQLSERVER : IProdutoRepository
    {
        public Produto RecuperarProdutoPorSKU(string sku)
        {
            //  Busca usando o Entity Framerok no banco de dados e retorno para quem me chamou

            return new Produto();
        }
    }
}

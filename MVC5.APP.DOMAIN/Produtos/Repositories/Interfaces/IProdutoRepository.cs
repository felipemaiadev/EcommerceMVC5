using MVC5.APP.DOMAIN.Produtos.Entities;

namespace MVC5.APP.DOMAIN.Produtos.Repositories.Interfaces
{
    public interface IProdutoRepository
    {
        Produto RecuperarProdutoPorSKU(string sku);
    }
}

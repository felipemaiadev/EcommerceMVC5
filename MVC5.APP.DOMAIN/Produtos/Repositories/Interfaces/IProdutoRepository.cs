using MVC5.APP.DOMAIN.Produtos.Entities;
using System.Collections.Generic;

namespace MVC5.APP.DOMAIN.Produtos.Repositories.Interfaces
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> RecuperarProdutoPorSKU(string sku);
    }
}

using MVC5.APP.APPLICATION.Produtos.DTO;

namespace MVC5.APP.APPLICATION.Produtos.Services.Interfaces
{
    public interface IProdutoAppService
    {
        ProdutoResponse RecuperarProdutoPorSKU(string sku);
    }
}

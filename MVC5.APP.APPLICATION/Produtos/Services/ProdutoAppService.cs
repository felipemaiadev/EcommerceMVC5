using MVC5.APP.APPLICATION.Produtos.DTO;
using MVC5.APP.APPLICATION.Produtos.Services.Interfaces;
using MVC5.APP.DOMAIN.Produtos.Services.Interfaces;

namespace MVC5.APP.APPLICATION.Produtos.Services
{
    public class ProdutoAppService : IProdutoAppService
    {

        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IProdutoService produtoService)
        {
            this._produtoService = produtoService;
        }

        public ProdutoResponse RecuperarProdutoPorSKU(string sku)
        {
            this._produtoService.IsValidProduto(sku);

            return new ProdutoResponse();
        }
    }
}

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
            _produtoRepository.RecuperarProdutoPorSKU(sku);

            return true;
        }
    }
}

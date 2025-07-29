using MVC5.APP.APPLICATION.Produtos.DTO;
using System.Collections.Generic;

namespace MVC5.APP.APPLICATION.Produtos.Services.Interfaces
{
    public interface IProdutoAppService
    {
        IEnumerable<ProdutoResponse> RecuperarListaProdutos();

        ProdutoResponse CadastrarProduto(ProdutoCadastrarRequest request);
    }
}

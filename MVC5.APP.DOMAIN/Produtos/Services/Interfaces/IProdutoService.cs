using MVC5.APP.DOMAIN.Produtos.Comandos;
using MVC5.APP.DOMAIN.Produtos.Entities;
using System.Collections.Generic;

namespace MVC5.APP.DOMAIN.Produtos.Services.Interfaces
{
    public interface IProdutoService
    {
        bool IsValidProduto(string sku);

        IEnumerable<Produto> ListarProdutos();

        Produto CadastrarProduto(ProdutoCadastrarComando comando);
    }
}

using MVC5.APP.DOMAIN.Produtos.Comandos;
using MVC5.APP.DOMAIN.Produtos.Entities;
using MVC5.APP.DOMAIN.Produtos.Repositories.Interfaces;
using MVC5.APP.DOMAIN.Produtos.Services.Interfaces;
using System.Collections.Generic;

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
            var produtos =  _produtoRepository.RecuperarProdutoPorSKU(sku);


            return true;
        }

        public IEnumerable<Produto> ListarProdutos()
        {
            var produtos = _produtoRepository.RecuperarTodosProdutos();

            return produtos;
        }

        public Produto CadastrarProduto(ProdutoCadastrarComando comando)
        {
            Produto entidade = new Produto { SKU = comando.SKU,
                                             Descricao = comando.Descricao,
                                             Preco = comando.Preco,
                                             Fabricante = comando.Fabricante,
                                             Ativo = true  };
             
           Produto result =  this._produtoRepository.SalvarProduto(entidade);

            return result;
        }
    }
}

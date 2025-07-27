using MVC5.APP.DOMAIN.Produtos.Entities;
using MVC5.APP.DOMAIN.Produtos.Repositories.Interfaces;
using MVC5.APP.INFRA.Produtos.Context;
using System.Collections.Generic;
using System.Linq;

namespace MVC5.APP.INFRA.Produtos.Respositories
{
    public class ProdutoRepositorySQLSERVER : IProdutoRepository
    {

        private readonly SystemContext _context;
        public ProdutoRepositorySQLSERVER(SystemContext context)
        {
            _context = context;
        }
        public IEnumerable<Produto> RecuperarProdutoPorSKU(string sku)
        {

            List<Produto> produtos = _context.Set<Produto>().ToList();

            //  Busca usando o Entity Framerok no banco de dados e retorno para quem me chamou

            return produtos;
        }
    }
}

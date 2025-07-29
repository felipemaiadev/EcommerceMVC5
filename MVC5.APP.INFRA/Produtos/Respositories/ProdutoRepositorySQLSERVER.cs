using MVC5.APP.DOMAIN.Produtos.Entities;
using MVC5.APP.DOMAIN.Produtos.Repositories.Interfaces;
using MVC5.APP.INFRA.Produtos.Context;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace MVC5.APP.INFRA.Produtos.Respositories
{
    public class ProdutoRepositorySQLSERVER : IProdutoRepository
    {

        private readonly SystemContext _context;
        public ProdutoRepositorySQLSERVER(SystemContext context)
        {
            _context = context;
            //_context.Database.Log = Console.WriteLine;
            _context.Database.Log = message => Trace.Write(message);

        }
        public Produto RecuperarProdutoPorSKU(string sku)
        {

            Produto produto = _context.Set<Produto>().Where(x => x.SKU == sku).FirstOrDefault();
            return produto;
        }

        public IEnumerable<Produto> RecuperarTodosProdutos()
        {
            List<Produto> produtos = _context.Set<Produto>().ToList();

            return produtos;
        }

        public Produto SalvarProduto(Produto entidade)
        {
            var result = _context.Set<Produto>().Add(entidade);
            _context.SaveChanges();

            return result;
        }
    }
}

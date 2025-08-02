using MAIA.OOP;
using MVC5.APP.DOMAIN.Pedidos.Repositories;
using MVC5.APP.INFRA.Produtos.Context;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace MVC5.APP.INFRA.Pedidos.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {

        private readonly SystemContext _dbcontext;

        public PedidoRepository(SystemContext context)
        {
            this._dbcontext = context;
            _dbcontext.Database.Log = message => Trace.Write(message);
        }

        public IEnumerable<Pedido> ListarPedidos()
        {
            var result = _dbcontext.Set<Pedido>().ToList();

            var itens = result.Where(p => p.Items.Count > 0).ToList();

            return result;
        }
    }
}

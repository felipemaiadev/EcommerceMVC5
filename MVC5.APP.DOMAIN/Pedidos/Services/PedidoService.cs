using MAIA.OOP;
using MVC5.APP.DOMAIN.Pedidos.Repositories;
using MVC5.APP.DOMAIN.Pedidos.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC5.APP.DOMAIN.Pedidos.Services
{
    public class PedidoService : IPedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;

        public PedidoService(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        public IEnumerable<Pedido> BuscarTodosPedidos()
        {
            var result = _pedidoRepository.ListarPedidos();

            return result;  
        }
    }
}

using MAIA.OOP;
using System.Collections.Generic;

namespace MVC5.APP.DOMAIN.Pedidos.Repositories
{
    public interface IPedidoRepository
    {
        IEnumerable<Pedido> ListarPedidos();
    }
}

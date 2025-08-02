using MAIA.OOP;
using System.Collections.Generic;

namespace MVC5.APP.DOMAIN.Pedidos.Services.Interfaces
{
    public interface IPedidoService
    {
        IEnumerable<Pedido> BuscarTodosPedidos();
    }
}

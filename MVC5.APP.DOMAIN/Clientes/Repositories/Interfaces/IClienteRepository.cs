using MVC5.APP.DOMAIN.Clientes.Entities;

namespace MVC5.APP.DOMAIN.Clientes.Repositories.Interfaces
{
    public interface IClienteRepository
    {
        Cliente RecuperarPorId(long id);
    }
}

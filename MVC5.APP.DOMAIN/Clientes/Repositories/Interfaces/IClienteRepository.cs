using MVC5.APP.DOMAIN.Clientes.Entities;
using System.Collections;
using System.Collections.Generic;

namespace MVC5.APP.DOMAIN.Clientes.Repositories.Interfaces
{
    public interface IClienteRepository
    {
        Cliente RecuperarPorCPF(string cpf);

        Cliente SalvarCliente(Cliente entidade);

        IEnumerable <Cliente> MostrarClientes();

    }
}

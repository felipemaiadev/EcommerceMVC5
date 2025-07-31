using MVC5.APP.DOMAIN.Clientes.Comando;
using MVC5.APP.DOMAIN.Clientes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC5.APP.DOMAIN.Clientes.Services.Interfaces
{
    public interface IClienteService
    {
        bool IsValidCliente(string cpf);

        IEnumerable<Cliente> ListarCliente();

        Cliente CadastrarCliente(ClienteCadastrarComando comando);
    }
}

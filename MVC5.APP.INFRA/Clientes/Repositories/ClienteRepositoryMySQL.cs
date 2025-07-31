using MVC5.APP.DOMAIN.Clientes.Entities;
using MVC5.APP.DOMAIN.Clientes.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC5.APP.INFRA.Clientes.Repositories
{
    internal class ClienteRepositoryMySQL : IClienteRepository
    {
        public IEnumerable<Cliente> MostrarClientes()
        {
            IEnumerable<Cliente> clientes = new List<Cliente> { new Cliente { Name = "XPTO" } };
            
            return clientes;
        }

        public Cliente RecuperarPorCPF(string cpf)
        {
           Cliente cliente = new Cliente {  Name = "XPTO"  };

            return cliente;
        }

        public Cliente SalvarCliente(Cliente entidade)
        {
            throw new NotImplementedException();
        }
    }
}

using MVC5.APP.DOMAIN.Clientes.Entities;
using MVC5.APP.DOMAIN.Clientes.Repositories.Interfaces;
using MVC5.APP.INFRA.Produtos.Context;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC5.APP.INFRA.Clientes.Repositories
{
    public class ClienteRepositorySQLSERVER : IClienteRepository
    {

        private readonly SystemContext _context;
        
        public ClienteRepositorySQLSERVER(SystemContext context)
        {
            _context = context;
            _context.Database.Log = message => Trace.Write(message);
        }

        public IEnumerable<Cliente> MostrarClientes()
        {
          List<Cliente> clientes = _context.Set<Cliente>().ToList();
           
          return clientes;
        }

        public Cliente RecuperarPorCPF(string cpf)
        {
            Cliente cliente = _context.Set<Cliente>().Where(c => c.Cpf == cpf).FirstOrDefault();
            
            return cliente;
        }

        public Cliente SalvarCliente(Cliente entidade)
        {
            var result = _context.Set<Cliente>().Add(entidade);
            _context.SaveChanges();

            return result;
        }
    }
}

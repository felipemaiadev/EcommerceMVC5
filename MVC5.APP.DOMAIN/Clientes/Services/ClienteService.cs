using MVC5.APP.DOMAIN.Clientes.Comando;
using MVC5.APP.DOMAIN.Clientes.Entities;
using MVC5.APP.DOMAIN.Clientes.Repositories.Interfaces;
using MVC5.APP.DOMAIN.Produtos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC5.APP.DOMAIN.Clientes.Services.Interfaces
{
    public class ClienteService : IClienteService
    {
        public IClienteRepository _clienterepository {  get; set; }
        
        public ClienteService(IClienteRepository clienterepository)
        {
            _clienterepository = clienterepository;
        }

        public Cliente CadastrarCliente(ClienteCadastrarComando comando)
        {
           Cliente entidade = new Cliente { Name = comando.Name,
                                            Cpf =comando.Cpf,
                                            Endereco = comando.Endereco };

            Cliente result = this._clienterepository.SalvarCliente(entidade);
            return result;
        }

        public bool IsValidCliente(string cpf)
        {
            var cliente = _clienterepository.RecuperarPorCPF(cpf);
            return true;
        }

        public IEnumerable<Cliente> ListarCliente()
        {
            var cliente = _clienterepository.MostrarClientes();
            return cliente;
        }
    }
}

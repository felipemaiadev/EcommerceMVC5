using AutoMapper;
using MVC5.APP.APPLICATION.Clientes.DTO;
using MVC5.APP.APPLICATION.Clientes.Services.Interfaces;
using MVC5.APP.DOMAIN.Clientes.Comando;
using MVC5.APP.DOMAIN.Clientes.Entities;
using MVC5.APP.DOMAIN.Clientes.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC5.APP.APPLICATION.Clientes.Services
{
    public class ClienteAppServices : IClienteAppServices
    {

        private readonly IClienteService _clienteservice;
        private readonly IMapper _mapper;

        public ClienteAppServices (IClienteService clienteservice, IMapper mapper)
        {
            this._clienteservice = clienteservice;
            this._mapper = mapper;
        }

        public ClienteResponse CadastrarCliente(ClienteCadastrarRequest request)
        {
           ClienteCadastrarComando comando = _mapper.Map<ClienteCadastrarComando>(request);
           Cliente result = this._clienteservice.CadastrarCliente(comando);
           ClienteResponse resposta = _mapper.Map<ClienteResponse>(result);
           
            return resposta;
        }

        public IEnumerable<ClienteResponse> ListarClientes()
        {
            var cliente = this._clienteservice.ListarCliente();
            var listaclientes = _mapper.Map<IEnumerable<ClienteResponse>>(cliente);

            return listaclientes;
        }
    }
}

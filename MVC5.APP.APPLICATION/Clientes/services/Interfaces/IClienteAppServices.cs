using MVC5.APP.APPLICATION.Clientes.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC5.APP.APPLICATION.Clientes.Services.Interfaces
{
    internal interface IClienteAppServices
    {
        IEnumerable<ClienteResponse> ListarClientes();

        ClienteResponse CadastrarCliente (ClienteCadastrarRequest request);
    }
}

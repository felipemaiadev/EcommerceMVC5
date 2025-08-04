using MVC5.APP.APPLICATION.Clientes.DTO;
using System.Collections.Generic;


namespace MVC5.APP.APPLICATION.Clientes.Services.Interfaces
{
    public interface IClienteAppServices
    {
        IEnumerable<ClienteResponse> ListarClientes();

        ClienteResponse CadastrarCliente (ClienteCadastrarRequest request);
    }
}

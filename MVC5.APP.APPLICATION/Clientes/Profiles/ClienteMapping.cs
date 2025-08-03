using AutoMapper;
using MVC5.APP.APPLICATION.Clientes.DTO;
using MVC5.APP.DOMAIN.Clientes.Comando;
using MVC5.APP.DOMAIN.Clientes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC5.APP.APPLICATION.Clientes.Profiles
{
    public class ClienteMapping : Profile
    {
        public ClienteMapping()
        {
            CreateMap<Cliente, ClienteResponse>();

            CreateMap<ClienteCadastrarRequest, ClienteCadastrarComando>();
        }
    }
}

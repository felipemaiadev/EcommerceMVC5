using AutoMapper;
using MVC5.APP.APPLICATION.Produtos.DTO;
using MVC5.APP.DOMAIN.Produtos.Comandos;
using MVC5.APP.DOMAIN.Produtos.Entities;

namespace MVC5.APP.APPLICATION.Produtos.Profiles
{
    public class ProdutoMapping : Profile
    {

        public ProdutoMapping()
        {
            CreateMap<Produto, ProdutoResponse>();

            CreateMap<ProdutoCadastrarRequest, ProdutoCadastrarComando>();
        }
    }
}

using AutoMapper;
using MVC5.APP.APPLICATION.Produtos.DTO;
using MVC5.APP.APPLICATION.Produtos.Services.Interfaces;
using MVC5.APP.DOMAIN.Produtos.Services.Interfaces;
using System.Collections.Generic;

namespace MVC5.APP.APPLICATION.Produtos.Services
{
    public class ProdutoAppService : IProdutoAppService
    {

        private readonly IProdutoService _produtoService;
        private readonly IMapper _mapper;

        public ProdutoAppService(IProdutoService produtoService, IMapper mapper)
        {
            this._produtoService = produtoService;
            this._mapper = mapper;
        }

        public IEnumerable<ProdutoResponse> RecuperarListaProdutos()
        {
           var produtos = this._produtoService.ListarProdutos();
           
           var listaRespostas = _mapper.Map<IEnumerable<ProdutoResponse>>(produtos);

            return listaRespostas;
        }
    }
}

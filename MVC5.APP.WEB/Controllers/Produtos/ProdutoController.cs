using MVC5.APP.APPLICATION.Produtos.DTO;
using MVC5.APP.APPLICATION.Produtos.Services.Interfaces;
using System.Web.Mvc;

namespace MVC5.APP.WEB.Controllers.Produtos
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoAppService _produtoAppService;

        public ProdutoController(IProdutoAppService produtoAppService)
        {
            this._produtoAppService = produtoAppService;
        }

      
        // GET: Produto
        public ActionResult Index()
        {
            var response = this._produtoAppService.RecuperarListaProdutos();
            return View(response);
        }

        public ActionResult Cadastro()
        {
            return View();
        }

        public ActionResult GetListaProdutos()
        {
            var response = this._produtoAppService.RecuperarListaProdutos();
            Response.StatusCode = 202; // Accepted
            Response.Headers["X-Custom-Header"] = "UmValorNoHeader";
            return Json(response, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult CadastrarProduto(ProdutoCadastrarRequest request)
        {
            ProdutoResponse response = this._produtoAppService.CadastrarProduto(request);
            Response.StatusCode = 204; // Sucesso e Algo foi Criado
            return Json(response, JsonRequestBehavior.AllowGet);

        }

    }
}
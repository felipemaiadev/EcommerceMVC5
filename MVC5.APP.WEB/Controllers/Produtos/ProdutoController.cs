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

        //public ProdutoController()
        //{

        //}

        // GET: Produto
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cadastro()
        {
            return View();
        }

        public ActionResult GetListaProdutos()
        {
            var response = this._produtoAppService.RecuperarListaProdutos();
            Response.StatusCode = 202; // Accepted
            Response.Headers["X-Custom-Header"] = "MyValue";
            return Content("Valor sendo retornado pelo Servidor", "text/plain");
        }
    }
}
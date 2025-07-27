using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Microsoft.Ajax.Utilities;
using MVC5.APP.APPLICATION.Produtos.DTO;
using MVC5.APP.APPLICATION.Produtos.Services.Interfaces;

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

        public ActionResult GetProductBySku(string request)
        {
            var response =   this._produtoAppService.RecuperarProdutoPorSKU(request);
            Response.StatusCode = 202; // Accepted
            Response.Headers["X-Custom-Header"] = "MyValue";
            return Content("Valor sendo retornado pelo Servidor", "text/plain");
        }
    }
}
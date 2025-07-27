using System.Web.Mvc;
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

        public ProdutoController()
        {

        }

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
            this._produtoAppService.RecuperarProdutoPorSKU(request);
            return View();
        }
    }
}
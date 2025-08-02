using MVC5.APP.DOMAIN.Pedidos.Services.Interfaces;
using System.Web.Mvc;

namespace MVC5.APP.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPedidoService _pedidoService;


        public HomeController(IPedidoService pedidoService)
        {
            this._pedidoService = pedidoService;
        }

        public ActionResult Index()
        {
            var retorno = _pedidoService.BuscarTodosPedidos();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
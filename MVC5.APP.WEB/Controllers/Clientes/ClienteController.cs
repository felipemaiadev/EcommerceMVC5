using MVC5.APP.APPLICATION.Clientes.DTO;
using MVC5.APP.APPLICATION.Clientes.Services.Interfaces;
using MVC5.APP.DOMAIN.Clientes.Services.Interfaces;
using System.Web;
using System.Web.Mvc;

namespace MVC5.APP.WEB.Controllers.Clientes
{
    public class ClienteController : Controller 
    {
        private readonly IClienteAppServices _clienteAppServices;

        public ClienteController(IClienteAppServices clienteAppServices)
        {
            _clienteAppServices = clienteAppServices;
        }

        public ActionResult Index()
        {
            var response = this._clienteAppServices.ListarClientes();
            return View(response);
        }

        public ActionResult Cadastro() 
        {
            return View();
        }

        public ActionResult GetListaClientes()
        {
            var response = this._clienteAppServices.ListarClientes();
            Response.StatusCode = 202;
            Response.Headers["X-Custom-Header"] = "UmValorNoHeader";
            return Json(response, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult CadastrarCliente(ClienteCadastrarRequest request) 
        {
            ClienteResponse  response =this._clienteAppServices.CadastrarCliente(request);
            Response.StatusCode = 204;
            return Json(response, JsonRequestBehavior.AllowGet);
        }
    }  
        
}
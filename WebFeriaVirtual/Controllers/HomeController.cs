using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebFeriaVirtual.Negocio;

namespace WebFeriaVirtual.Controllers
{
    
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Print()
        {
            return View();
        }


        public ActionResult TipoUsuario()
        {
            return View();
        }

        public ActionResult ListaUsuarios()
        {
            return View();
        }

        public ActionResult ListaCrearUsuarios()
        {
            return View();
        }

        public ActionResult SubastaExt()
        {
            return View();
        }

        public ActionResult SubE()
        {
            ViewBag.productos = new Producto().ReadAll();
            return View();
        }
    }

    
}
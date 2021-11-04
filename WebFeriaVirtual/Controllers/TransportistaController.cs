using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebFeriaVirtual.Controllers
{
    public class TransportistaController : Controller
    {
        // GET: Transportista
        public ActionResult Indextranspor()
        {
            return View();
        }
        public ActionResult ListaTrans()
        {
            return View();
        }
    }
}
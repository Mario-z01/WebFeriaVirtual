using WebFeriaVirtual.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Mvc;

namespace WebFeriaVirtual.Controllers
{
    public class IntAuthController : Controller
    {
        
        public ActionResult LoginInt()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginInt(UsuarioInterno usuarioInt, string ReturnUrl)
        {
            if (IsValid(usuarioInt))
            {
                FormsAuthentication.SetAuthCookie(usuarioInt.Correo, false);
                if (ReturnUrl != null)
                {
                    return Redirect(ReturnUrl);
                }
                return RedirectToAction("IndexInt", "UsuarioInt");
            }
            TempData["Mensaje"] = "Credenciales Incorrectas";
            return View(usuarioInt);

        }

        private Boolean IsValid(UsuarioInterno usuarioInt)
        {
            return usuarioInt.Autenticar();
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("IndexInt", "UsuarioInt");

        }
    }
}
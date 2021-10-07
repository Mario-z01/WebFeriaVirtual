using WebFeriaVirtual.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Mvc;

namespace WebFeriaVirtual.Controllers
{
    public class AuthController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UsuarioInterno usuarioInt, string ReturnUrl)
        {
            if(IsValid(usuarioInt))
            {
                FormsAuthentication.SetAuthCookie(usuarioInt.Correo, false);
                if(ReturnUrl != null)
                {
                    return Redirect(ReturnUrl);
                }
                return RedirectToAction("Index", "Home");
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
            return RedirectToAction("Index", "Home");
                                    
        }
    }
    
}
using WebFeriaVirtual.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Mvc;

namespace WebFeriaVirtual.Controllers
{
    public class AdmAuthController : Controller
    {
        public ActionResult LoginAdmin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginAdmin(UsuarioAdmin usuarioAdm, string ReturnUrl)
        {
            if(IsValid(usuarioAdm))
            {
                FormsAuthentication.SetAuthCookie(usuarioAdm.Usuario, false);
                if(ReturnUrl != null)
                {
                    return Redirect(ReturnUrl);
                }
                return RedirectToAction("Index", "Home");
            }
            TempData["Mensaje"] = "Credenciales Incorrectas";
            return View(usuarioAdm);

        }

        private Boolean IsValid(UsuarioAdmin usuarioAdm)
        {
            return usuarioAdm.Autenticar();
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            TempData["mensaje"] = "Sesion cerrada correctamente";
            return RedirectToAction("TipoUsuario", "Home");
                                    
        }

        


    }
    
}
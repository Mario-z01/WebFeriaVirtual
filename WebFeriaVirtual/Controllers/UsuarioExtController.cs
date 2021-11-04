using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebFeriaVirtual.Negocio;
using System.Web.Security;

namespace WebFeriaVirtual.Controllers
{
    public class UsuarioExtController : Controller
    {
        // GET: UsuarioExt
        public ActionResult IndexExt()
        {
            return View();
        }

        public ActionResult ListaUsuExt()
        {
            ViewBag.usuarioExternos = new UsuarioExterno().ReadAll();
            return View();
        }

        public ActionResult CreateUsuExt()
        {
            return View();
        }

        // POST: UsuarioInt/CreateExt
        [HttpPost]
        public ActionResult CreateUsuExt([Bind(Include = "Nombre,Direccion,Telefono,Correo,Contraseña")]UsuarioExterno usuarioExterno)
        {
            try
            {
                // TODO: Add insert logic here
                usuarioExterno.Save();
                TempData["mensaje"] = "Usuario guardado correctamente";
                return RedirectToAction("ListaUsuExt", "UsuarioExt");
            }
            catch
            {
                return View(usuarioExterno);
            }
        }

        public ActionResult LoginExt()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginExt(UsuarioExterno usuarioExt, string ReturnUrl)
        {
            if (IsValid(usuarioExt))
            {
                FormsAuthentication.SetAuthCookie(usuarioExt.Correo, false);
                if (ReturnUrl != null)
                {
                    return Redirect(ReturnUrl);
                }
                return RedirectToAction("IndexExt", "UsuarioExt");
            }
            TempData["Mensaje"] = "Credenciales Incorrectas";
            return View(usuarioExt);

        }

        private Boolean IsValid(UsuarioExterno usuarioExt)
        {
            return usuarioExt.Autenticar();
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("IndexExt", "UsuarioExt");

        }

        public ActionResult Edit(int id)
        {
            UsuarioExterno u = new UsuarioExterno().Find(id);

            if (u == null)
            {
                TempData["mensaje"] = "El usuario no existe";
                return RedirectToAction("ListaUsuExt");
            }

            return View(u);
        }

        // POST: Producto/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id,Nombre,Direccion,Telefono,Correo,Contraseña")]UsuarioExterno usuarioExterno)
        {
            try
            {
                // TODO: Add update logic here
                usuarioExterno.Update();
                TempData["mensaje"] = "Usuario modificado correctamente";
                return RedirectToAction("ListaUsuExt");
            }
            catch
            {
                return View(usuarioExterno);
            }
        }

        // GET: Producto/Delete/5
        public ActionResult Delete(int id)
        {
            if (new UsuarioExterno().Find(id) == null)
            {
                TempData["Mensaje"] = "no existe el usuario";
                return RedirectToAction("ListaUsuExt");
            }
            if (new UsuarioExterno().Delete(id))
            {
                TempData["Mensaje"] = "Eliminacion correcta";
                return RedirectToAction("ListaUsuExt");
            }


            TempData["Mensaje"] = "No se elimino el usuario";
            return View();
        }

        // POST: Producto/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("ListaUsuExt");
            }
            catch
            {
                return View();
            }
        }

    }
}
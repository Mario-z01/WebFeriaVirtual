using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Mvc;
using WebFeriaVirtual.Negocio;
namespace WebFeriaVirtual.Controllers
{
    public class TransportistaController : Controller
    {
        // GET: Transportista
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListaTransportista()
        {
            ViewBag.transportistas = new Transportista().ReadAll();
            return View();
        }

        public ActionResult SubastaInt()
        {
            ViewBag.transportistas = new Transportista().ReadAll();
            return View();
        }

        public ActionResult SubastaExt()
        {
            ViewBag.transportistas = new Transportista().ReadAll();
            return View();
        }

        public ActionResult CreateTransportista()
        {
            EnviarEmpresa();
            return View();
        }

        private void EnviarEmpresa()
        {
            ViewBag.empresas = new Empresa().ReadAll();
        }

        [HttpPost]
        public ActionResult CreateTransportista([Bind(Include = "Nombre,Edad,Telefono,Correo,Contraseña,IdEmpresa")]Transportista transportista)
        {
            try
            {
                // TODO: Add insert logic here
                transportista.Save();
                TempData["mensaje"] = "Usuario Transportista guardado correctamente";
                return RedirectToAction("ListaTransportista", "Transportista");
            }
            catch
            {
                return View(transportista);
            }
        }

        public ActionResult LoginTransportista()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginTransportista(Transportista transportista, string ReturnUrl)
        {
            if (IsValid(transportista))
            {
                FormsAuthentication.SetAuthCookie(transportista.Correo, false);
                if (ReturnUrl != null)
                {
                    return Redirect(ReturnUrl);
                }
                return RedirectToAction("Index", "Transportista");
            }
            TempData["Mensaje"] = "Credenciales Incorrectas";
            return View(transportista);

        }

        private Boolean IsValid(Transportista transportista)
        {
            return transportista.Autenticar();
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("TipoUsuario", "Home");

        }

        public ActionResult Edit(int id)
        {
            Transportista t = new Transportista().Find(id);

            if (t == null)
            {
                TempData["mensaje"] = "El usuario no existe";
                return RedirectToAction("ListaTransportista");
            }
            EnviarEmpresa();

            return View(t);
        }

        // POST: Producto/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id,Nombre, Edad, Telefono, Direccion, Correo, Contraseña,IdEmpresa")]Transportista transportista)
        {
            try
            {
                // TODO: Add update logic here
                transportista.Update();
                TempData["mensaje"] = "Usuario modificado correctamente";
                return RedirectToAction("ListaTransportista");
            }
            catch
            {
                return View(transportista);
            }
        }

        // GET: Producto/Delete/5
        public ActionResult Delete(int id)
        {
            if (new Transportista().Find(id) == null)
            {
                TempData["Mensaje"] = "no existe el usuario";
                return RedirectToAction("ListaTransportista");
            }
            if (new Transportista().Delete(id))
            {
                TempData["Mensaje"] = "Eliminacion correcta";
                return RedirectToAction("ListaTransportista");
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

                return RedirectToAction("ListaTransportista");
            }
            catch
            {
                return View();
            }
        }
    }
}
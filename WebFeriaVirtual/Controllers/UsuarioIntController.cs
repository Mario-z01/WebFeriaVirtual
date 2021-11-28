using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebFeriaVirtual.Negocio;

namespace WebFeriaVirtual.Controllers
{
    [Authorize]
    public class UsuarioIntController : Controller
    {
        // GET: UsuarioInt
        public ActionResult ListaUsuInt()
        {
            ViewBag.usuarioInternos = new UsuarioInterno().ReadAll();
            return View();
        }

        // GET: UsuarioInt/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }


        public ActionResult IndexInt()
        {
            return View();
        }

        public ActionResult SolicitudInt()
        {
            return View();
        }

        public ActionResult CreateUsuInt()
        {
            EnviarRegion();
            return View();
        }

        private void EnviarRegion()
        {
            ViewBag.regiones = new Region().ReadAll();
        }

        // POST: UsuarioInt/CreateInt
        [HttpPost]
        public ActionResult CreateUsuInt([Bind(Include = "IdRegion, Nombre,Direccion,Telefono,Correo,Contraseña")]UsuarioInterno usuarioInterno)
        {
            try
            {
                // TODO: Add insert logic here
                usuarioInterno.Save();
                TempData["mensaje"] = "Usuario guardado correctamente";
                return RedirectToAction("ListaUsuInt", "UsuarioInt");
            }
            catch
            {
                return View(usuarioInterno);
            }
        }

        // GET: Producto/Edit/5
        public ActionResult Edit(int id)
        {
            UsuarioInterno u = new UsuarioInterno().Find(id);

            if (u == null)
            {
                TempData["mensaje"] = "El usuario no existe";
                return RedirectToAction("ListaUsuInt");
            }
            EnviarRegion();

            return View(u);
        }

        // POST: Producto/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id,IdRegion,Nombre,Direccion,Telefono,Correo,Contraseña")]UsuarioInterno usuarioInterno)
        {
            try
            {
                // TODO: Add update logic here
                usuarioInterno.Update();
                TempData["mensaje"] = "Usuario modificado correctamente";
                return RedirectToAction("ListaUsuInt");
            }
            catch
            {
                return View(usuarioInterno);
            }
        }

        // GET: Producto/Delete/5
        public ActionResult Delete(int id)
        {
            if (new UsuarioInterno().Find(id) == null)
            {
                TempData["Mensaje"] = "no existe el usuario";
                return RedirectToAction("ListaUsuInt");
            }
            if (new UsuarioInterno().Delete(id))
            {
                TempData["Mensaje"] = "Eliminacion correcta";
                return RedirectToAction("ListaUsuInt");
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

                return RedirectToAction("ListaUsuInt");
            }
            catch
            {
                return View();
            }
        }
    }
}

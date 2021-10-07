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
        public ActionResult Index()
        {
            ViewBag.usuarioInternos = new UsuarioInterno().ReadAll();
            return View();
        }

        // GET: UsuarioInt/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UsuarioInt/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuarioInt/Create
        [HttpPost]
        public ActionResult Create([Bind(Include ="Nombre,Direccion,Telefono,Correo,Contraseña")]UsuarioInterno usuarioInterno)
        {
            try
            {
                // TODO: Add insert logic here
                usuarioInterno.Save();
                TempData["mensaje"] = "Usuario guardado correctamente";
                return RedirectToAction("Index");
            }
            catch
            {
                return View(usuarioInterno);
            }
        }

        // GET: UsuarioInt/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UsuarioInt/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuarioInt/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsuarioInt/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

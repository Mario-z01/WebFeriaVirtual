using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebFeriaVirtual.Negocio;

namespace WebFeriaVirtual.Controllers
{
    public class SolicitudController : Controller
    {
        // GET: Solicitud
        public ActionResult Index()
        {
            ViewBag.solicitudes = new Solicitud().ReadAll();
            return View();
        }

        // GET: Solicitud/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Solicitud/Create
        public ActionResult Create()
        {
            EnviarTipo();
            EnviarCalidad();
            return View();
        }

        private void EnviarCalidad()
        {
            ViewBag.calidad = new Calidad().ReadAll();
        }

        private void EnviarTipo()
        {
            ViewBag.tipos = new Tipo().ReadAll();
        }

        // POST: Solicitud/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "TipoId,CalidadId,Cantidad")]Solicitud solicitud)
        {
            try
            {
                // TODO: Add insert logic here
                solicitud.Save();
                TempData["mensaje"] = "producto guardado correctamente";
                return RedirectToAction("Index", "Solicitud");

            }
            catch
            {
                return View(solicitud);
            }
        }

        // GET: Producto/Edit/5
        public ActionResult Edit(int id)
        {
            Solicitud s = new Solicitud().Find(id);

            if (s == null)
            {
                TempData["mensaje"] = "La solicitud no existe";
                return RedirectToAction("Index");
            }
            EnviarTipo();
            EnviarCalidad();

            return View(s);
        }

        // POST: Producto/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id,TipoId,CalidadId,Cantidad")]Solicitud solicitud)
        {
            try
            {
                // TODO: Add update logic here
                solicitud.Update();
                TempData["mensaje"] = "solicitud modificada correctamente";
                return RedirectToAction("Index");
            }
            catch
            {
                return View(solicitud);
            }
        }

        // GET: Producto/Delete/5
        public ActionResult Delete(int id)
        {
            if (new Solicitud().Find(id) == null)
            {
                TempData["Mensaje"] = "no existe la solicitud";
                return RedirectToAction("Index");
            }
            if (new Solicitud().Delete(id))
            {
                TempData["Mensaje"] = "Solicitud eliminada correctamente";
                return RedirectToAction("Index");
            }


            TempData["Mensaje"] = "No se elimino la solicitud";
            return View();
        }

        // POST: Producto/Delete/5
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

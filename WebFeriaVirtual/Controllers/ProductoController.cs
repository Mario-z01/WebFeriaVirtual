using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebFeriaVirtual.Negocio;

namespace WebFeriaVirtual.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {
            ViewBag.productos = new Producto().ReadAll();
            return View();
        }

        // GET: Producto/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Producto/Create
        public ActionResult Create()
        {
            EnviarTipos();
            return View();
        }

        private void EnviarTipos()
        {
            ViewBag.tipos = new Tipo().ReadAll();
        }

        // POST: Producto/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "TipoId,Stock,Precio")]Producto producto)
        {
            try
            {
                // TODO: Add insert logic here
                producto.Save();
                TempData["mensaje"] = "producto guardado correctamente";
                return RedirectToAction("Index", "Producto");

            }
            catch
            {
                return View(producto);
            }
        }

        // GET: Producto/Edit/5
        public ActionResult Edit(int id)
        {
            Producto p = new Producto().Find(id);

            if(p== null)
            {
                TempData["mensaje"] = "El producto no existe";
                return RedirectToAction("Index");
            }
            EnviarTipos();

            return View(p);
        }

        // POST: Producto/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id,TipoId,Stock,Precio")]Producto producto)
        {
            try
            {
                // TODO: Add update logic here
                producto.Update();
                TempData["mensaje"] = "Producto modificado correctamente";
                return RedirectToAction("Index");
            }
            catch
            {
                return View(producto);
            }
        }

        // GET: Producto/Delete/5
        public ActionResult Delete(int id)
        {
            if (new Producto().Find(id)== null)
            {
                TempData["Mensaje"] = "no existe el producto";
                return RedirectToAction("Index");
            }
                if (new Producto().Delete(id))
            {
                TempData["Mensaje"] = "Eliminacion correcta";
                return RedirectToAction("Index");
            }
            
            
            TempData["Mensaje"] = "No se elimino el producto";
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

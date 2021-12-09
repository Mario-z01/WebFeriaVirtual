using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebFeriaVirtual.Negocio;

namespace WebFeriaVirtual.Controllers
{
    public class VentaExternaController : Controller
    {
        // GET: SubastaExterna
        public ActionResult Index()
        {
            ViewBag.ventas = new VentaExterna().ReadAll();
            return View();
        }

        // GET: SubastaExterna/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult TipoVenta()
        {
             return View();
        }

        // GET: SubastaExterna/Create
        public ActionResult Create()
        {
            EnviarOpciones();
            EnviarExterno();
            EnviarTipos();
            EnviarProducto();
            EnviarSolicitud();
            return View();
        }

        private void EnviarOpciones()
        {
            ViewBag.opciones = new Opcion().ReadAll();
        }

        private void EnviarExterno()
        {
            ViewBag.usuarioExternos = new UsuarioExterno().ReadAll();
        }

        private void EnviarTipos()
        {
            ViewBag.tipos = new Tipo().ReadAll();
        }

        private void EnviarSolicitud()
        {
            ViewBag.solicitudes = new Solicitud().ReadAll();
        }

        private void EnviarProducto()
        {
            ViewBag.productos = new Producto().ReadAll();
        }



        // POST: Producto/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "Fecha,IdCliente2,Precio,IdProducto,IdSolicitud,IdOpcion")]VentaExterna ventaExterna)
        {
            try
            {
                // TODO: Add insert logic here
                ventaExterna.Save();
                TempData["mensaje"] = "venta creada correctamente";
                return RedirectToAction("Index", "VentaExterna");

            }
            catch
            {
                return View(ventaExterna);
            }
        }

        // GET: SubastaExterna/Edit/5
        public ActionResult Edit(int id)
        {
            VentaExterna v = new VentaExterna().Find(id);

            if (v == null)
            {
                TempData["mensaje"] = "La subasta no existe";
                return RedirectToAction("Index");
            }
            EnviarOpciones();
            return View(v);
        }

        // POST: Producto/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id,IdOpcion")]VentaExterna ventaExterna)
        {
            try
            {
                // TODO: Add update logic here
                ventaExterna.UpdateOp();
                TempData["mensaje"] = "Opcion modificada correctamente";
                return RedirectToAction("Index");
            }
            catch
            {
                return View(ventaExterna);
            }
        }

        // GET: SubastaExterna/Delete/5
        public ActionResult Delete(int id)
        {
            if (new VentaExterna().Find(id) == null)
            {
                TempData["Mensaje"] = "no existe la venta";
                return RedirectToAction("Index");
            }
            if (new VentaExterna().Delete(id))
            {
                TempData["Mensaje"] = "Eliminacion correcta";
                return RedirectToAction("Index");
            }


            TempData["Mensaje"] = "No se elimino la venta";
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

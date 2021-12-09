using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Mvc;
using WebFeriaVirtual.Negocio;

namespace WebFeriaVirtual.Controllers
{
    public class ProductorController : Controller
    {
        // GET: Productor
        public ActionResult IndexProduct()
        {
            return View();
        }

        public ActionResult ListaProduct()
        {
            ViewBag.productors = new Productor().ReadAll();
            return View();
        }

        public ActionResult CreateProduct()
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult CreateProduct([Bind(Include = "Nombre,Edad,Telefono,Direccion,Correo,Contraseña")]Productor productor)
        {
            try
            {
                // TODO: Add insert logic here
                productor.Save();
                if (productor.Nombre != null & productor.Edad != null & productor.Telefono != null & productor.Direccion != null & productor.Correo != null & productor.Contraseña != null)
                {
                    TempData["mensaje"] = "Usuario Productor guardado correctamente";
                    return RedirectToAction("ListaProduct", "Productor");
                }
                else
                {
                    TempData["mensaje"] = "Favor ingresar datos correctos en el registro";
                    return RedirectToAction("ListaProduct", "Productor");
                }
            }
            catch
            {
                return View(productor);
            }
        }

        public ActionResult LoginProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginProduct(Productor productor, string ReturnUrl)
        {
            if (IsValid(productor))
            {
                FormsAuthentication.SetAuthCookie(productor.Correo, false);
                if (ReturnUrl != null)
                {
                    return Redirect(ReturnUrl);
                }
                return RedirectToAction("IndexProduct", "Productor");
            }
            TempData["Mensaje"] = "Credenciales Incorrectas";
            return View(productor);

        }

        private Boolean IsValid(Productor productor)
        {
            return productor.Autenticar();
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("TipoUsuario", "Home");

        }

        public ActionResult Edit(int id)
        {
            Productor p = new Productor().Find(id);

            if (p == null)
            {
                TempData["mensaje"] = "El usuario no existe";
                return RedirectToAction("ListaUsuInt");
            }

            return View(p);
        }

        // POST: Producto/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id,Nombre, Edad, Telefono, Direccion, Correo, Contraseña")]Productor productor)
        {
            try
            {
                // TODO: Add update logic here
                productor.Update();
                TempData["mensaje"] = "Usuario modificado correctamente";
                return RedirectToAction("ListaProduct");
            }
            catch
            {
                return View(productor);
            }
        }

        // GET: Producto/Delete/5
        public ActionResult Delete(int id)
        {
            if (new Productor().Find(id) == null)
            {
                TempData["Mensaje"] = "no existe el usuario";
                return RedirectToAction("ListaProduct");
            }
            if (new Productor().Delete(id))
            {
                TempData["Mensaje"] = "Eliminacion correcta";
                return RedirectToAction("ListaProduct");
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

                return RedirectToAction("ListaProduct");
            }
            catch
            {
                return View();
            }
        }
    }
}
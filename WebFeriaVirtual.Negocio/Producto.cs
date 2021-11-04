using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFeriaVirtual.DALC;

namespace WebFeriaVirtual.Negocio
{
    public class Producto
    {
        public decimal Id { get; set; }
        public decimal TipoId { get; set; }
        public decimal Stock { get; set; }
        public decimal Precio { get; set; }
        public Tipo Tipo { get; set; }


        FeriaEntities db = new FeriaEntities();
        public List<Producto> ReadAll()
        {
            return this.db.PRODUCTO.Select(p => new Producto()
            {
                Id = p.ID_PRODUCTO,
                TipoId = p.ID_TIPO,
                Stock = p.STOCK_PRODUCTO,
                Precio = p.PRECIO_PRODUCTO,
                Tipo = new Tipo()
                {
                    Id = p.ID_TIPO,
                    Nombre = p.TIPO.NOMBRE_PRODUCTO
                }
            }).ToList();
        }


        public bool Save()
        {
            try
            {
                //llamando al PA para AGREGAR PRODUCTO
                db.AGREGAPRODUCTO(this.TipoId, this.Stock,
                    this.Precio, null);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public Producto Find(int id)
        {
            return this.db.PRODUCTO.Select(p => new Producto()
            {
                Id = p.ID_PRODUCTO,
                TipoId = p.ID_TIPO,
                Stock = p.STOCK_PRODUCTO,
                Precio = p.PRECIO_PRODUCTO,
                Tipo = new Tipo()
                {
                    Id = p.ID_TIPO,
                    Nombre = p.TIPO.NOMBRE_PRODUCTO
                }
            }).Where(p => p.Id == id).FirstOrDefault();
        }

        public bool Update()
        {
            try
            {
                db.ACTUALIZAPRODUCTO(this.Id, this.TipoId, this.Stock,
                    this.Precio, null);

                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }

        public bool Delete(int id)
        {
            try
            {
                db.ELIMINAPRODUCTO(id);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}

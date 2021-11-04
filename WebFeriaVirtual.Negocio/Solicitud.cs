using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFeriaVirtual.DALC;

namespace WebFeriaVirtual.Negocio
{
    public class Solicitud
    {
        public decimal Id { get; set; }
        public decimal TipoId { get; set; }
        public decimal CalidadId { get; set; }
        public decimal Cantidad { get; set; }
        public Tipo Tipo { get; set; }
        public Calidad Calidad { get; set; }

        FeriaEntities db = new FeriaEntities();
        public List<Solicitud> ReadAll()
        {
            return this.db.SOLICITUD.Select(s => new Solicitud()
            {
                Id = s.ID_SOLICITUD,
                TipoId = s.ID_TIPO,
                CalidadId = s.ID_CALIDAD,
                Cantidad = s.CANTIDAD_SOLICITUD,
                Tipo = new Tipo()
                {
                    Id = s.ID_TIPO,
                    Nombre = s.TIPO.NOMBRE_PRODUCTO
                },
                Calidad = new Calidad()
                {
                    Id = s.ID_CALIDAD,
                    Nombre = s.CALIDAD.NOMBRE_CALIDAD
                }
            }).ToList();
        }


        public bool Save()
        {
            try
            {
                //llamando al PA para AGREGAR Solicitud
                db.AGREGASOLICITUD(this.TipoId, this.CalidadId, this.Cantidad);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public Solicitud Find(int id)
        {
            return this.db.SOLICITUD.Select(s => new Solicitud()
            {
                Id = s.ID_SOLICITUD,
                TipoId = s.ID_TIPO,
                CalidadId = s.ID_CALIDAD,
                Cantidad = s.CANTIDAD_SOLICITUD,
                Tipo = new Tipo()
                {
                    Id = s.ID_TIPO,
                    Nombre = s.TIPO.NOMBRE_PRODUCTO
                },
                Calidad = new Calidad()
                {
                    Id = s.ID_CALIDAD,
                    Nombre = s.CALIDAD.NOMBRE_CALIDAD
                }
            }).Where(s => s.Id == id).FirstOrDefault();
        }

        public bool Update()
        {
            try
            {
                db.ACTUALIZASOLICITUD(this.Id, this.TipoId, this.CalidadId, this.Cantidad);

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
                db.ELIMINASOLICITUD(id);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFeriaVirtual.DALC;

namespace WebFeriaVirtual.Negocio
{
    public class Transportista
    {
        public decimal Id { get; set; }
        public String Nombre { get; set; }
        public String Edad { get; set; }
        public String Telefono { get; set; }
        public String Correo { get; set; }
        public String Contraseña { get; set; }
        public decimal IdEmpresa { get; set; }
        public Empresa Empresa { get; set; }

        FeriaEntities db = new FeriaEntities();

        public bool Autenticar()
        {
            return db.TRANSPORTISTA
                .Where(t => t.EMAIL_T== this.Correo
                && t.CONTRASEÑA_T == this.Contraseña)
                .FirstOrDefault() != null;
        }

        public List<Transportista> ReadAll()
        {
            return this.db.TRANSPORTISTA.Select(t => new Transportista()
            {
                Id = t.ID_T,
                Nombre = t.NOMBRE_T,
                Edad = t.EDAD_T,
                Telefono = t.TELEFONO_T,
                Correo = t.EMAIL_T,
                Contraseña = t.CONTRASEÑA_T,
                IdEmpresa = t.ID_EMPRESA,
                Empresa = new Empresa()
                {
                    Id = t.ID_EMPRESA,
                    Nombre = t.EMPRESA.NOMBRE_EMPRESA
                }
            }).ToList();
        }
        public bool Save()
        {
            try
            {
                //llamando al PA para crear usuario Productor
                db.AGREGATRANSPORTISTA(this.Nombre, this.Edad, this.Telefono, this.Correo, this.Contraseña, this.IdEmpresa);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public Transportista Find(int id)
        {
            return this.db.TRANSPORTISTA.Select(t => new Transportista()
            {
                Id = t.ID_T,
                Nombre = t.NOMBRE_T,
                Edad = t.EDAD_T,
                Telefono = t.TELEFONO_T,
                Correo = t.EMAIL_T,
                Contraseña = t.CONTRASEÑA_T,
                IdEmpresa = t.ID_EMPRESA,
                Empresa = new Empresa()
                {
                    Id = t.ID_EMPRESA,
                    Nombre = t.EMPRESA.NOMBRE_EMPRESA
                }
            }).Where(t => t.Id == id).FirstOrDefault();
        }

        public bool Update()
        {
            try
            {
                db.ACTUALIZATRANSPORTISTA(this.Id, this.Nombre, this.Edad, this.Telefono, this.Correo, this.Contraseña, this.IdEmpresa);
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
                db.ELIMINATRANSPORTISTA(id);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}

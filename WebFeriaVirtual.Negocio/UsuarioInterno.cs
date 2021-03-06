using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFeriaVirtual.DALC;

namespace WebFeriaVirtual.Negocio
{
    public class UsuarioInterno
    {
        public decimal Id { get; set; }
        public decimal IdRegion { get; set; }
        public String Nombre { get; set; }
        public String Direccion { get; set; }
        public String Telefono { get; set; }
        public String Correo { get; set; }
        public String Contraseña { get; set; }
        public Region Region { get; set; }

        FeriaEntities db = new FeriaEntities();

        public bool Autenticar()
        {
            return db.CLIENTE_INTERNO
                .Where(u => u.EMAIL_CLIENTE1 == this.Correo
                && u.CONTRASEÑA_CLIENTE1 == this.Contraseña)
                .FirstOrDefault() != null;
        }

        public List<UsuarioInterno> ReadAll()
        {
            return this.db.CLIENTE_INTERNO.Select(c => new UsuarioInterno()
            {
                Id = c.ID_CLIENTE1,
                IdRegion = c.ID_REGION,
                Nombre = c.NOMBRE_CLIENTE1,
                Direccion = c.DIRECCION_CLIENTE1,
                Telefono = c.TELEFONO_CLIENTE1,
                Correo = c.EMAIL_CLIENTE1,
                Contraseña = c.CONTRASEÑA_CLIENTE1,
                Region = new Region()
                {
                    Id = c.ID_REGION,
                    Nombre = c.REGION.NOMBRE_REGION
                }

            }).ToList();
        }
        public bool Save()
        {
            try
            {
                //llamando al PA para crear usuario ClienteInt
                db.AGREGARCLIENTEINT(this.IdRegion, this.Nombre, this.Direccion,
                    this.Telefono, this.Correo, this.Contraseña);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public UsuarioInterno Find(int id)
        {
            return this.db.CLIENTE_INTERNO.Select(c => new UsuarioInterno()
            {
                Id = c.ID_CLIENTE1,
                IdRegion = c.ID_REGION,
                Nombre = c.NOMBRE_CLIENTE1,
                Direccion = c.DIRECCION_CLIENTE1,
                Telefono = c.TELEFONO_CLIENTE1,
                Correo = c.EMAIL_CLIENTE1,
                Contraseña = c.CONTRASEÑA_CLIENTE1,
                Region = new Region()
                {
                    Id = c.ID_REGION,
                    Nombre = c.REGION.NOMBRE_REGION
                }
            }).Where(c => c.Id == id).FirstOrDefault();
        }

        public bool Update()
        {
            try
            {
                db.ACTUALIZAINTERNO(this.Id, this.IdRegion, this.Nombre, this.Direccion,
                    this.Telefono, this.Correo, this.Contraseña);

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
                db.ELIMINAINTERNO(id);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFeriaVirtual.DALC;

namespace WebFeriaVirtual.Negocio
{
    public class UsuarioExterno
    {
        public decimal Id { get; set; }
        public String Nombre { get; set; }
        public String Direccion { get; set; }
        public String Telefono { get; set; }
        public String Correo { get; set; }
        public String Contraseña { get; set; }

        FeriaEntities db = new FeriaEntities();

        public bool Autenticar()
        {
            return db.CLIENTE_EXTERNO
                .Where(e => e.EMAIL_CLIENTE2 == this.Correo
                && e.CONTRASEÑA_CLIENTE2 == this.Contraseña)
                .FirstOrDefault() != null;
        }

        public List<UsuarioExterno> ReadAll()
        {
            return this.db.CLIENTE_EXTERNO.Select(e => new UsuarioExterno()
            {
                Id = e.ID_CLIENTE2,
                Nombre = e.NOMBRE_CLIENTE2,
                Direccion = e.DIRECCION_CLIENTE2,
                Telefono = e.TELEFONO_CLIENTE2,
                Correo = e.EMAIL_CLIENTE2,
                Contraseña = e.CONTRASEÑA_CLIENTE2

            }).ToList();
        }
        public bool Save()
        {
            try
            {
                //llamando al PA para crear usuario ClienteExt
                db.AGREGARCLIENTEEXT(this.Nombre, this.Direccion,
                    this.Telefono, this.Correo, this.Contraseña);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public UsuarioExterno Find(int id)
        {
            return this.db.CLIENTE_EXTERNO.Select(c => new UsuarioExterno()
            {
                Id = c.ID_CLIENTE2,
                Nombre = c.NOMBRE_CLIENTE2,
                Direccion = c.DIRECCION_CLIENTE2,
                Telefono = c.TELEFONO_CLIENTE2,
                Correo = c.EMAIL_CLIENTE2,
                Contraseña = c.CONTRASEÑA_CLIENTE2
            }).Where(c => c.Id == id).FirstOrDefault();
        }

        public bool Update()
        {
            try
            {
                db.ACTUALIZAEXTERNO(this.Id, this.Nombre, this.Direccion,
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
                db.ELIMINAEXTERNO(id);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}

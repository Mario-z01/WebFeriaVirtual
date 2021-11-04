using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFeriaVirtual.DALC;

namespace WebFeriaVirtual.Negocio
{
    public class Productor
    {
        public decimal Id { get; set; }
        public String Nombre { get; set; }
        public String Edad { get; set; }
        public String Telefono { get; set; }
        public String Direccion { get; set; }
        public String Correo { get; set; }
        public String Contraseña { get; set; }

        FeriaEntities db = new FeriaEntities();

        public bool Autenticar()
        {
            return db.PRODUCTOR
                .Where(p => p.EMAIL_P == this.Correo
                && p.CONTRASEÑA_P == this.Contraseña)
                .FirstOrDefault() != null;
        }

        public List<Productor> ReadAll()
        {
            return this.db.PRODUCTOR.Select(p => new Productor()
            {
                Id = p.ID_P,
                Nombre = p.NOMBRE_P,
                Edad = p.EDAD_P,
                Telefono = p.TELEFONO_P,
                Direccion = p.DIRECCION_P,
                Correo = p.EMAIL_P,
                Contraseña = p.CONTRASEÑA_P
            }).ToList();
        }
        public bool Save()
        {
            try
            {
                //llamando al PA para crear usuario Productor
                db.AGREGAPRODUCTOR(this.Nombre,this.Edad,this.Telefono, this.Direccion,this.Correo, this.Contraseña);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public Productor Find(int id)
        {
            return this.db.PRODUCTOR.Select(p => new Productor()
            {
                Id = p.ID_P,
                Nombre = p.NOMBRE_P,
                Edad = p.EDAD_P,
                Telefono = p.TELEFONO_P,
                Direccion = p.DIRECCION_P,
                Correo = p.EMAIL_P,
                Contraseña = p.CONTRASEÑA_P
            }).Where(p => p.Id == id).FirstOrDefault();
        }

        public bool Update()
        {
            try
            {
                db.ACTUALIZAPRODUCTOR(this.Id, this.Nombre, 
                    this.Edad, this.Telefono, this.Direccion, 
                    this.Correo, this.Contraseña);

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
                db.ELIMINAPRODUCTOR(id);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}

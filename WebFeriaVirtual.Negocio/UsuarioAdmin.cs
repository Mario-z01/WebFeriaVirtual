using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFeriaVirtual.DALC;

namespace WebFeriaVirtual.Negocio
{
    public class UsuarioAdmin
    {
        public decimal Id { get; set; }
        public String Usuario { get; set; }
        public String Direccion { get; set; }
        public String Contraseña { get; set; }

        FeriaEntities db = new FeriaEntities();

        public bool Autenticar()
        {
            return db.ADMINISTRADOR
                .Where(a => a.USUARIO_ADMIN == this.Usuario
                && a.CONTRASEÑA_ADMIN == this.Contraseña)
                .FirstOrDefault() != null;
        }
    }

    

}

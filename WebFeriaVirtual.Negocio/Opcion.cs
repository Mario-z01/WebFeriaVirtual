using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFeriaVirtual.DALC;

namespace WebFeriaVirtual.Negocio
{
    public class Opcion
    {
        public decimal Id { get; set; }
        public String Nombre { get; set; }

        FeriaEntities db = new FeriaEntities();

        public List<Opcion> ReadAll()
        {
            return db.OPCION.Select(o => new Opcion()
            {
                Id = o.ID_OPCION,
                Nombre = o.NOMBRE_OPCION
            }).ToList();
        }
    }
}

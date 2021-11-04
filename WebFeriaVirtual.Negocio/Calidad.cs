using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFeriaVirtual.DALC;

namespace WebFeriaVirtual.Negocio
{
    public class Calidad
    {
        public decimal Id { get; set; }
        public String Nombre { get; set; }

        FeriaEntities db = new FeriaEntities();

        public List<Calidad> ReadAll()
        {
            return db.CALIDAD.Select(c => new Calidad()
            {
                Id = c.ID_CALIDAD,
                Nombre = c.NOMBRE_CALIDAD
            }).ToList();
        }
    }
}

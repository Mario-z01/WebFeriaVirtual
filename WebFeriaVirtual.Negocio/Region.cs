using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFeriaVirtual.DALC;

namespace WebFeriaVirtual.Negocio
{
    public class Region
    {
        public decimal Id { get; set; }
        public String Nombre { get; set; }

        FeriaEntities db = new FeriaEntities();

        public List<Region> ReadAll()
        {
            return db.REGION.Select(r => new Region()
            {
                Id = r.ID_REGION,
                Nombre = r.NOMBRE_REGION
            }).ToList();
        }

    }
}

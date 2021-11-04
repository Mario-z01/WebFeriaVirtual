using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFeriaVirtual.DALC;

namespace WebFeriaVirtual.Negocio
{
    public class Tipo
    {
        public decimal Id { get; set; }
        public String Nombre { get; set; }

        FeriaEntities db = new FeriaEntities();

        public List<Tipo> ReadAll()
        {
            return db.TIPO.Select(t => new Tipo()
            {
                Id = t.ID_TIPO,
                Nombre = t.NOMBRE_PRODUCTO
            }).ToList();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFeriaVirtual.DALC;

namespace WebFeriaVirtual.Negocio
{
    public class Empresa
    {
        public decimal Id { get; set; }
        public String Nombre { get; set; }

        FeriaEntities db = new FeriaEntities();

        public List<Empresa> ReadAll()
        {
            return db.EMPRESA.Select(e => new Empresa()
            {
                Id = e.ID_EMPRESA,
                Nombre = e.NOMBRE_EMPRESA
            }).ToList();
        }
    }
}

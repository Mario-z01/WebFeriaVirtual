//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebFeriaVirtual.DALC
{
    using System;
    using System.Collections.Generic;
    
    public partial class TIPO
    {
        public TIPO()
        {
            this.PRODUCTO = new HashSet<PRODUCTO>();
            this.SOLICITUD = new HashSet<SOLICITUD>();
        }
    
        public decimal ID_TIPO { get; set; }
        public string NOMBRE_PRODUCTO { get; set; }
    
        public virtual ICollection<PRODUCTO> PRODUCTO { get; set; }
        public virtual ICollection<SOLICITUD> SOLICITUD { get; set; }
    }
}

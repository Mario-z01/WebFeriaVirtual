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
    
    public partial class TRANSPORTISTA
    {
        public decimal ID_T { get; set; }
        public string NOMBRE_T { get; set; }
        public string EDAD_T { get; set; }
        public string TELEFONO_T { get; set; }
        public string EMAIL_T { get; set; }
        public string CONTRASEÑA_T { get; set; }
        public decimal ID_EMPRESA { get; set; }
    
        public virtual EMPRESA EMPRESA { get; set; }
    }
}
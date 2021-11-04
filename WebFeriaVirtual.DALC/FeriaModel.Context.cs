﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class FeriaEntities : DbContext
    {
        public FeriaEntities()
            : base("name=FeriaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ADMINISTRADOR> ADMINISTRADOR { get; set; }
        public DbSet<CLIENTE_EXTERNO> CLIENTE_EXTERNO { get; set; }
        public DbSet<CLIENTE_INTERNO> CLIENTE_INTERNO { get; set; }
        public DbSet<PRODUCTO> PRODUCTO { get; set; }
        public DbSet<TIPO> TIPO { get; set; }
        public DbSet<CALIDAD> CALIDAD { get; set; }
        public DbSet<SOLICITUD> SOLICITUD { get; set; }
        public DbSet<PRODUCTOR> PRODUCTOR { get; set; }
    
        public virtual int AGREGAPRODUCTO(Nullable<decimal> tIPOID, Nullable<decimal> sTOCKPRODUCTO, Nullable<decimal> pRECIOPRODUCTO, string iMAGENPRODUCTO)
        {
            var tIPOIDParameter = tIPOID.HasValue ?
                new ObjectParameter("TIPOID", tIPOID) :
                new ObjectParameter("TIPOID", typeof(decimal));
    
            var sTOCKPRODUCTOParameter = sTOCKPRODUCTO.HasValue ?
                new ObjectParameter("STOCKPRODUCTO", sTOCKPRODUCTO) :
                new ObjectParameter("STOCKPRODUCTO", typeof(decimal));
    
            var pRECIOPRODUCTOParameter = pRECIOPRODUCTO.HasValue ?
                new ObjectParameter("PRECIOPRODUCTO", pRECIOPRODUCTO) :
                new ObjectParameter("PRECIOPRODUCTO", typeof(decimal));
    
            var iMAGENPRODUCTOParameter = iMAGENPRODUCTO != null ?
                new ObjectParameter("IMAGENPRODUCTO", iMAGENPRODUCTO) :
                new ObjectParameter("IMAGENPRODUCTO", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AGREGAPRODUCTO", tIPOIDParameter, sTOCKPRODUCTOParameter, pRECIOPRODUCTOParameter, iMAGENPRODUCTOParameter);
        }
    
        public virtual int AGREGAPRODUCTOR(string nOMPRODUCTOR, string eDADPRODUCTOR, string tELEFONOPRODUCTOR, string dIREPRODUCTOR, string eMAILPRODUCTOR, string cONTRAPRODUCTOR)
        {
            var nOMPRODUCTORParameter = nOMPRODUCTOR != null ?
                new ObjectParameter("NOMPRODUCTOR", nOMPRODUCTOR) :
                new ObjectParameter("NOMPRODUCTOR", typeof(string));
    
            var eDADPRODUCTORParameter = eDADPRODUCTOR != null ?
                new ObjectParameter("EDADPRODUCTOR", eDADPRODUCTOR) :
                new ObjectParameter("EDADPRODUCTOR", typeof(string));
    
            var tELEFONOPRODUCTORParameter = tELEFONOPRODUCTOR != null ?
                new ObjectParameter("TELEFONOPRODUCTOR", tELEFONOPRODUCTOR) :
                new ObjectParameter("TELEFONOPRODUCTOR", typeof(string));
    
            var dIREPRODUCTORParameter = dIREPRODUCTOR != null ?
                new ObjectParameter("DIREPRODUCTOR", dIREPRODUCTOR) :
                new ObjectParameter("DIREPRODUCTOR", typeof(string));
    
            var eMAILPRODUCTORParameter = eMAILPRODUCTOR != null ?
                new ObjectParameter("EMAILPRODUCTOR", eMAILPRODUCTOR) :
                new ObjectParameter("EMAILPRODUCTOR", typeof(string));
    
            var cONTRAPRODUCTORParameter = cONTRAPRODUCTOR != null ?
                new ObjectParameter("CONTRAPRODUCTOR", cONTRAPRODUCTOR) :
                new ObjectParameter("CONTRAPRODUCTOR", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AGREGAPRODUCTOR", nOMPRODUCTORParameter, eDADPRODUCTORParameter, tELEFONOPRODUCTORParameter, dIREPRODUCTORParameter, eMAILPRODUCTORParameter, cONTRAPRODUCTORParameter);
        }
    
        public virtual int AGREGARCLIENTEEXT(string nOMCLIENTE2, string dIRECLIENTE2, string fONOCLIENTE2, string cORREOCLIENTE2, string cONTRACLIENTE2)
        {
            var nOMCLIENTE2Parameter = nOMCLIENTE2 != null ?
                new ObjectParameter("NOMCLIENTE2", nOMCLIENTE2) :
                new ObjectParameter("NOMCLIENTE2", typeof(string));
    
            var dIRECLIENTE2Parameter = dIRECLIENTE2 != null ?
                new ObjectParameter("DIRECLIENTE2", dIRECLIENTE2) :
                new ObjectParameter("DIRECLIENTE2", typeof(string));
    
            var fONOCLIENTE2Parameter = fONOCLIENTE2 != null ?
                new ObjectParameter("FONOCLIENTE2", fONOCLIENTE2) :
                new ObjectParameter("FONOCLIENTE2", typeof(string));
    
            var cORREOCLIENTE2Parameter = cORREOCLIENTE2 != null ?
                new ObjectParameter("CORREOCLIENTE2", cORREOCLIENTE2) :
                new ObjectParameter("CORREOCLIENTE2", typeof(string));
    
            var cONTRACLIENTE2Parameter = cONTRACLIENTE2 != null ?
                new ObjectParameter("CONTRACLIENTE2", cONTRACLIENTE2) :
                new ObjectParameter("CONTRACLIENTE2", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AGREGARCLIENTEEXT", nOMCLIENTE2Parameter, dIRECLIENTE2Parameter, fONOCLIENTE2Parameter, cORREOCLIENTE2Parameter, cONTRACLIENTE2Parameter);
        }
    
        public virtual int AGREGARCLIENTEINT(string nOMCLIENTE1, string dIRECLIENTE1, string fONOCLIENTE1, string cORREOCLIENTE1, string cONTRACLIENTE1)
        {
            var nOMCLIENTE1Parameter = nOMCLIENTE1 != null ?
                new ObjectParameter("NOMCLIENTE1", nOMCLIENTE1) :
                new ObjectParameter("NOMCLIENTE1", typeof(string));
    
            var dIRECLIENTE1Parameter = dIRECLIENTE1 != null ?
                new ObjectParameter("DIRECLIENTE1", dIRECLIENTE1) :
                new ObjectParameter("DIRECLIENTE1", typeof(string));
    
            var fONOCLIENTE1Parameter = fONOCLIENTE1 != null ?
                new ObjectParameter("FONOCLIENTE1", fONOCLIENTE1) :
                new ObjectParameter("FONOCLIENTE1", typeof(string));
    
            var cORREOCLIENTE1Parameter = cORREOCLIENTE1 != null ?
                new ObjectParameter("CORREOCLIENTE1", cORREOCLIENTE1) :
                new ObjectParameter("CORREOCLIENTE1", typeof(string));
    
            var cONTRACLIENTE1Parameter = cONTRACLIENTE1 != null ?
                new ObjectParameter("CONTRACLIENTE1", cONTRACLIENTE1) :
                new ObjectParameter("CONTRACLIENTE1", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AGREGARCLIENTEINT", nOMCLIENTE1Parameter, dIRECLIENTE1Parameter, fONOCLIENTE1Parameter, cORREOCLIENTE1Parameter, cONTRACLIENTE1Parameter);
        }
    
        public virtual int ACTUALIZAPRODUCTO(Nullable<decimal> iDPRODUCTO, Nullable<decimal> tIPOID, Nullable<decimal> sTOCKPRODUCTO, Nullable<decimal> pRECIOPRODUCTO, string iMAGENPRODUCTO)
        {
            var iDPRODUCTOParameter = iDPRODUCTO.HasValue ?
                new ObjectParameter("IDPRODUCTO", iDPRODUCTO) :
                new ObjectParameter("IDPRODUCTO", typeof(decimal));
    
            var tIPOIDParameter = tIPOID.HasValue ?
                new ObjectParameter("TIPOID", tIPOID) :
                new ObjectParameter("TIPOID", typeof(decimal));
    
            var sTOCKPRODUCTOParameter = sTOCKPRODUCTO.HasValue ?
                new ObjectParameter("STOCKPRODUCTO", sTOCKPRODUCTO) :
                new ObjectParameter("STOCKPRODUCTO", typeof(decimal));
    
            var pRECIOPRODUCTOParameter = pRECIOPRODUCTO.HasValue ?
                new ObjectParameter("PRECIOPRODUCTO", pRECIOPRODUCTO) :
                new ObjectParameter("PRECIOPRODUCTO", typeof(decimal));
    
            var iMAGENPRODUCTOParameter = iMAGENPRODUCTO != null ?
                new ObjectParameter("IMAGENPRODUCTO", iMAGENPRODUCTO) :
                new ObjectParameter("IMAGENPRODUCTO", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ACTUALIZAPRODUCTO", iDPRODUCTOParameter, tIPOIDParameter, sTOCKPRODUCTOParameter, pRECIOPRODUCTOParameter, iMAGENPRODUCTOParameter);
        }
    
        public virtual int ACTUALIZATIPO(Nullable<decimal> iDTIPO, string nOMBRETIPO)
        {
            var iDTIPOParameter = iDTIPO.HasValue ?
                new ObjectParameter("IDTIPO", iDTIPO) :
                new ObjectParameter("IDTIPO", typeof(decimal));
    
            var nOMBRETIPOParameter = nOMBRETIPO != null ?
                new ObjectParameter("NOMBRETIPO", nOMBRETIPO) :
                new ObjectParameter("NOMBRETIPO", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ACTUALIZATIPO", iDTIPOParameter, nOMBRETIPOParameter);
        }
    
        public virtual int AGREGATIPO(string nOMBRETIPO)
        {
            var nOMBRETIPOParameter = nOMBRETIPO != null ?
                new ObjectParameter("NOMBRETIPO", nOMBRETIPO) :
                new ObjectParameter("NOMBRETIPO", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AGREGATIPO", nOMBRETIPOParameter);
        }
    
        public virtual int ELIMINAPRODUCTO(Nullable<decimal> iDPRODUCTO)
        {
            var iDPRODUCTOParameter = iDPRODUCTO.HasValue ?
                new ObjectParameter("IDPRODUCTO", iDPRODUCTO) :
                new ObjectParameter("IDPRODUCTO", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ELIMINAPRODUCTO", iDPRODUCTOParameter);
        }
    
        public virtual int ELIMINARTIPO(Nullable<decimal> iDTIPO)
        {
            var iDTIPOParameter = iDTIPO.HasValue ?
                new ObjectParameter("IDTIPO", iDTIPO) :
                new ObjectParameter("IDTIPO", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ELIMINARTIPO", iDTIPOParameter);
        }
    
        public virtual int ACTUALIZASOLICITUD(Nullable<decimal> iDSOLICITUD, Nullable<decimal> tIPOID, Nullable<decimal> cALIDADID, Nullable<decimal> cANTIDADSOLICITUD)
        {
            var iDSOLICITUDParameter = iDSOLICITUD.HasValue ?
                new ObjectParameter("IDSOLICITUD", iDSOLICITUD) :
                new ObjectParameter("IDSOLICITUD", typeof(decimal));
    
            var tIPOIDParameter = tIPOID.HasValue ?
                new ObjectParameter("TIPOID", tIPOID) :
                new ObjectParameter("TIPOID", typeof(decimal));
    
            var cALIDADIDParameter = cALIDADID.HasValue ?
                new ObjectParameter("CALIDADID", cALIDADID) :
                new ObjectParameter("CALIDADID", typeof(decimal));
    
            var cANTIDADSOLICITUDParameter = cANTIDADSOLICITUD.HasValue ?
                new ObjectParameter("CANTIDADSOLICITUD", cANTIDADSOLICITUD) :
                new ObjectParameter("CANTIDADSOLICITUD", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ACTUALIZASOLICITUD", iDSOLICITUDParameter, tIPOIDParameter, cALIDADIDParameter, cANTIDADSOLICITUDParameter);
        }
    
        public virtual int AGREGASOLICITUD(Nullable<decimal> tIPOID, Nullable<decimal> cALIDADID, Nullable<decimal> cANTIDADSOLICITUD)
        {
            var tIPOIDParameter = tIPOID.HasValue ?
                new ObjectParameter("TIPOID", tIPOID) :
                new ObjectParameter("TIPOID", typeof(decimal));
    
            var cALIDADIDParameter = cALIDADID.HasValue ?
                new ObjectParameter("CALIDADID", cALIDADID) :
                new ObjectParameter("CALIDADID", typeof(decimal));
    
            var cANTIDADSOLICITUDParameter = cANTIDADSOLICITUD.HasValue ?
                new ObjectParameter("CANTIDADSOLICITUD", cANTIDADSOLICITUD) :
                new ObjectParameter("CANTIDADSOLICITUD", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AGREGASOLICITUD", tIPOIDParameter, cALIDADIDParameter, cANTIDADSOLICITUDParameter);
        }
    
        public virtual int ELIMINASOLICITUD(Nullable<decimal> iDSOLICITUD)
        {
            var iDSOLICITUDParameter = iDSOLICITUD.HasValue ?
                new ObjectParameter("IDSOLICITUD", iDSOLICITUD) :
                new ObjectParameter("IDSOLICITUD", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ELIMINASOLICITUD", iDSOLICITUDParameter);
        }
    
        public virtual int ACTUALIZAEXTERNO(Nullable<decimal> iDCLIENTE2, string nOMCLIENTE2, string dIRECLIENTE2, string fONOCLIENTE2, string cORREOCLIENTE2, string cONTRACLIENTE2)
        {
            var iDCLIENTE2Parameter = iDCLIENTE2.HasValue ?
                new ObjectParameter("IDCLIENTE2", iDCLIENTE2) :
                new ObjectParameter("IDCLIENTE2", typeof(decimal));
    
            var nOMCLIENTE2Parameter = nOMCLIENTE2 != null ?
                new ObjectParameter("NOMCLIENTE2", nOMCLIENTE2) :
                new ObjectParameter("NOMCLIENTE2", typeof(string));
    
            var dIRECLIENTE2Parameter = dIRECLIENTE2 != null ?
                new ObjectParameter("DIRECLIENTE2", dIRECLIENTE2) :
                new ObjectParameter("DIRECLIENTE2", typeof(string));
    
            var fONOCLIENTE2Parameter = fONOCLIENTE2 != null ?
                new ObjectParameter("FONOCLIENTE2", fONOCLIENTE2) :
                new ObjectParameter("FONOCLIENTE2", typeof(string));
    
            var cORREOCLIENTE2Parameter = cORREOCLIENTE2 != null ?
                new ObjectParameter("CORREOCLIENTE2", cORREOCLIENTE2) :
                new ObjectParameter("CORREOCLIENTE2", typeof(string));
    
            var cONTRACLIENTE2Parameter = cONTRACLIENTE2 != null ?
                new ObjectParameter("CONTRACLIENTE2", cONTRACLIENTE2) :
                new ObjectParameter("CONTRACLIENTE2", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ACTUALIZAEXTERNO", iDCLIENTE2Parameter, nOMCLIENTE2Parameter, dIRECLIENTE2Parameter, fONOCLIENTE2Parameter, cORREOCLIENTE2Parameter, cONTRACLIENTE2Parameter);
        }
    
        public virtual int ACTUALIZAINTERNO(Nullable<decimal> iDCLIENTE1, string nOMCLIENTE1, string dIRECLIENTE1, string fONOCLIENTE1, string cORREOCLIENTE1, string cONTRACLIENTE1)
        {
            var iDCLIENTE1Parameter = iDCLIENTE1.HasValue ?
                new ObjectParameter("IDCLIENTE1", iDCLIENTE1) :
                new ObjectParameter("IDCLIENTE1", typeof(decimal));
    
            var nOMCLIENTE1Parameter = nOMCLIENTE1 != null ?
                new ObjectParameter("NOMCLIENTE1", nOMCLIENTE1) :
                new ObjectParameter("NOMCLIENTE1", typeof(string));
    
            var dIRECLIENTE1Parameter = dIRECLIENTE1 != null ?
                new ObjectParameter("DIRECLIENTE1", dIRECLIENTE1) :
                new ObjectParameter("DIRECLIENTE1", typeof(string));
    
            var fONOCLIENTE1Parameter = fONOCLIENTE1 != null ?
                new ObjectParameter("FONOCLIENTE1", fONOCLIENTE1) :
                new ObjectParameter("FONOCLIENTE1", typeof(string));
    
            var cORREOCLIENTE1Parameter = cORREOCLIENTE1 != null ?
                new ObjectParameter("CORREOCLIENTE1", cORREOCLIENTE1) :
                new ObjectParameter("CORREOCLIENTE1", typeof(string));
    
            var cONTRACLIENTE1Parameter = cONTRACLIENTE1 != null ?
                new ObjectParameter("CONTRACLIENTE1", cONTRACLIENTE1) :
                new ObjectParameter("CONTRACLIENTE1", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ACTUALIZAINTERNO", iDCLIENTE1Parameter, nOMCLIENTE1Parameter, dIRECLIENTE1Parameter, fONOCLIENTE1Parameter, cORREOCLIENTE1Parameter, cONTRACLIENTE1Parameter);
        }
    
        public virtual int ELIMINAEXTERNO(Nullable<decimal> iDCLIENTE2)
        {
            var iDCLIENTE2Parameter = iDCLIENTE2.HasValue ?
                new ObjectParameter("IDCLIENTE2", iDCLIENTE2) :
                new ObjectParameter("IDCLIENTE2", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ELIMINAEXTERNO", iDCLIENTE2Parameter);
        }
    
        public virtual int ELIMINAINTERNO(Nullable<decimal> iDCLIENTE1)
        {
            var iDCLIENTE1Parameter = iDCLIENTE1.HasValue ?
                new ObjectParameter("IDCLIENTE1", iDCLIENTE1) :
                new ObjectParameter("IDCLIENTE1", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ELIMINAINTERNO", iDCLIENTE1Parameter);
        }
    
        public virtual int ACTUALIZAPRODUCTOR(Nullable<decimal> iDPRODUCTOR, string nOMPRODUCTOR, string eDADPRODUCTOR, string tELEFONOPRODUCTOR, string dIREPRODUCTOR, string eMAILPRODUCTOR, string cONTRAPRODUCTOR)
        {
            var iDPRODUCTORParameter = iDPRODUCTOR.HasValue ?
                new ObjectParameter("IDPRODUCTOR", iDPRODUCTOR) :
                new ObjectParameter("IDPRODUCTOR", typeof(decimal));
    
            var nOMPRODUCTORParameter = nOMPRODUCTOR != null ?
                new ObjectParameter("NOMPRODUCTOR", nOMPRODUCTOR) :
                new ObjectParameter("NOMPRODUCTOR", typeof(string));
    
            var eDADPRODUCTORParameter = eDADPRODUCTOR != null ?
                new ObjectParameter("EDADPRODUCTOR", eDADPRODUCTOR) :
                new ObjectParameter("EDADPRODUCTOR", typeof(string));
    
            var tELEFONOPRODUCTORParameter = tELEFONOPRODUCTOR != null ?
                new ObjectParameter("TELEFONOPRODUCTOR", tELEFONOPRODUCTOR) :
                new ObjectParameter("TELEFONOPRODUCTOR", typeof(string));
    
            var dIREPRODUCTORParameter = dIREPRODUCTOR != null ?
                new ObjectParameter("DIREPRODUCTOR", dIREPRODUCTOR) :
                new ObjectParameter("DIREPRODUCTOR", typeof(string));
    
            var eMAILPRODUCTORParameter = eMAILPRODUCTOR != null ?
                new ObjectParameter("EMAILPRODUCTOR", eMAILPRODUCTOR) :
                new ObjectParameter("EMAILPRODUCTOR", typeof(string));
    
            var cONTRAPRODUCTORParameter = cONTRAPRODUCTOR != null ?
                new ObjectParameter("CONTRAPRODUCTOR", cONTRAPRODUCTOR) :
                new ObjectParameter("CONTRAPRODUCTOR", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ACTUALIZAPRODUCTOR", iDPRODUCTORParameter, nOMPRODUCTORParameter, eDADPRODUCTORParameter, tELEFONOPRODUCTORParameter, dIREPRODUCTORParameter, eMAILPRODUCTORParameter, cONTRAPRODUCTORParameter);
        }
    
        public virtual int ELIMINAPRODUCTOR(Nullable<decimal> iDPRODUCTOR)
        {
            var iDPRODUCTORParameter = iDPRODUCTOR.HasValue ?
                new ObjectParameter("IDPRODUCTOR", iDPRODUCTOR) :
                new ObjectParameter("IDPRODUCTOR", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ELIMINAPRODUCTOR", iDPRODUCTORParameter);
        }
    }
}

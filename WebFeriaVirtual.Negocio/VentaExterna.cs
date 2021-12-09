using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFeriaVirtual.DALC;

namespace WebFeriaVirtual.Negocio
{
    public class VentaExterna
    {
        public decimal Id { get; set; }
        public DateTime Fecha { get; set; }
        public decimal IdCliente2 { get; set; }
        public decimal Precio { get; set; }
        public decimal IdProducto { get; set; }
        public decimal IdSolicitud { get; set; }
        public decimal IdOpcion { get; set; }
        public UsuarioExterno UsuarioExterno { get; set; }
        public Producto Producto { get; set; }
        public Solicitud Solicitud { get; set; }
        public Opcion Opcion { get; set; }

        FeriaEntities db = new FeriaEntities();
        public List<VentaExterna> ReadAll()
        {
            return this.db.VENTA_EXT.Select(s => new VentaExterna()
            {
                Id = s.ID_VENTAE,
                Fecha = s.FECHA_VENTAE,
                IdCliente2 = s.ID_CLIENTE2,
                Precio = s.PRECIO_VENTAE,
                IdProducto = s.ID_PRODUCTO,
                IdSolicitud = s.ID_SOLICITUD,
                IdOpcion = s.ID_OPCION,
                UsuarioExterno = new UsuarioExterno()
                {
                    Id = s.ID_CLIENTE2,
                    Nombre = s.CLIENTE_EXTERNO.NOMBRE_CLIENTE2,
                    Pais = s.CLIENTE_EXTERNO.NOM_PAIS,
                    Direccion = s.CLIENTE_EXTERNO.DIRECCION_CLIENTE2,
                    Telefono = s.CLIENTE_EXTERNO.TELEFONO_CLIENTE2,
                    Correo = s.CLIENTE_EXTERNO.EMAIL_CLIENTE2,
                    Contraseña = s.CLIENTE_EXTERNO.CONTRASEÑA_CLIENTE2
                },
                Producto = new Producto()
                {
                    Id = s.ID_PRODUCTO,
                    TipoId = s.PRODUCTO.ID_TIPO,
                    Stock = s.PRODUCTO.STOCK_PRODUCTO,
                    Precio = s.PRODUCTO.PRECIO_PRODUCTO,
                    Tipo = new Tipo()
                    {
                        Id = s.PRODUCTO.ID_TIPO,
                        Nombre = s.PRODUCTO.TIPO.NOMBRE_PRODUCTO
                    }
                },
                Solicitud = new Solicitud()
                {
                    Id = s.ID_SOLICITUD,
                    TipoId = s.SOLICITUD.ID_TIPO,
                    CalidadId = s.SOLICITUD.ID_CALIDAD,
                    Cantidad = s.SOLICITUD.CANTIDAD_SOLICITUD,
                    Tipo = new Tipo()
                    {
                        Id = s.SOLICITUD.ID_TIPO,
                        Nombre = s.SOLICITUD.TIPO.NOMBRE_PRODUCTO
                    },
                    Calidad = new Calidad()
                    {
                        Id = s.SOLICITUD.ID_CALIDAD,
                        Nombre = s.SOLICITUD.CALIDAD.NOMBRE_CALIDAD
                    }
                },
                Opcion = new Opcion()
                {
                    Id = s.ID_OPCION,
                    Nombre = s.OPCION.NOMBRE_OPCION
                }
        }).ToList();
        }


        public bool Save()
        {
            try
            {
                //llamando al PA para AGREGAR PRODUCTO
                db.AGREGAVENTAE(DateTime.Now,this.IdCliente2,this.Precio,this.IdProducto,this.IdSolicitud,this.IdOpcion);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public VentaExterna Find(int id)
        {
            return this.db.VENTA_EXT.Select(s => new VentaExterna()
            {
                Id = s.ID_VENTAE,
                Fecha = s.FECHA_VENTAE,
                IdCliente2 = s.ID_CLIENTE2,
                Precio = s.PRECIO_VENTAE,
                IdProducto = s.ID_PRODUCTO,
                IdSolicitud = s.ID_SOLICITUD,
                IdOpcion = s.ID_OPCION,
                UsuarioExterno = new UsuarioExterno()
                {
                    Id = s.ID_CLIENTE2,
                    Nombre = s.CLIENTE_EXTERNO.NOMBRE_CLIENTE2,
                    Pais = s.CLIENTE_EXTERNO.NOM_PAIS,
                    Direccion = s.CLIENTE_EXTERNO.DIRECCION_CLIENTE2,
                    Telefono = s.CLIENTE_EXTERNO.TELEFONO_CLIENTE2,
                    Correo = s.CLIENTE_EXTERNO.EMAIL_CLIENTE2,
                    Contraseña = s.CLIENTE_EXTERNO.CONTRASEÑA_CLIENTE2
                },
                Producto = new Producto()
                {
                    Id = s.ID_PRODUCTO,
                    TipoId = s.PRODUCTO.ID_TIPO,
                    Stock = s.PRODUCTO.STOCK_PRODUCTO,
                    Precio = s.PRODUCTO.PRECIO_PRODUCTO,
                    Tipo = new Tipo()
                    {
                        Id = s.PRODUCTO.ID_TIPO,
                        Nombre = s.PRODUCTO.TIPO.NOMBRE_PRODUCTO
                    }
                },
                Solicitud = new Solicitud()
                {
                    Id = s.ID_SOLICITUD,
                    TipoId = s.SOLICITUD.ID_TIPO,
                    CalidadId = s.SOLICITUD.ID_CALIDAD,
                    Cantidad = s.SOLICITUD.CANTIDAD_SOLICITUD,
                    Tipo = new Tipo()
                    {
                        Id = s.SOLICITUD.ID_TIPO,
                        Nombre = s.SOLICITUD.TIPO.NOMBRE_PRODUCTO
                    },
                    Calidad = new Calidad()
                    {
                        Id = s.SOLICITUD.ID_CALIDAD,
                        Nombre = s.SOLICITUD.CALIDAD.NOMBRE_CALIDAD
                    }
                },
                Opcion = new Opcion()
                {
                    Id = s.ID_OPCION,
                    Nombre = s.OPCION.NOMBRE_OPCION
                }
            }).Where(s => s.Id == id).FirstOrDefault();
        }

        public bool Update()
        {
            try
            {
                db.ACTUALIZAVENTAE(this.Id, this.Precio);

                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public bool UpdateOp()
        {
            try
            {
                db.ACTUALIZAOPCION(this.Id, this.IdOpcion);

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
                db.ELIMINAVENTAE(id);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}

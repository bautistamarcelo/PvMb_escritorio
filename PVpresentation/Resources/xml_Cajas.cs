using Microsoft.Extensions.DependencyInjection;
using PVpresentation.Resources;
using PVpresentation.ViewModels;
using PVrepository.Entities;
using PVservices.Interfaces;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PVpresentation.Resources
{
    public class xml_Cajas
    {   //VALORES PARA CAJA
        //@Nombre varchar(50),   
        //@FechaApertura date = null,
        //@SaldoInicial int=0,  
        //@FechaCierre date = null,
        //@SaldoFinal int=null,  
        //@Condicion varchar(8)='Abierta',  
        //@UsuarioID int,  

        //VALORES PARA CAJA USUARIOS
        //@CajaID int,  
        //@UsuarioID int,  
        //@FechaAsignacion date,
        //@Estado varchar(7), --Valores(Abierta / Cerrada)

        //VALORES PARA CAJA TRANSACCIONES Y CAJA MOVIMIENTOS
        //@ID int=0,  
        //@CajaID int,  
        //@TipoID int,  
        //@Caracter varchar(5),--Valores(suma / resta)
        //@Monto int,  
        //@Fecha date = getdate,
        //@Descripcion varchar(50),  

        //VALORES PARA CAJA MONEDA TRANSACCIONES Y CAJA MONEDA MOVIMIENTOS
        //@Efectivo int=0,  
        //@Tarjeta int=0,  
        //@Debito int=0,  
        //@CtaCte int=0,  


        //XElement Caja = new XElement("Caja",
        //            new XElement("Fecha", txtFecha.Text.Trim()),
        //            new XElement("Tipo", _tipo.ToString()),
        //            new XElement("Numero", "001-1025"),
        //            new XElement("SubTotal", Convert.ToInt32(txtSubTotal.Text.Trim())),
        //            new XElement("DtoEfectivo", Convert.ToInt32(txtDtoEfectivo.Text.Trim())),
        //            new XElement("Bruto", Convert.ToInt32(txtBruto.Text.Trim())),
        //            new XElement("DtoGeneral", Convert.ToInt32(txtDtoGral.Text.Trim())),
        //            new XElement("Monto", Convert.ToInt32(txtMontoFinal.Text.Trim())),
        //            new XElement("Tefectivo", Convert.ToInt32(txtTefectivo.Text.Trim())),
        //            new XElement("Tdebito", Convert.ToInt32(txtTdebito.Text.Trim())),
        //            new XElement("Ttarjeta", txtTtarjeta.Text.Trim()),
        //            new XElement("Tcredito", Convert.ToInt32(txtTctaCte.Text.Trim())),
        //            new XElement("Situacion", 0),//Values: 0;"Grabada";1;"Pendiente";2;"Facturada";3;"Anulada"
        //            new XElement("ClienteID", _ClienteID),
        //            new XElement("ClienteNombre", _ClienteNombre),
        //            new XElement("ClienteDomicilio", _ClienteDomicilio),
        //            new XElement("VendedorID", VariablesGlobales.UsuarioID),
        //            new XElement("SucursalID", VariablesGlobales.SucursalID),
        //            new XElement("CajaID", VariablesGlobales.CajaID),
        //            new XElement("ListaID", _lista.ToString())
        //            );
        //    XElement VentaDetalle = new XElement("VentaDetalle");
        //        foreach (Venta_D_VM item in _VentaDetalle)
        //        {
        //            VentaDetalle.Add(new XElement("Item",
        //                new XElement("ProductoID", item.ProductoID),
        //                new XElement("Cantidad", item.Cantidad),
        //                new XElement("pOferta", item.pOferta),
        //                new XElement("pVenta", item.pVenta),
        //                new XElement("pTotalOferta", item.pTotalOferta),
        //                new XElement("pTotalVenta", item.pTotalVenta),
        //                new XElement("SucursalID", VariablesGlobales.SucursalID)
        //                )
        //             );
        //        }
        //Venta.Add(VentaDetalle);
    }
}

﻿using PVrepository.Entities;

namespace PVrepository.Interfaces
{
    //TODO: Implementar la interfaz
    public interface IVentas_E_repository
    {
        //Task<List<Ventas_E>> ListarFechas(DateTime FechaIni, DateTime FechaFin);
        Task<int> Registrar(string ventaXml);
        Task<Ventas_E> Obtener(int VentasID);
        Task<List<Ventas_D>>ObtenerDetalleVenta(int VentasID);


    }
}

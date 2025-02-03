using Microsoft.Extensions.DependencyInjection;
using PVrepository.DB;
using PVrepository.Implementation;
using PVrepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVrepository
{
    public static class DependencyInjection
    {
        public static void RegisterInjeccionesRepository(this IServiceCollection services)
        {
            services.AddSingleton<Conexion>();
            services.AddTransient<ICajasRepository, CajasRepository>();
            services.AddTransient<ICajas_VMrepository, Cajas_VMrepository>();
            services.AddTransient<ICajas_Detalle_VMrepository, Cajas_Detalle_VMrepository>();
            services.AddTransient<ICajasMonedaMrepository, CajasMonedaMrepository>();
            services.AddTransient<ICajasMonedaTrepository, CajasMonedaTrepository>();
            services.AddTransient<ICajasMovimientosRepository, CajasMovimientosRepository>();
            services.AddTransient<ICajasTipoRepository, CajasTipoRepository>();
            services.AddTransient<ICajasTransaccionesRepository, CajasTransaccionesRepository>();
            services.AddTransient<ICajasUsuariosRepository, CajasUsuariosRepository>();
            services.AddTransient<ICaracterRepository, CaracterRepository>();
            services.AddTransient<ICategoriaRepository, CategoriaRepository>();
            services.AddTransient<IClientesRepository, ClientesRepository>();
            services.AddTransient<IEmpresaRepository, EmpresaRepository>();
            services.AddTransient<IImpuestosRepository, ImpuestosRepository>();
            services.AddTransient<IListasRepository, ListasRepository>();
            services.AddTransient<IMarcasRepository, MarcasRepository>();
            services.AddTransient<IProductosRepository, ProductosRepository>();
            services.AddTransient<IProveedoresRepository, ProveedoresRepository>();
            services.AddTransient<IRolRepository, RolRepository>();
            services.AddTransient<ISucursalesRepository, SucursalesRepository>();
            services.AddTransient<ITramitesRepository, TramitesRepository>();
            services.AddTransient<IUsuariosRepository, UsuariosRepository>();
            services.AddTransient<IVentas_E_repository, Ventas_E_respository>();
            //TODO: Agregar las interfaces de Ventas y Ventas Detalles
        }
    }
}

using Microsoft.Extensions.DependencyInjection;
using PVrepository.Interfaces;
using PVservices.Implementation;
using PVservices.Interfaces;

namespace PVservices
{
    public static class DependencyInjection
    {
        public static void RegisterInjeccionesServices(this IServiceCollection services)
        {
            services.AddTransient<ICajasService, CajasService>();
            services.AddTransient<ICajas_Detalle_VMservice, Cajas_Detalle_VMservice>();
            services.AddTransient<ICajas_VMservice, Cajas_VMservice>();
            services.AddTransient<ICajasMonedaMservice, CajasMonedaMservice>();
            services.AddTransient<ICajasMonedaTservice, CajasMonedaTservice>();
            services.AddTransient<ICajasMovimientosService, CajasMovimientosService>();
            services.AddTransient<ICajasTipoService, CajasTipoService>();
            services.AddTransient<ICajasTransaccionesService, CajasTransaccionesService>();
            services.AddTransient<ICajasUsuariosService, CajasUsuariosService>();
            services.AddTransient<ICaracterService, CaracterService>();
            services.AddTransient<ICategoriaService, CategoriaService>();
            services.AddTransient<IClientesService, ClientesService>();
            services.AddTransient<ICloudinaryService, CloudinaryService>();
            services.AddTransient<IComprasService,  ComprasService>();
            services.AddTransient<IEmpresaService, EmpresaService>();
            services.AddTransient<IImpuestosService, ImpuestosService>();
            services.AddTransient<IListasService, ListasService>();
            services.AddTransient<IMarcasService, MarcasService>();
            services.AddTransient<IProductosService, ProductosService>();
            services.AddTransient<IProveedoresService, ProveedoresServices>();
            services.AddTransient<IRolService, RolService>();
            services.AddTransient<ISucursalesService, SucursalesService>();
            services.AddTransient<ITramitesService, TramitesService>();
            services.AddTransient<IUsuariosService, UsuariosService>();
            services.AddTransient<IVenta_E_Service, Venta_E_Service>();
        }
    }
}

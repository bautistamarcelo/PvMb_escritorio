using Microsoft.Extensions.DependencyInjection;
using PVrepository.DB;
using PVrepository.Implementation;
using PVrepository.Interfaces;
using PVservices.Implementation;
using PVservices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVservices
{
    public static class DependencyInjection
    {
        public static void RegisterInjeccionesServices(this IServiceCollection services)
        {
            services.AddTransient<ICaracterService, CaracterService>();
            services.AddTransient<ICategoriaService, CategoriaService>();
            services.AddTransient<IClientesService, ClientesService>();
            services.AddTransient<IEmpresaService, EmpresaService>();
            services.AddTransient<IImpuestosService, ImpuestosService>();
            services.AddTransient<IMarcasService, MarcasService>();
            services.AddTransient<IProductosService, ProductosService>();
            services.AddTransient<IProveedoresService, ProveedoresServices>();
            services.AddTransient<IRolService, RolService>();
            services.AddTransient<ISucursalesService, SucursalesService>();
            services.AddTransient<ITramitesService, TramitesService>();
            services.AddTransient<IUsuariosService, UsuariosService>();
        }
    }
}

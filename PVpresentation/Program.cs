using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PVpresentation.Formularios;
using PVpresentation.Formularios.Modelos;
using PVrepository;
using PVrepository.Implementation;
using PVrepository.Interfaces;
using PVservices;
using PVservices.Implementation;
using PVservices.Interfaces;
using System.Runtime.Serialization;

namespace PVpresentation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var host = CreateHostBuilder().Build();
            var FormServices = host.Services.GetRequiredService<Frm_Login>();
            Application.Run(FormServices);
        }

        static IHostBuilder CreateHostBuilder() => Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration((context, config) =>
            {
                config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            })
            .ConfigureServices((context, services) =>
            {
                services.RegisterInjeccionesRepository();
                services.RegisterInjeccionesServices();
                services.AddTransient<FrmModeloCRUD>();
                services.AddTransient<Frm_Cajas>();
                services.AddTransient<Frm_Categorias>();
                services.AddTransient<Frm_Clientes>();
                services.AddTransient<Frm_Empresas>();
                services.AddTransient<Frm_Login>();
                services.AddTransient<Frm_Main>();
                services.AddTransient<Frm_Marcas>();
                services.AddTransient<Frm_Productos>();
                services.AddTransient<Frm_Proveedores>();
                services.AddTransient<Frm_Sucursales>();
                services.AddTransient<Frm_Usuarios>();
            });
    }
}
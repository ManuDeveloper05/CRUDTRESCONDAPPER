using CRUDTRES.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using Serilog;
using Serilog.Events;
using System;

namespace CRUDTRES
{
    internal static class Program
    {
       
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.UnhandledException += (sender, args) =>
            {
                var exception = (Exception)args.ExceptionObject;
                Log.Error(exception, "Excepción no manejada en otro hilo");
            };

            try
            {
                Log.Logger = new LoggerConfiguration()
                    .MinimumLevel.Debug()
                    .WriteTo.Console()
                    .WriteTo.File("bin/logArchivo.txt", rollingInterval: RollingInterval.Day)
                    .CreateLogger();

                var configuration = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json")
                    .Build();

                var serviceCollection = new ServiceCollection();
                serviceCollection.AddScoped<ISqlConnectionFactory, SqlConnectionFactory>();
                serviceCollection.AddScoped<ICustomersData, CustomersData>();
                serviceCollection.AddScoped<Form1>();
                serviceCollection.AddScoped<CustomersForm>();
                serviceCollection.AddScoped<IConfiguration>((e) => configuration);

                var serviceProvider = serviceCollection.BuildServiceProvider();

                ApplicationConfiguration.Initialize();

                var form1 = serviceProvider.GetService<CustomersForm>();
                Application.Run(form1);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "La aplicación falló al iniciar");
              
            }


        }
    }
}
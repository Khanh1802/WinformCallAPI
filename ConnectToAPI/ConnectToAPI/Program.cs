using ConnectToAPI.Deletegate;
using ConnectToAPI.FormHomePages;
using ConnectToAPI.FormLogins;
using ConnectToAPI.FormProducts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ConnectToAPI
{
    public static class Program
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
            ServiceProvider = host.Services;
            Application.Run(ServiceProvider.GetRequiredService<FormLogin>());
        }
        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
          .ConfigureServices((context, services) =>
          {
              services.AddMemoryCache(option =>
              {
              });
              services.AddTransient<FormLogin>();
              services.AddTransient<FormHomePage>();
              services.AddTransient<CafeManagementHandler>();
              services.AddTransient<FormAddProduct>();

              //services.AddHttpClient();

              services.AddHttpClient<FormLogin>(opts =>
              {
                  opts.BaseAddress = new Uri(context.Configuration["CafeManagement:Endpoint"]);
              });

              services.AddHttpClient<FormProduct>(opts =>
              {
                  opts.BaseAddress = new Uri(context.Configuration["CafeManagement:Endpoint"]);
              })
              // Add Handler
              .AddHttpMessageHandler<CafeManagementHandler>();

              services.AddHttpClient<FormAddProduct>(opt =>
              {
                  opt.BaseAddress = new Uri(context.Configuration["CafeManagement:Endpoint"]);
              })
              .AddHttpMessageHandler<CafeManagementHandler>();
          });
        }
    }
}
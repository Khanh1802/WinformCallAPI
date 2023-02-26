using CafeManagement.Application.Contracts.Services;
using CafeManagement.Applications.Services;
using CafeManagement.Shared.Options;
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

              #region Register Dependency
              services.AddSingleton<FormProduct>();
              services.AddTransient<FormLogin>();
              services.AddTransient<FormHomePage>();
              services.AddTransient<CafeManagementHandler>();
              services.AddTransient<FormAddProduct>();
              services.AddTransient<IProductService, ProductService>();
              services.AddTransient<IUserService, UserService>();
              #endregion


              #region HttpClient
              services.AddHttpClient<IProductService, ProductService>(opt =>
              {
                  opt.BaseAddress = new Uri(context.Configuration["CafeManagement:Endpoint"]);
              }).AddHttpMessageHandler<CafeManagementHandler>();

              services.Configure<OptionsCafeManagement>(context.Configuration.GetSection("CafeManagement"));

              services.AddHttpClient<IUserService, UserService>(opt =>
              {
                  opt.BaseAddress = new Uri(context.Configuration["CafeManagement:Endpoint"]);
              });
              
          });
            #endregion
        }
    }
}
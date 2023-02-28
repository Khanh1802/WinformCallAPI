using CafeManagement.Application.Contracts.Services;
using CafeManagement.Applications.Services;
using CafeManagement.Shared.Options;
using ConnectToAPI.Deletegate;
using ConnectToAPI.FormHomePages;
using ConnectToAPI.FormInventories;
using ConnectToAPI.FormLogins;
using ConnectToAPI.FormProducts;
using ConnectToAPI.FormWarehouses;
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
              services.AddTransient<FormWarehouse>();
              services.AddTransient<FormAddWarehouse>();
              services.AddTransient<FormInventory>();
              services.AddTransient<IProductService, ProductService>();
              services.AddTransient<IUserService, UserService>();
              services.AddTransient<IWarehouseService, WarehouseService>();
              services.AddTransient<IInventoryService, InventoryService>();
              #endregion


              #region HttpClient
              services.AddHttpClient<IProductService, ProductService>(opt =>
              {
                  opt.BaseAddress = new Uri(context.Configuration["CafeManagement:EndPoint"]);
              }).AddHttpMessageHandler<CafeManagementHandler>(); // addToken                        

              services.AddHttpClient<IWarehouseService, WarehouseService>(opt =>
              {
                  opt.BaseAddress = new Uri(context.Configuration["CafeManagement:EndPoint"]);
              }).AddHttpMessageHandler<CafeManagementHandler>(); // addToken

              services.AddHttpClient<IUserService, UserService>(opt =>
              {
                  opt.BaseAddress = new Uri(context.Configuration["CafeManagement:EndPoint"]);
              });

              services.AddHttpClient<IInventoryService, InventoryService>(opt =>
              {
                  opt.BaseAddress = new Uri(context.Configuration["CafeManagement:EndPoint"]);
              }).AddHttpMessageHandler<CafeManagementHandler>();
              #endregion

              #region Options
              services.Configure<OptionsLogins>(context.Configuration.GetSection("CafeManagement"));
              services.Configure<OptionsProductst>(context.Configuration.GetSection("CafeManagement:Products"));
              services.Configure<OptionsWarehouses>(context.Configuration.GetSection("CafeManagement:Warehouses"));
              services.Configure<OptionsInventories>(context.Configuration.GetSection("CafeManagement:Inventories"));
              #endregion

          });
        }
    }
}
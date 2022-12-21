using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MVVMToolkitTest2.ViewModels;
using MVVMToolkitTest2.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MVVMToolkitTest2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var builder = new HostBuilder()
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    IHostEnvironment env = hostingContext.HostingEnvironment;
                    config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                    config.AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true);
                    config.AddEnvironmentVariables();
                })
                .ConfigureServices((_, services) =>
                {
                    services.AddSingleton<MainViewModel>();
                    services.AddTransient<LogInViewModel>();
                    services.AddSingleton<MainView>();
                    services.AddTransient<LogInView>();
                });
            var host = builder.Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var mainView = services.GetRequiredService<MainView>();
                    mainView.Show();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error has occurred: {ex.Message}");
                }
            }
        }
    }
}

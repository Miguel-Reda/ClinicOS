// App.xaml.cs
using System;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;

namespace ClinicOS
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            // Configure dependency injection
            var services = new ServiceCollection();
            ConfigureServices(services);
            var serviceProvider = services.BuildServiceProvider();

            // Start the application
            var mainWindow = serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }

        private void ConfigureServices(ServiceCollection services)
        {
            // Register your services here
            services.AddTransient<MainWindow>();
            // Add other services as needed
        }
    }
}
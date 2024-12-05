using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace EmailSender
{
    class Program
    {
        static void Main(string[] args)
        {
            IServiceCollection services = new ServiceCollection();

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            DependencyContainer.Configure(services);

            var serviceProvider = services.BuildServiceProvider();

            var notificationService = serviceProvider.GetService<NotificationService>();
            notificationService?.Notify("Hello, World!");

        }
    }
}

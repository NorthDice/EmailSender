using Microsoft.Extensions.DependencyInjection;
using System;

namespace EmailSender
{
    class Program
    {
        static void Main(string[] args)
        {
            IServiceCollection services = new ServiceCollection();

            DependencyContainer.Configure(services);

            var serviceProvider = services.BuildServiceProvider();

            var notificationService = serviceProvider.GetService<NotificationService>();
            notificationService?.Notify("Hello, World!");

        }
    }
}

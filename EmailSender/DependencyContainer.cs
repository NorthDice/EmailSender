using EmailSender;
using Microsoft.Extensions.DependencyInjection;

public static class DependencyContainer
{
    public static IServiceCollection Configure(IServiceCollection services)
    {

        services.AddTransient<NotificationService>();
        services.AddTransient<IMessageService, EmailService>();
        services.AddTransient<ILogger, ConsoleLogger>();

        return services;
    }
}

using Mango.Services.EmailAPI.Messaging;
using Microsoft.Extensions.DependencyInjection;

namespace Mango.Services.EmailAPI.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        private static IAzureServiceBusConsumer ServiceBusConsumer { get; set; }

        public static IApplicationBuilder UseAzureserviceBusConsumer(this IApplicationBuilder app)
        {
            ServiceBusConsumer = app.ApplicationServices.GetService<IAzureServiceBusConsumer>();
            var hostapplicationLife = app.ApplicationServices.GetService<IHostApplicationLifetime>();

            hostapplicationLife.ApplicationStarted.Register(OnStart);
            hostapplicationLife.ApplicationStopping.Register(OnStop);
             
            return app;
        }

        private static void OnStop()
        {
            ServiceBusConsumer.Stop();
        }

        private static void OnStart()
        {
            ServiceBusConsumer.Start(); 
        }
    }
}

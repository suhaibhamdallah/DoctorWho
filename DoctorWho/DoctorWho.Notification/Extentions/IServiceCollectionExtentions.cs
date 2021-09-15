using DoctorWho.Notification.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DoctorWho.Notification.Extentions
{
    public static class IServiceCollectionExtentions
    {
        public static void AddEmailSenderServices(this IServiceCollection services)
        {
            services.AddTransient<IEmailSenderService, EmailSenderService>();
        }
    }
}

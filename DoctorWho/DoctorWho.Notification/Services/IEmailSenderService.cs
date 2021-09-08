using System.Threading.Tasks;

namespace DoctorWho.Notification.Services
{
    public interface IEmailSenderService
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage, bool isBodyHTML);
    }
}

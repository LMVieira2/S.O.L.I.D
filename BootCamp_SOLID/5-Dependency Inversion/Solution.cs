namespace BootCamp_SOLID._5_Dependency_Inversion
{
    public interface INotificationService
    {
        void NotifyUser(string to, string message);
    }

    public class EmailServiceS : INotificationService
    {
        public void NotifyUser(string to, string message)
        {
            SendEmail(to, "Notification", message);
        }

        private void SendEmail(string to, string subject, string body)
        {
        }
    }

    public class UserController
    {
        private readonly INotificationService _notificationService;

        public UserController(INotificationService notificationService)
        {
            _notificationService = notificationService; // Dependência abstrata
        }

        public void NotifyUser(string to, string message)
        {
            _notificationService.NotifyUser(to, message);
        }
    }
}

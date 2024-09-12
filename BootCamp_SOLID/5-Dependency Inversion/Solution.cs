namespace BootCamp_SOLID._5_Dependency_Inversion
{
    public interface INotificationService //Abstração
    {
        void NotifyUser(string to, string message);
    }

    public class EmailServiceS : INotificationService //Implementação concreta que segue a abstração
    {
        public void NotifyUser(string to, string message)
        {
            SendEmail(to, "Notification", message);
        }

        private void SendEmail(string to, string subject, string body)
        {
        }
    }

    public class UserController //Classe que consome o serviço agora depende da abstração. Modulo de alto nivel
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

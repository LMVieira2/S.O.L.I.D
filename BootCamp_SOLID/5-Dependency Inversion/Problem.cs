//Dependa de abstrações e não de implementações.
//Módulos de alto nível não devem depender de módulos de baixo nível. Ambos devem depender da abstração.
//Abstrações não devem depender de detalhes. Detalhes devem depender de abstrações.



namespace BootCamp_SOLID._5_Dependency_Inversion
{
    public class EmailService
    {
        public void SendEmail(string to, string subject, string body)
        {
            // Lógica para enviar e-mail
        }
    }

    public class NotificationService
    {
        private readonly EmailService _emailService;

        public NotificationService()
        {
            _emailService = new EmailService(); // Dependência concreta
        }

        public void NotifyUser(string to, string message)
        {
            _emailService.SendEmail(to, "Notification", message);
        }
    }
}

//Erros:
//1. NotificationService está dependendo de EmailService, que é uma dependência concreta.
//Isso viola o DIP porque NotificationService deveria depender de uma abstração (interface) em vez de uma classe concreta.
//2. Se quisermos mudar a implementação de EmailService, teremos que mudar a classe NotificationService também.
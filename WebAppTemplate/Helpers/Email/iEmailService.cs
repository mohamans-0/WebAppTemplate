namespace WebAppTemplate.Helpers.Email
{
    public interface iEmailService
    {
        void SendEmail(string toEmail, string Message , string subject);
    }
}

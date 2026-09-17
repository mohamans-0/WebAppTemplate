using System.Net;
using System.Net.Mail;
using System.Runtime.Intrinsics.X86;

namespace WebAppTemplate.Helpers.Email
{
    public class EmailService : iEmailService
    {
        public void SendEmail(string toEmail, string Message, string subject)
        {
            // FromEmail
            // ToEmail
            // Gmail 
            // SMTP Info
            // mohmadmans29@gmail.com
            // 123 , AppPassword : nryg drzo duvy pkjx


            // Server	smtp.gmail.com
            // Port    587(TLS) or 465(SSL)
            // TLS 

            var smtpServer = "smtp.gmail.com";
            var smtpPort = 587;
            var Email = "mohmadmans29@gmail.com";
            var Password = "";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            SmtpClient SmtpClient = new SmtpClient(smtpServer, smtpPort);
            SmtpClient.UseDefaultCredentials = false;
            SmtpClient.Credentials = new NetworkCredential(Email, Password);
            SmtpClient.EnableSsl = true;

            var htmlMessage = $@"
        <div style='
            font-family: Arial, sans-serif;
            padding: 30px;
            text-align: center;
        '>

            <h2>Reset Password</h2>

            <p>
                You requested to reset your password.
            </p>

            <p>
                Click the button below to continue:
            </p>

            <a href='{Message}'
               style='
                   display: inline-block;
                   padding: 12px 25px;
                   background-color: #0099aa;
                   color: white;
                   text-decoration: none;
                   border-radius: 5px;
                   font-weight: bold;
               '>
                Reset Password
            </a>

            <p style='margin-top: 20px;'>
                If you did not request this, you can ignore this email.
            </p>

        </div>
    ";


            // Message
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(Email);
            mailMessage.To.Add(new MailAddress(toEmail));
            mailMessage.Subject = subject;
            mailMessage.Body = htmlMessage;

            mailMessage.IsBodyHtml = true;

            SmtpClient.Send(mailMessage);


        }
    }
}

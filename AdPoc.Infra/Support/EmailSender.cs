using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity.UI.Services;
using MimeKit;
using System.Threading.Tasks;

namespace AdPoc.Infra.Support
{
    public class EmailSender : IEmailSender
    {
        // Our private configuration variables
        private string host;
        private int port;
        private bool enableSSL;
        private string userName;
        private string password;

        // Get our parameterized configuration
        public EmailSender()
        {
            this.host = "smtp.gmail.com";
            this.port = 587;
            this.enableSSL = false;
            this.userName = "manish.joshi10@ongraphmail.com";
            this.password = "manish@2019";
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var message = new MimeMessage();
            message.To.Add(new MailboxAddress(email));
            var bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = htmlMessage;
            
            message.Body = bodyBuilder.ToMessageBody();

            message.Subject = subject;
            message.From.Add(new MailboxAddress("Manish Joshi", "manish.joshi@ongraphmail.com"));
            using (var client = new SmtpClient())
            {
                // For demo-purposes, accept all SSL certificates (in case the server supports STARTTLS)
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                client.Connect("smtpout.secureserver.net", 0, false);

                // Note: only needed if the SMTP server requires authentication
                client.Authenticate("manish.joshi@ongraphmail.com", "manish@2019");

                client.Send(message);

                client.Disconnect(true);

            }
            return Task.FromResult(0);
        }
    }
}

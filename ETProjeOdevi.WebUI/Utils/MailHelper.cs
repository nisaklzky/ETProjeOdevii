using Et.Core.Entities;
using System.Net;
using System.Net.Mail;

namespace ETProjeOdevi.WebUI.Utils
{
    public class MailHelper
    {
        public static async Task SendMailAsync(Contact contact)
        {
            SmtpClient smtpClient = new SmtpClient("mail.BanaUygun.com", 875);
            smtpClient.Credentials = new NetworkCredential("BanaUygun.com", "mailşifresi");
            smtpClient.EnableSsl = false;
            MailMessage message = new MailMessage();
            message.From = new MailAddress("BanaUygun.com");
            message.To.Add("BanaUygun.com");
            message.Subject = "BanaUygun.com mesaj geldi";
            message.Body = $"İsim: { contact.Name} - Soyadı: { contact.Surname} - Email: { contact.Email} -Telefon: { contact.Apple} - Mesaj: { contact.Message}";
            message.IsBodyHtml = true;
            await smtpClient.SendMailAsync(message);
            smtpClient.Dispose();
        }
    }
}

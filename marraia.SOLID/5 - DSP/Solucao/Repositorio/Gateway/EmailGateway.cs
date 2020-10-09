using marraia.SOLID._5___DSP.Solucao.Repositorio.Gateway.Interfaces;
using System.Net.Mail;

namespace marraia.SOLID._5___DSP.Solucao.Repositorio.Gateway
{
    public class EmailGateway : IEmailGateway
    {
        public void EnvioEmail(string de, string para, string assunto, string mensagem)
        {
            var mail = new MailMessage(de, para);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = assunto;
            mail.Body = mensagem;
            client.Send(mail);
        }
    }
}

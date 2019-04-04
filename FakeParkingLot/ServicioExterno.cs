using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;

namespace FakeParkingLot
{
    class ServicioExterno
    {
        public static bool EnviarMail(String asunto, String cuerpo, String destinatario)
        {

            String from = "fakeparkinglot@gmail.com";
            String pass = "parkinglot123";
            
            /// Configuracion
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);

            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(from, pass);
            client.EnableSsl = true;

            // Mail
            MailMessage msg = new MailMessage();

            try
            {
                msg.From = new MailAddress(from);
                msg.To.Add(destinatario);
                msg.Subject = asunto;
                msg.IsBodyHtml = true;
                msg.BodyEncoding = System.Text.Encoding.UTF8;
                msg.Body = cuerpo;
                msg.Priority = MailPriority.Normal;
                client.Send(msg);

                return true;

            }
            catch (Exception exp)
            {
                Console.WriteLine(exp);
                return false;
            }
        }
    }
}

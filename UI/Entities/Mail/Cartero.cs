using System;
using System.Net;
using System.Net.Mail;

namespace Entities
{
  public class Cartero {


      private const string SendersAddress = "ordendelcasuario@gmail.com";


      private const string SendersPassword = "!L@ordenD3lCasuario*..";

      public string ReceiversAddress { set; get; }

      public string subject { set; get; }

      public string body { set; get; }

        public void enviarCarta() {


            try
            {

                //gmails smtp server name = smtp.gmail.com, port number = 587

                SmtpClient smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new NetworkCredential(SendersAddress, SendersPassword),
                    Timeout = 3000
                };

                //MailMessage representa un correo...
                //Ocupa 4 parametros(From,TO,subject,body)

                MailMessage message = new MailMessage(SendersAddress, ReceiversAddress, subject, body);
               

                smtp.Send(message);
                Console.WriteLine("Correo enviado exitosamente.");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }

        }





    }
}

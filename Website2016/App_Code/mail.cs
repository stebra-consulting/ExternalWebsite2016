using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Text;

/// <summary>
/// Summary description for mail
/// </summary>
public class mail
{
    public mail()
    {


        SmtpClient client = new SmtpClient();
        client.Port = 25;
        client.Host = "smtp.gmail.com";
        client.EnableSsl = true;
        client.Timeout = 10000;
        client.DeliveryMethod = SmtpDeliveryMethod.Network;
        client.UseDefaultCredentials = false;
        client.Credentials = new System.Net.NetworkCredential("felix.freye@gmail.com", "moffeludd4");

        MailMessage mm = new MailMessage("donotreply@domain.com", "felix.freye@gmail.com", "test", "test");
        mm.BodyEncoding = UTF8Encoding.UTF8;
        mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

        client.Send(mm);
    }
}
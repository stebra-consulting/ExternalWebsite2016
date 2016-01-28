using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

/// <summary>
/// Summary description for Mail
/// </summary>
public class Mail
{
    public static string String() {
        return "Hello world";
    }
    public static string Send(string name, string email, string comments)
    {

        try
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("felix.freye@gmail.com");
            mail.To.Add("info@stebra.se");
            mail.Subject = "Meddelade från stebra.se";
            mail.Body = comments + " FROM " + email;

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("felix.freye@gmail.com", "XXX");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
            return "sent";
        }
        catch (Exception ex)
        {
            return ex.ToString();
        }
        
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using System.Net;

namespace nafisi.me.Controllers
{
    public class homeController : Controller
    {
        public static string Email_Configurations_Host = "smtp.mandrillapp.com";
        public static int Email_Configurations_Port = 587;
        public static string Email_Configurations_User = "shayan.nafisi@gmail.com";
        public static string Email_Configurations_Password = "ac43467e-66f7-4d7b-9d34-86dfb5075db3";
        public static string Email_Disaply_Name = "Shayan Nafisi";
        //
        // GET: /Default1/

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Send_Message(FormCollection collection)
        {
            try
            {
                string email_body = collection["message"];
                Send_Email(collection["email"], collection["name"], "shayan.nafisi@gmail.com", collection["email"], email_body, "Resume Enquiry");
            }
            catch
            {

            }
            return Redirect("/");
        }


        public static void Send_Email(string from_address, string from_name, string to_address, string reply_to, string email_body, string email_subject)
        {
            MailMessage msg = new MailMessage(from_address.Trim(), to_address.Trim())
            {
                Subject = email_subject,
                Body = email_body,
            };
            msg.From = new MailAddress(from_address, from_name);
            msg.IsBodyHtml = true;

            SmtpClient client = new SmtpClient();
            client.Credentials = new NetworkCredential(Email_Configurations_User, Email_Configurations_Password);
            client.Host = Email_Configurations_Host;
            client.Port = Email_Configurations_Port;
            client.Send(msg);






        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mail
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.Port = 587; // or 465 for SSL
                smtpClient.Credentials = new NetworkCredential("babua8405@gmail.com", "yehk mqfv bzxw wrmw");
                smtpClient.EnableSsl = true;

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("babua8405@gmail.com");
                mailMessage.To.Add("aravi0428@gmail.com");
                mailMessage.Subject = "Testing";
                mailMessage.Body = "Handshake";

                // Send the email
                smtpClient.Send(mailMessage);

                Label1.Text = "Email sent successfully!";
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }


        }
    }
}
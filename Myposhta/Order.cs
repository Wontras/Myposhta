using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myposhta
{
    class Order : Client
    {
        public Order() { }//swap Order - Mail
        //public void MakeOrder(Sender s, string trekcode, string address = "PostOffice1")
        //{
        //    Mail mail = new Mail();
        //    mail.SenderName = s.Name;
        //    mail.Trekcode = trekcode;
        //    InformSender(s, ref mail);
        //    MailContext db = new MailContext();
        //    db.Mails.Add(mail);
        //    db.SaveChanges();
        //}
        //public void InformSender(Sender s, ref Mail c)
        //{
        //    s.NextSender = c.Trekcode;
        //}

        new public void sleep()
        {//2.5
            string s = "Is sleeping";
        }
    }
}

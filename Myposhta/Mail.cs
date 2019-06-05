using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Myposhta
{

    class MailContext : DbContext
    {
        public MailContext()
            : base("DbConnection")
        { }

        public DbSet<Mail> Mails { get; set; }
    }

    public class  Mail : Parcel
    {
        [Key]
        public int Id { get; set; }

        public string City1 { get; set; }
        public string City2 { get; set; }
        public string Status { get; set; }

        public int Height { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int Price { get; set; }
        public bool Packaging { get; set; }

        public bool Backmail { get; set; }
        public Sender Snd { get; set; }
        public int? SenderId { get; set; }

        public Mail()
        {

        }
        delegate int Tax(int price);
        Tax pdv = (price) => Convert.ToInt32(price * 1.4);
    }
}

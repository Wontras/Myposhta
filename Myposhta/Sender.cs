using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Myposhta
{
    class SenderContext : DbContext
    {
        public SenderContext()
            : base("DbConnection")
        { }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Sender> Senders { get; set; }
    }
    public class Sender 
    {
        public Sender() {
            Ml = new List<Mail>();
        }
        [Key]
        [ForeignKey("Cl")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string CardNumber { get; set; }
        public Client Cl { get; set; }
        public ICollection<Mail> Ml { get; set; }
    }
}


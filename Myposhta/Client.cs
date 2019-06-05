using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Myposhta
{
    
    public class Client
    {
        public int Id { get; set; }

        public string Password { get; set; }

        public string Login { get; set; }
        
        public Sender Sd { get; set; }
    }

}

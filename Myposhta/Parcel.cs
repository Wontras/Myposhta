using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myposhta
{
    public class Parcel
    {
        
        public int Mass { get; set; }
      
        public Parcel() { }

        virtual public void sleep() { }
    }
}

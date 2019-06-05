using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myposhta
{
    interface IUserInfo
    {
        string Surname
        {
            get;
            set;
        }

        string this[int index]
        {
            get;
            set;
        }
    }
}

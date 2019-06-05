using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myposhta
{
    interface IAccount
    {
        int CurrentSum { get; }  // Поточна сума на рахунку
        void Put(int sum);      // Поповнити рхунок
        void Withdraw(int sum); // Взяти з рахунку
    }
}

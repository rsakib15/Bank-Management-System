using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    class Savings:Account
    {
        public Savings() : base()
        {

        }

        public override bool deposit(double amount)
        {
            return true;
        }

        public override bool withdraw(double amount)
        {
            return false;
        }
    }
}

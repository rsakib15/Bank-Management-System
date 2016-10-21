using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    class Debit:Account
    {
        private double maxBalance;
        private double dailyTransLimit;
        private DateTime prevTransDate = new DateTime(2010, 7, 5);
        private DateTime currentTransDate;
        private double dayTrans = 0;

        public Debit() : base()
        {

        }

        public Debit(string name, DOB DOB, string nominee, double balance) : base(name, DOB, nominee, balance)
        {

        }


        private bool isDailyTransLimitOver(double amount)
        {
            return true;
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

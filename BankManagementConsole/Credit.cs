using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    class Credit:Account
    {
        private double minBalance = -100000;
        private double dailyWithdrawLimit = 20000;
        private DateTime prevTransDate = new DateTime(2010, 7, 5);
        private DateTime currentTransDate;
        private double dayWithdraw = 0;
        public Credit() : base()
        {
        }
        public Credit(string name, DOB DOB, string nominee, double balance) : base(name, DOB, nominee, balance)
        {
        }
        private bool isDailyWithdrawLimitOver(double amount)
        {
            return true;
        }
        public override bool deposit(double amount)
        {
            return true;
        }
        public override bool withdraw(double amount)
        {
            return true;
        }
    }
}

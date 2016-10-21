using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Design a class called "Credit"(withdraw money from bank) from “Account” with the following functionalities: // 
+default constructor
+parameterized constructor
+ bool deposit(double amount)//if the amount can be successfully deposited to the balance return true, else false
+ bool withdraw(double amount)//if the amount can be successfully withdraw from the balance return true, else false
+void printAccount()//prints all the account info

***Credit account’s min balance is -100000 and no upper limit, daily Cash withdraw limit is 20000

 * 
*/

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

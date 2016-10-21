using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Design a class called "Debit"(deposited money in bank) from “Account” with the following functionalities:
+default constructor
+parameterized constructor
+ bool deposit(double amount)//if the amount can be successfully deposited to the balance return true, else false
+ bool withdraw(double amount)//if the amount can be successfully withdraw from the balance return true, else false
+void printAccount()//prints all the account info
***debit account’s max balance is 100000 and daily transaction limit is 20000

*/

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Design an abstract class called "account" with the following functionalities:
+default constructor
+parameterized constructor
+[p] [read only]name
+[p] [read only]ID(auto generated)
+[p] [read only]DOB (do not use system object)
+[p] [read only]nominee
+[p] [read only] [read only]double balance
+ abstract bool deposit(double amount)//if the amount can be successfully deposited to the balance return true, else false
+ abstract bool withdraw(double amount)//if the amount can be successfully withdraw from the balance return true, else false
+void printAccount()//prints all the account info

 * */

namespace BankManagement
{
    abstract class Account
    {
        private readonly string name;
        private readonly string ID;
        private readonly DOB dob;
        private readonly string nominee;
        private readonly double balance;
        protected string type;

        public Account()
        {

        }

        public Account(string name, DOB dob, string nominee, double balance)
        {
            this.name = name;
            this.dob = dob;
            this.nominee = nominee;
            this.balance = balance;
        }
        public abstract bool deposit(double amount)
        {

        }
        public abstract bool withdraw(double amount)
        {

        }
        public double getBalance()
        {
            return this.balance;
        }
        public string getAccType()
        {
            return this.type;
        }
        public void printAccount()
        {
            Console.WriteLine("Account Information");
        }
    }
}

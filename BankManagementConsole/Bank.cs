using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    class Bank
    {

        public ArrayList accArr = new ArrayList();

        private Account GetAcc(string ID)
        {
            return this.
        }

        public Account this[string ID]
        {
        }

        public void create_account()
        {
            int accType;
            string name;
            int d, m, y;
            string nominee;
            double balance;
            Console.WriteLine("0. Debit Account");
            Console.WriteLine("1. Credit Account");
            Console.WriteLine("2. Savings Account");


            switch (accType)
            {
                case 0:
                case 1:
                case 2:
                default:
            }

        }
        public void deposit(string ID, double amount)
        {

        }

        public void withdraw(string ID, double amount)
        {

        }

        public void print(string ID)
        {

        }

        public void printAllAccount()
        {

        }
    }

    public class ArrayList
    {
    }
}

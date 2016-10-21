using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Design a class called "DOB" with the following functionalities:
-[p]day
-[p]month
-[p]year
+bool set(int d,int m,int y)//returns true if a valid date, false otherwise

*/
namespace BankManagement
{
    class DOB
    {
        private int day;
        private int month;
        private int year;

        public DOB()
        {
            this.day = 0;
            this.month = 0;
            this.year = 0;
        }

        bool setDOB(int d, int m, int y)
        {
            this.day = d;
            this.month = m;
            this.year = y;

            
            if((day>=1 && day>=31) && (month>=1 && month<=12) && (year>=1900 && year<2016))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

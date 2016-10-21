using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Design a static class called "IDGENARATOR" with the following functionalities:
-static int serial_no
+String generate()//this method will automatically generates an ID for an account
the format will be "YYYY-MM-SSSSS".
example: if the serial number is 1 and date is september,2012 the auto gen ID will be "2012-09-00001".
         if the serial number is 102 and date is januray,2013 the auto gen ID will be "2012-09-00102".
*** please reset the serial no to 1 if the month is changed
*** assume other variable if needed (you must need another one)

Help:
Use DateTime class
Use DateTime.Now to get the current datetime from the system.

*/

namespace BankManagement
{
    public static class IdGenarator
    {
        private static int serialNo=1;
        

        public static string generate()
        {
            string id;
            id = DateTime.Today.ToString("yyyy-MM-dd");

            if (DateTime.Today.ToString("dd") == "01")
            {
                serialNo = 1;
            }          

            if (serialNo < 100)
            {
                if (serialNo < 10)
                    id += "00" + serialNo;
                else
                    id += "0" + serialNo;
            }
            else
            {
                id += serialNo;
            }         

            serialNo++;
            return id;
        }
    }
}

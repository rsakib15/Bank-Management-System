using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

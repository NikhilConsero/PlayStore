using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayStore
{
    public class Report
    {
        public void GetReport<T>(T reportId)
        {
            
        }
        public void GetReport2<T1,T2>(T1 reportId1, T2 reportId2)
        {


        }
        public void GenerateReport() 
        {
            string data = "Report1,Report2,Report3";
            string[] ot=data.Split(",");
            foreach (string item in ot)
            {
                Console.WriteLine(item);
            }
        }


    }
}

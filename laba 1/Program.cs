using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    
    
        static void Main(string[] args)
        {
        // task //1.1//
            int day, month;
            day = Convert.ToInt32(Console.ReadLine());
            month = Convert.ToInt32(Console.ReadLine());
            string result = (day > 0) && (day < 31) && (month > 0) && (month < 12) ?
            "Значення можуть представляти день і місяць" : "Значення не можуть представляти день і місяць";
            Console.WriteLine(result);

        
    
             // task //1.2//

        }



}
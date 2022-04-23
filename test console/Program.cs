using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_console
{
   class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Eded {x.Counter()} Reqemlidir");
           
            Console.ReadKey();
        }

    

    }
   static class Extention
    {
        public static int Counter(this int num)
        {
          int count = 0;
            while (num!=0)
            {
                count++;
                num = num / 10;
            }
            return count;
        }
    
    }
}
 


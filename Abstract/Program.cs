using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {

            string a = "test";
            int b  ;
            int.TryParse(a, out  b);
            Console.WriteLine(b);
            Console.ReadKey();
        }

       
        
    }

}

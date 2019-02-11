using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca_assgn
{
    class Program
    {
        static void Main(string[] args)
        {

           Console.WriteLine( Convert.ToString(  PrintSum(1111,101,0) ));
         

        }

        //private static int multiply_optimal(int a, int b)
        //{
        //    if (a == 0 || b == 0)
        //        return 0;
        //    if (b == 1)
        //        return a;
        //    if (b % 2 == 0)
        //        return multiply_optimal(a + a, b >> 1);
        //    else
        //        return a + multiply_optimal(a + a, b >> 1);

        //}

        private static int PrintSum(int a, int b, int result)
        {
            Convert.ToString(a, 2);
            Convert.ToString(b, 2);
            if (b == 0)
                return result;
            if ((b & 1) == 1)
                result = result + a;
            a <<= 1;
            b >>= 1;
            return PrintSum(a, b, result);
        }

}

       
    }

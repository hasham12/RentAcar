using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mul_Shifting
{
    class Program
    {
        static void Main(string[] args)
        {
            mul_shf obj = new mul_shf();

            int sum = 0;
            string bin1 = "1111";
            string bin2 = "101";
            string m_bin1 = obj.aaa(bin1);
            string m_bin2 = obj.aaa(bin2);
            int binary1 = Convert.ToInt32(m_bin1);
            int binary2 = Convert.ToInt32(m_bin2);
            while (binary2 > 0)
            {
                if (bin2[bin2.Length - 1] == '1')
                {
                    sum += binary1;

                }
                binary1 <<= 1;
                binary2 >>= 1;
                bin2 = binary2.ToString();
            }
            Console.WriteLine(sum);

        }
      
    }
}

class mul_shf
{



    public string aaa(string a)
    {
        double sum = 0;
        double ybin = 0;
        double zbin = 2;

        int xbin = int.Parse(a);
        while (xbin > 0)
        {
            sum += (xbin % 10) * Math.Pow(zbin, ybin);
            ybin++;
            xbin /= 10;
        }
        return sum.ToString();
    }

}

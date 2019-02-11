using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("hello hasham :)");
            StreamWriter sr = new StreamWriter("hash.txt" , true);
            sr.Write("hasham");
            sr.Write("hahah");
            sr.Close();
            StreamReader sw = new StreamReader("hash.txt", true);
            Console.WriteLine( sw.Read());
            string name = "hasham ahmed is my name and yours ?";
            string vow = "aeiou";
            for (int i = 0; i < vow.Length; i++)
            {
                for (int j = 0; j <name.Length; j++)
                {
                    if (vow[i] == name[j])
                    {
                        Console.WriteLine(vow[i] +": " + "available");
                    }
                
                }
               
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace link_list_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(5);
            list.AddLast(8);
            list.AddLast(6);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}

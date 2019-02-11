using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obj_distroy
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton obj = Singleton.GetInstance();
           // Singleton obj1 = Singleton.GetInstance();
        }
    }
    class Singleton
    {
        private static Singleton _Object = null;
        private Singleton()
        {
            Console.WriteLine("Object Created!");
        }
        public static Singleton GetInstance()
        {
            if (_Object == null)
            {
                _Object = new Singleton();
                return _Object;
            }
            throw new Exception("NOT MORE THEN ONE OBJECT IS REQUIRED");
        }
    }
}


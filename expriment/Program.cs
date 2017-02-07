using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expriment
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 256; i++)
            {
                Console.WriteLine((char)i);
            }
            Console.ReadKey();
        }
    }
}

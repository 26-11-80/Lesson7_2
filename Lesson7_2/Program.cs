using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcCube(10, out int S, out int V);
            Console.Write("Площадь куба ");
            Console.WriteLine(S);
            Console.Write("Объем куба ");
            Console.WriteLine(V);
            Console.ReadKey();
        }

        static void CalcCube(int a, out int S, out int V)
        {
            S = 6 * a * a;
            V = a * a * a;
        }
    }
}

        
        
          
            
        

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSampleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // string name = Console.ReadLine();
            Console.WriteLine("Please enter a number");
            int iNum2 = 0;
            //bool res = Int32.TryParse(Console.ReadLine(), out iNum2);
            //Console.WriteLine(res+" "+(iNum2*2));

            while (!Int32.TryParse(Console.ReadLine(),out iNum2) ||(iNum2 == 0))
            {
                Console.WriteLine("Please enter a valid number");
            }
            Console.WriteLine("The numebr multiplied by 2 is "+(iNum2*2));
            //Console.WriteLine("Welcome "+name);
            Console.ReadKey();
        }
    }
}

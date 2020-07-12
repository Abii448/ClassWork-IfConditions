using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chk
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("A is greater");
            }
            else if(b>a){
                Console.WriteLine("b is greater");
            }
            else
            {
                Console.WriteLine("Both r equl");
            }
            Console.ReadLine();
        }
        
    }
}

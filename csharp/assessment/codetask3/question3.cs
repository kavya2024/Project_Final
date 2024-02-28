using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codetask3
{
    class question3
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            n1 =Convert.ToInt32( Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());
            if (n1 > n2)
            {
                if (n1 > n3)
                {
                    Console.WriteLine("1st is largest", n1);

                }
                else
                {
                    Console.WriteLine("3rd is largest", n3);
                }
            }
            else if (n2 > n3)
                Console.WriteLine("2nd is largest", n2);
            else
                Console.WriteLine("3rd is largest", n3);
        }
    }
}

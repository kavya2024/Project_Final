using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment
{
    class question1
    {
        static void Main()
        {
            Console.WriteLine("enter string");
            string s = Console.ReadLine();
            Console.WriteLine("Enter position");
            int p = int.Parse(Console.ReadLine());
            if (p >= 0 && p < s.Length)
            {
                s = s.Remove(p, 1);
                Console.WriteLine("string after removing", p, 1);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}

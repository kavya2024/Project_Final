using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codetask2
{
    class question2
    {
        static void Main(string[] args)
        {
            Console.Write("enter string");
            string s = Console.ReadLine();
            string f, l;
            f = s.Substring(0, 1);
            l = s.Substring(s.Length - 1, 1);
            s = s.Remove(0, 1).Remove(s.Length - 2, 1);
            Console.WriteLine(l + s + f);
        }
    }
}

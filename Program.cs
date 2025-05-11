using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List list = new List();
            list.Append('a');
            list.Append('b');
            list.Append('c');
            list.Append('e');
            list.Append('d');
            
            list.display();
            Console.WriteLine("List length: " + list.lenght());
            Console.WriteLine("List elements:");
            Console.ReadKey();
        }
    }
}

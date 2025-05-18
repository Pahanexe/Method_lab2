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
            ListLab list = new ListLab();
            list.Append('a');
            list.Append('b');
            list.Append('c');
            list.Append('c');
            list.Append('d');
            list.display();

            list.reverse();
            list.display();
            

            Console.WriteLine("List length: " + list.lenght());
            Console.ReadKey();
        }
    }
}

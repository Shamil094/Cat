using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Cat ct = new Cat();
            ct.Apply(ct.Sleep);



            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncTestConstructor
{
    internal class ClassA
    {
        public ClassA(string param1, string param2, string param3)
        {
            Console.WriteLine($"Param 1: {param1}, Param2: {param2}, Param 3: {param3}");
        }
    }
}

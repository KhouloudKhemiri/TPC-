using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICE11
{
    internal class Class1
    {
        static void Main()
        {
            Console.Write("Entrez un nombre : ");
            int n = int.Parse(Console.ReadLine());

            long factorielle = 1;
            for (int i = 1; i <= n; i++)
            {
                factorielle *= i;
            }

            Console.WriteLine($"{n}! = {factorielle}");
        }
    }
}

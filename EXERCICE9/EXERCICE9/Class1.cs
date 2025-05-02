using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICE9
{
    internal class Class1
    {
        static void Main()
        {
            Console.Write("Entrez un nombre : ");
            int nombre = int.Parse(Console.ReadLine());

            Console.WriteLine($"Table de {nombre} :");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{nombre} x {i} = {nombre * i}");
            }
        }
    }
}

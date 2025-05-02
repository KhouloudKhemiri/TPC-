using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICE10
{
    internal class Class1
    {
        static void Main()
        {
            Console.Write("Entrez un nombre : ");
            int n = int.Parse(Console.ReadLine());

            int somme = 0;
            for (int i = 1; i <= n; i++)
            {
                somme += i;
            }

            Console.WriteLine("La somme est : " + somme);
        }
    }
}

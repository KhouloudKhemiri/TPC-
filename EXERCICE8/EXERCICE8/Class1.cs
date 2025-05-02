using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICE8
{
    internal class Class1
    {
        static void Main()
        {
            Console.Write("Entrez un nombre de départ : ");
            int nombre = int.Parse(Console.ReadLine());

            Console.WriteLine("Les 10 nombres suivants sont :");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(nombre + i);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICE12
{
    internal class Class1
    {
        static void Main()
        {
            int max = int.MinValue;
            int position = 0;

            for (int i = 1; i <= 20; i++)
            {
                Console.Write($"Entrez le nombre numéro {i} : ");
                int n = int.Parse(Console.ReadLine());

                if (n > max)
                {
                    max = n;
                    position = i;
                }
            }

            Console.WriteLine($"Le plus grand nombre est : {max}");
            Console.WriteLine($"C'était le nombre numéro {position}");
        }
    }
}


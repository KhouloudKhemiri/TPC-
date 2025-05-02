using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICE6
{
    internal class Class1
    {
        static void Main()
        {
            int nombre;

            do
            {
                Console.Write("Entrez un nombre entre 1 et 3 : ");
                nombre = int.Parse(Console.ReadLine());
            } while (nombre < 1 || nombre > 3);

            Console.WriteLine("Merci !");
        }
    }
}


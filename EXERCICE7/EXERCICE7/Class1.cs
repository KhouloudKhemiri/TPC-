using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICE7
{
    internal class Class1
    {
        static void Main()
        {
            int nombre;

            do
            {
                Console.Write("Entrez un nombre entre 10 et 20 : ");
                nombre = int.Parse(Console.ReadLine());

                if (nombre < 10)
                    Console.WriteLine("Plus grand !");
                else if (nombre > 20)
                    Console.WriteLine("Plus petit !");
            } while (nombre < 10 || nombre > 20);

            Console.WriteLine("Merci !");
        }
    }
}


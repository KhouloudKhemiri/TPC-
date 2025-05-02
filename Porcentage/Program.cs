using System;

namespace Porcentage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("entrer un nombre");
            double nb = Convert.ToDouble(Console.ReadLine());

            double pourcentage = nb * 100;

            Console.WriteLine("le porcentage de la nb est {0} {1}", nb, pourcentage);
        }
    }
}

using System;

namespace Somme_AB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entrez le premier nombre : ");
            double nombre1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Entrez le deuxième nombre : ");
            double nombre2 = Convert.ToDouble(Console.ReadLine());

            // Calcul de la somme
            double somme = nombre1 + nombre2;

            // Affichage du résultat
            Console.WriteLine("La somme de {0} et {1} est : {2}", nombre1, nombre2, somme);


        }
    }
}

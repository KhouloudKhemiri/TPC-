using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3pOR
{
    internal class Class1
    {
        static void Main()
        {
            Console.Write("Nombre d'heures : ");
            double heures = double.Parse(Console.ReadLine());

            Console.Write("Prix par heure : ");
            double prix = double.Parse(Console.ReadLine());

            Console.Write("Chiffre d'affaire : ");
            double chiffreAffaire = double.Parse(Console.ReadLine());

            double salaire = heures * prix;
            double prime = (salaire > 5000) ? 0.05 * chiffreAffaire : 0.03 * chiffreAffaire;
            salaire += prime;

            Console.WriteLine("Le salaire total est : " + salaire);
        }
    }
}


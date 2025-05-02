using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICE5
{
    internal class Class1
    {
        static void Main()
        {
            Console.Write("Entrez une année : ");
            int annee = int.Parse(Console.ReadLine());

            Console.Write("Entrez le numéro du mois (1 à 12) : ");
            int mois = int.Parse(Console.ReadLine());

            int jours;

            switch (mois)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    jours = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    jours = 30;
                    break;
                case 2:
                    jours = (DateTime.IsLeapYear(annee)) ? 29 : 28;
                    break;
                default:
                    Console.WriteLine("Mois invalide");
                    return;
            }

            Console.WriteLine("Le mois numéro " + mois + " a " + jours + " jours.");
        }
    }
}


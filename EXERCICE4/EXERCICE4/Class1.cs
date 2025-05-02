using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICE4
{
    internal class Class1
    {




        class Program
        {
            static void Main()
            {
                const double prixUnite = 0.80;
                const double abonnement = 70.0;
                const double tva = 0.2; // 20% TVA

                Console.Write("Entrez le nombre d'unités consommées : ");
                int unites = int.Parse(Console.ReadLine());

                double montantHt = abonnement + (unites * prixUnite);
                double montantTtc = montantHt * (1 + tva);

                Console.WriteLine("Montant TTC : " + montantTtc + " DH");

                if (montantTtc > 120)
                    Console.WriteLine("Facture envoyée");
                else
                    Console.WriteLine("Facture reportée au mois suivant");
            }
        }

    }
}


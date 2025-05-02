using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BLL
{
    public class Voiture : Automobile
    {
        public int NombreDePortes { get; set; }

        public Voiture(string marque, string modele, string immatriculation, int nombreDePortes)
            : base(marque, modele, immatriculation) // appel au constructeur de Automobile
        {
            NombreDePortes = nombreDePortes;
        }

        public override string ToString()
        {
            return base.ToString() + $" ({NombreDePortes} portes)";
        }
    }
}

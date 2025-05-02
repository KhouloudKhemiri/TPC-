using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Automobile
    {
        public string Marque { get; set; }
        public string Modele { get; set; }
        public string Immatriculation { get; set; }

        public Automobile(string marque, string modele, string immatriculation)
        {
            Marque = marque;
            Modele = modele;
            Immatriculation = immatriculation;
        }

        public override string ToString()
        {
            return $"{Marque} {Modele} - {Immatriculation}";
        }
    }
}


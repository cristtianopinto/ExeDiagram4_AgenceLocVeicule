using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeDiagram4_AgenceLocVeicule.Class
{
    public class Agence
    {
        public string Adresse { get; set; }
        public string Ville { get; set; }
        

        public List<Employe> Personnel { get; set; }
        public List<Vehicule> Parc { get; set; }

    }

    public class ContratLocation
    {
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public int KilometrageMaximum { get; set; }

        public Client Client { get; set; }
        public Vehicule Vehicule { get; set; }

        public double CalculerMontantLocation(DateTime dateDebut,DateTime dateFin)//Comment faire pour retourner qlqch
        {
            return default(double);
        }
    }
}

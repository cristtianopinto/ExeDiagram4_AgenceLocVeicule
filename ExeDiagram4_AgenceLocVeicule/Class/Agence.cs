using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeDiagram4_AgenceLocVeicule.Class
{
    public class Agence
    {
        
        public Agence()
        {
            Parc = new List<Vehicule>(); //ATTENTION - on besoin de initialiser la List
            Personnel = new List<Employe>();
        }
        
        public string Nom { get; set; }
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

        public double CalculerMontantLocation()//Comment faire pour retourner qlqch
        {
            var nombreJours = (this.DateFin - this.DateDebut).TotalDays;

            return this.Vehicule.GetPrixJour() * nombreJours;
        }
    }
}

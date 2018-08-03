using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeDiagram4_AgenceLocVeicule.Class
{
    public abstract class Vehicule
    {
        public string Marque { get; set; }
        public string Modele { get; set; }

        public double GetPrixJour()//Comment faire pour retourner qlqch
        {
            return default(double);
        }
    }
    public class Camionette : Vehicule
    {
        public int PoidsMaxEnKilo { get; set; }
        public int prixJour { get; set; }
    }
    public class Voiture : Vehicule
    {
        public int NombrePortes { get; set; } = 5;//Marquer valuer par default?? int = 5
        public CategorieVoiture Categorie { get; set; }
        /*
        public Voiture(){
            this.NombrePortes = 5;
        }


        Dans la derniere version de c# on fait comme ca:
        public int NombrePortes { get; set; } = 5;
        */
    }
    public class CategorieVoiture 
    {
        public string Nom { get; set; }
        public double PrixJour { get; set; }

        public List<Voiture> Voitures { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExeDiagram4_AgenceLocVeicule.Class;

namespace ExeDiagram4_AgenceLocVeicule
{
    class Program
    {
        static void Main(string[] args)
        {
            var agence = new Agence();
            agence.Nom = "Buget";
            agence.Ville = "Paris";
            

            var client = new Client();
            client.Nom = "BAZAN";
            client.Prenom = "Yannick";
            client.Numero = "00001";

            var categorieCompacte = new CategorieVoiture();
            categorieCompacte.Nom = "Compacte";
            categorieCompacte.PrixJour = 40;

            var categorieFamiliale = new CategorieVoiture();
            categorieFamiliale.Nom = "Familiale";
            categorieFamiliale.PrixJour = 75;

            var voiture1 = new Voiture();
            voiture1.Categorie = categorieCompacte;
            voiture1.Marque = "Peugeot";
            voiture1.Modele = "308";

            agence.Parc.Add(voiture1);
            Console.WriteLine($"La agence {agence.Nom} a {agence.Parc.Count} voiture(s)");

            var contratLocation = new ContratLocation();
            contratLocation.Client = client;
            contratLocation.DateDebut = DateTime.Today;
            contratLocation.DateFin = DateTime.Today.AddDays(5);
            contratLocation.KilometrageMaximum = 500;
            contratLocation.Vehicule = voiture1;

            Console.WriteLine($"Contrat pour le client {contratLocation.Client.Nom} {client.Prenom}" +
                              $"\nValeur jour: {contratLocation.Vehicule.GetPrixJour()} " +
                              $"\nValeur total: {contratLocation.CalculerMontantLocation()}");

        }
        /*
            static void Main(string[] args)
        {
            
            //var a1 = new A1();
            //var a2 = new A2();

            //var b = new B();
            //var b1 = new B1();
            //var b2 = new B2();
            //var b3 = new B3();
            
           A a1 = new A1();
           A a2 = new A2();

           B b = new B();
           //B b1 = new B1();
           B1 b1 = new B1();
           B b2 = new B2();
           B b3 = new B3();

            a1.Methode();
            a2.Methode();

            b.Methode();
            b1.Methode();

            b1.SuperMethode();
           
            b2.Methode();
            b3.Methode();

            Console.ReadKey();
        }
    }
    public abstract class A
    {
        public abstract void Methode();
    }
    public class A1 : A
    {
        public override void Methode()
        {
            Console.WriteLine("A1");
        }
    }
    public class A2 : A
    {
        public override void Methode()
        {
            Console.WriteLine("A2");
        }
    }
    public class B
    {
        public virtual void Methode()
        {
            Console.WriteLine("B");
        }

    }
    public class B1 : B
    {
        public override void Methode()
        {
            Console.WriteLine("B1");
        }
        public void SuperMethode()
        {
            Console.WriteLine("SUPER B1");
        }
    }
    public class B2 : B{    }
    public class B3 : B
    {
        public override void Methode()
        {
            base.Methode();
            Console.WriteLine("B3");
        }*/

    }

}

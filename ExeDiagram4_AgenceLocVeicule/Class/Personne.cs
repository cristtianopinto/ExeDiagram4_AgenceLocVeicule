using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeDiagram4_AgenceLocVeicule.Class
{
    public abstract class Personne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
    }
    public class Client : Personne
    {
        public string Numero { get; set; }

        public List<ContratLocation> Contrats { get; set; }
    }
    public class Employe : Personne
    {
        public int SalaireAnnuelBrut { get; set; }
    }
}

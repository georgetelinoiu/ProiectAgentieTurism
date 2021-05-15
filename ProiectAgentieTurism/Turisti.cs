using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectAgentieTurism
{
    [Serializable]
    public class Turisti
    {
        string nume;
        string prenume;
        string cnp;
        bool tichete;

        public Turisti()
        {
            nume = "";
            prenume = "";
            cnp = "";
            tichete = false;
        }

        public Turisti(string nume, string prenume, string cnp, bool tichete)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.cnp = cnp;
            this.tichete = tichete;
        }

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        public string Prenume
        {
            get { return prenume; }
            set { prenume = value; }
        }

        public string pCNP
        {
            get { return cnp; }
            set { cnp = value; }
        }

        public bool Tichete
        {
            get { return tichete; }
            set { tichete = value; }
        }

    }
}

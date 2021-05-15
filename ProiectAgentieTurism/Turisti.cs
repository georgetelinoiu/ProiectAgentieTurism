using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectAgentieTurism
{
    class Turisti
    {
        string nume;
        string prenume;
        string cnp;


        public Turisti()
        {

        }

        public Turisti(string nume, string prenume, string cnp)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.cnp = cnp;
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

    }
}

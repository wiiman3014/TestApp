using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestApp

{
    class Person
    {
        public String Nom { get; set; }

        private String prenom;

        public String Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
    }
}

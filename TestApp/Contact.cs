using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace TestApp
{



    public class Contact : INotifyPropertyChanged
    {

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public String nom;

        public String Nom
        {
            get { return nom; }
            set
            {
                if (value != nom)
                {
                    nom = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public String prenom;

        public String Prenom
        {
            get { return prenom; }
            set
            {
                if (value != prenom)
                {
                    prenom = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public String adresse;

        public String Adresse
        {
            get { return adresse; }
            set
            {
                if (value != adresse)
                {
                    adresse = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public String npa;

        public String Npa
        {
            get { return npa; }
            set
            {
                if (value != npa)
                {
                    npa = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public String localite;

        public String Localite
        {
            get { return localite; }
            set
            {
                if (value != localite)
                {
                    localite = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public String email;

        public String Email
        {
            get { return email; }
            set
            {
                if (value != email)
                {
                    email = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public List<PhoneNumber> phoneNumbers;

        public List<PhoneNumber> PhoneNumbers
        {
            get { return phoneNumbers; }
            set
            {
                if (value != phoneNumbers)
                {
                    phoneNumbers = value;
                    NotifyPropertyChanged();
                }
            }
        }

        /* public String Prenom { get; set; }
         public String Adresse { get; set; }
         public String Npa { get; set; }
         public String Localite { get; set; }
         public String Email { get; set; }*/
        // public List<PhoneNumber> PhoneNumbers { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public Contact()
        {

        }
        public Contact(String nomC, String prenomC, String adresseC, String npaC, String localiteC, String emailC)
        {
            Nom = nomC;
            Prenom = prenomC;
            Adresse = adresseC;
            Npa = npaC;
            Localite = localiteC;
            Email = emailC;
            NotifyPropertyChanged();
        }

        public String ToTabString()
        {
            String ContactLigne = Nom + "\t" + Prenom + "\t" + Adresse + "\t" + Npa + "\t" + Localite + "\t" + Email + "\t \n";
            // return this.Nom + "\t" + Prenom + "\t" + Adresse + "\t" + Npa + "\t" + Localite + "\t" + Email + "\t \n";
            NotifyPropertyChanged(ContactLigne);
            return ContactLigne;

        }

        public void FromTabString(String tabString)
        {

            String[] tab = tabString.Split('\t', '\n');
            Contact c = (new Contact(tab[0], tab[1], tab[2], tab[3], tab[4], tab[5]));

            NotifyPropertyChanged();
        }





    }
}



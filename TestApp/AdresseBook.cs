using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class AdresseBook : ObservableCollection<Contact>

    {

        public String Path { get; set; }



        public int NombreContact { get; set; }

        public void Load(String filename)
        {
            using (StreamReader sr = new StreamReader(filename))
            {
                String line;
                Path = filename;
                while ((line = sr.ReadLine()) != null)
                {
                    /*Contact c = new Contact();
                    c.FromTabString(line);
                    */
                    String[] donnee = line.Split(new char[] { '\t', '\n' });

                    Contact c = new Contact(donnee[0], donnee[1], donnee[2], donnee[3], donnee[4], donnee[5]);

                    this.Add(c);
                    
                }

                sr.Close();
            }

        }

        public String SimpleName { get { return Path == null ? "*new" : System.IO.Path.GetFileNameWithoutExtension(Path); } }

        public void Save(String filename)
        {
         
                using (StreamWriter sw = new StreamWriter(filename))
                {

                    foreach (Contact c in this)
                    {
                        sw.Write(c.ToTabString());
                    }
                    sw.Close();
                }
        }




    }
}

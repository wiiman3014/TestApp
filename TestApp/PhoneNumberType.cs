using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{

   public  class PhoneNumberType
    {
        public int Description { get; set; }
        public String Name { get; set; }
        public String Types { get; set; }

        public PhoneNumberType(int description, string name, string types)
        {
            Description = description;
            Name = name;
            Types = types;

        }

    }
}

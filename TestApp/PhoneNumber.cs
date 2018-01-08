using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TestApp
{
    public class PhoneNumber : INotifyPropertyChanged
    {


        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public String number;

        public String Number
        {
            get { return number; }
            set
            {
                if (value != number)
                {
                    number = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public String types;

        public String Types
        {
            get { return types; }
            set
            {
                if (value != types)
                {
                    types = value;
                    NotifyPropertyChanged();
                }
            }
        }

        /*public String Number { get; set; }
        public List<PhoneNumberType> Types{ get; set; }*/

        public event PropertyChangedEventHandler PropertyChanged;


    }



}

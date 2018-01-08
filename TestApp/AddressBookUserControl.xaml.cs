using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestApp
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class AddressBookUserControl : UserControl
    {

        public AdresseBook AddressBook { get { return DataContext as AdresseBook; } set { DataContext = value; } }


        public AddressBookUserControl()
        {
            InitializeComponent();


        }

        private void CmdPropertie_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CmdPropertie_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            DetailWindow dm = new DetailWindow();

            //dm.ContactModifie
            dm.ShowDialog();

        }
    }
}

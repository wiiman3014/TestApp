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
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int nbTitile = 1;
        AdresseBook Contacts
        {
            get { return (tableau.SelectedContent as AddressBookUserControl)?.AddressBook; }
        }

        public MainWindow()
        {
            InitializeComponent();

           /* List<PhoneNumberType> phoneNumberTypes = new List<PhoneNumberType>();
            phoneNumberTypes.Add(new PhoneNumberType(1, "Tel.Priv.", "Téléphone privé"));
            phoneNumberTypes.Add(new PhoneNumberType(2, "Fax", "Télécopie"));
            phoneNumberTypes.Add(new PhoneNumberType(3, "Tel.Prof.", "Téléphone professionnel"));
            phoneNumberTypes.Add(new PhoneNumberType(4, "Mobile", "Téléphone mobile"));
            */

        }


        private void tableau_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            StatusBar.Content = Contacts?.Count + " contacts";

        }

        private void addAddressBookTab(String filename = null)
        {
            
            var uc = new AddressBookUserControl();
            uc.AddressBook = new AdresseBook();     // Définition du Datacontex

            if (filename != null)
            {
                uc.AddressBook.Load(filename);
                

            }
          
            var ti = new TabItem();
          
            ti.Content = uc;
            ti.Header = uc.AddressBook.SimpleName;
            String NameFile = (String)ti.Header;

            String[] substrings = NameFile.Split('(');

            foreach (TabItem Item in tableau.Items)
            {
                // foreach (var substring in substrings)
                if (Item.Header == substrings[0])
                {
                    if (Item.Header == ti.Header)
                    {
                        nbTitile++;
                        ti.Header += "(" + nbTitile + ")";
                    }
                }
            }
            tableau.Items.Add(ti);     // ajout de l’onglet
            tableau.SelectedItem = ti;

        }


        //Open MenuItem
        private void CmdOpen_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CmdOpen_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            addAddressBookTab(OpenFileDialog());

        }

        //Save MenuItem
        private void CmdSave_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CmdSave_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Contacts?.Save(SaveFileDialog());
        }

        //SaveAs MenuItem
        private void CmdSaveAs_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CmdSaveAs_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Contacts?.Save(SaveFileDialog());
        }
        //Help MenuItem
        private void CmdHelp_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CmdHelp_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }

        public String OpenFileDialog()
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.FileName = "contact";               // nom du fichier par défaut (facultatif)
            dlg.DefaultExt = ".txt";                // extension par défaut (facultatif)
            dlg.Filter = "Text documents (.txt)|*.txt"; // filtre (facultatif) 
            bool? result = dlg.ShowDialog();            // affichage du dialogue
            return (result == true) ? dlg.FileName : "";              // test si un fichier a été sélectionné
        }


        public String SaveFileDialog()
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.FileName = "contact";               // nom du fichier par défaut (facultatif)
            dlg.DefaultExt = ".txt";                // extension par défaut (facultatif)
            dlg.Filter = "Text documents (.txt)|*.txt"; // filtre (facultatif) 
            bool? result = dlg.ShowDialog();            // affichage du dialogue
            return (result == true) ? dlg.FileName : "";              // test si un fichier a été sélectionné
        }

        private void filenew_Click(object sender, RoutedEventArgs e)
        {
            addAddressBookTab();
        }


        private void printDocument1_PrintPage(object sender,
    System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            String message = System.Environment.UserName;
            Font messageFont = new Font("Arial",
                     24, System.Drawing.GraphicsUnit.Point);
            g.DrawString(message, messageFont, Brushes.Black, 100, 100);
        }

        private void fileprint_Click(object sender, RoutedEventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

            
            
        }
    }
}

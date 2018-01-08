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
using System.Windows.Shapes;

namespace TestApp
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class DetailWindow : Window
    {
        public Contact ContactModifie { get; set; }

        public DetailWindow()
        {
            InitializeComponent();
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
    
        }


        private void OK_Click(object sender, RoutedEventArgs e)
        {
           
            Contact c = new Contact(BoxNom.Text, BoxPrenom.Text, BoxAdresse.Text, BoxNpa.Text, BoxLocalite.Text, BoxEmail.Text);
            
            Close();
        }

        private void BoxNom_TextInput(object sender, TextCompositionEventArgs e)
        {

        }
    }
}

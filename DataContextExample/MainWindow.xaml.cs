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
using Data;

namespace DataContextExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person person;

        public MainWindow()
        {
            InitializeComponent();
            person = new Person();
            person.First = "Jack";
            person.Last = "Sprat";
            person.FavoriteFruit = Fruits.Pear;
            personEntry.DataContext = person;

        }


        void OnChangeName(object sender, RoutedEventArgs e)
        {
            person.First = "Bugs";
            person.Last = "Bunny";
        }

        void OnChangePerson(object sender, RoutedEventArgs e)
        {
            var newperson = new Person();
            newperson.First = "Mark";
            newperson.Last = "Mark";
            newperson.FavoriteFruit = Fruits.Bananna;
            personEntry.DataContext = newperson;
        }

    }
}

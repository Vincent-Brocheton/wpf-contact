using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
using WpfApp1.Model;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ObservableCollection<Contact> contacts = new ObservableCollection<Contact>();
            var databasePath = "MyData.db";

            CreateDbIfNotExist(contacts, databasePath);
            var db = new SQLiteConnection(databasePath);

            var contactdb = db.Table<Contact>().OrderBy(x=> x.Id).ToList();

            contactPanel.ItemsSource = contactdb;
        }

        private static void CreateDbIfNotExist(ObservableCollection<Contact> contacts, string databasePath)
        {
            if (!File.Exists(databasePath))
            {
                var db = new SQLiteConnection(databasePath);
                db.CreateTable<Contact>();

                contacts.Add(new Contact { FirstName = "Vincent", LastName = "Brocheton", Phone = "0686330763", BirthDate = new DateTime(1993, 03, 11)});
                contacts.Add(new Contact { FirstName = "Isabelle", LastName = "Brocheton", Phone = "0682259459", BirthDate = new DateTime(1970, 05, 25) });

                foreach (Contact contact in contacts)
                {
                    db.Insert(contact);
                }

            }
        }

        private void BtnAjouter_Click(object sender, RoutedEventArgs e)
        {
            var fenetre = new NouveauContactWindow();
            fenetre.ShowDialog();
        }

        private void showContact(object sender, MouseButtonEventArgs e)
        {
            var fenetre = new ShowContact(contactPanel.SelectedItem as Contact);
            fenetre.ShowDialog();
        }
    }
}

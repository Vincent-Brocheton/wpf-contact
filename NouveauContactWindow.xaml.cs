using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp1.Model;

namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour NouveauContactWindow.xaml
    /// </summary>
    public partial class NouveauContactWindow : Window
    {
        public NouveauContactWindow()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
            // TODO: sauvegarder le contact
            Contact contact = new Contact
            {
                FirstName = tbFirstName.Text,
                LastName = tbName.Text,
                Phone = tbPhone.Text,
                BirthDate = (DateTime)tbBirthDate.SelectedDate
            };

            var databasePath = "MyData.db";
            var db = new SQLiteConnection(databasePath);
            db.Insert(contact);

            this.Close();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

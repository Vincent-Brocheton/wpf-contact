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
    /// Logique d'interaction pour ShowContact.xaml
    /// </summary>
    public partial class ShowContact : Window
    {
        public ShowContact(Contact contact)
        {
            InitializeComponent();

            FirstName.Text = contact.FirstName;
            LastName.Text = contact.LastName;
            phone.Text = contact.Phone;
            BirthDate.Text = contact.BirthDate.Day+"/"+contact.BirthDate.Month+"/"+contact.BirthDate.Year;
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnModify_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

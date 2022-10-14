using System;
using System.Windows;
using System.Xml;

namespace DataApplication
{

    public partial class NewCustomerWindow : Window
    {
        public NewCustomerWindow()
        {
            InitializeComponent();

            newCustomer = new Customer();
            DataContext = newCustomer;
            IC1.ItemsSource = new string[] { "Eins", "Zwei", "Drei" };
        }

        private Customer newCustomer;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("D");
        }
    }

}

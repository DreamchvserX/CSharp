using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NavigationApplication
{

    public partial class WelcomePage : Page
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("HelpPage.xaml", UriKind.Relative), "Extra Daten für unterwegs");
        }

        private void GenerateDataButton_Click(object sender, RoutedEventArgs e)
        {
            SelectionPage page = new SelectionPage();
            page.Return += new ReturnEventHandler<string>(GenerateDataPage_Return);
            NavigationService.Navigate(page);
        }

        private void GenerateDataPage_Return(object sender, ReturnEventArgs<string> e)
        {
            TextBlock1.Text = e.Result;
        }
    }
}

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

    public partial class SelectionPage : PageFunction<String>
    {
        public SelectionPage()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            OnReturn(new ReturnEventArgs<string>(TextBox1.Text));
        }
    }

}

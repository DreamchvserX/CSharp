using Lb.BELayer;
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

namespace Lb.Start
{
    /// <summary>
    /// Interaction logic for FahrerPage.xaml
    /// </summary>
    public partial class FahrerPage : Page
    {
        Fahrer f;
        public FahrerPage()
        {
            InitializeComponent();
            lsvFahrer.ItemsSource = new Fahrer().getFahrers();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}

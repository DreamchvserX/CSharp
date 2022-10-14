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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            FrameMain.Content = new SuchePage();
        }

        private void OpenFahrerPage_Click(object sender, RoutedEventArgs e)
        {
            FrameMain.Content = new FahrerPage();

        }

        private void OpenFahrtenPage_Click(object sender, RoutedEventArgs e)
        {
            FrameMain.Content = new FahrtenPage();
        }

        private void OpenFahrzeugePage_Click(object sender, RoutedEventArgs e)
        {
            FrameMain.Content = new FahrzeugePage();
        }

        private void OpenOrtePage_Click(object sender, RoutedEventArgs e)
        {
            FrameMain.Content = new OrtePage();
        }

        private void OpenZweckePage_Click(object sender, RoutedEventArgs e)
        {
            FrameMain.Content = new ZweckePage();
        }
    }
}

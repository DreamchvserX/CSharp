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

namespace WPF.RoutedEvents
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void MD1(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("{0}.{1} @ {2}",
                sender.GetType().Name,
                e.RoutedEvent.Name,
                e.Source.GetType().Name);
        }
    }
}

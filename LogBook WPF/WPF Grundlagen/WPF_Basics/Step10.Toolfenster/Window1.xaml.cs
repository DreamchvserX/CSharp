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

namespace WPF.Toolfenster
{
 
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void OpenToolWinButton_Click(object sender, RoutedEventArgs e)
        {
            ToolWindow win = new ToolWindow();
            win.Owner = this;
            win.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            win.Show();
        }
    }
}

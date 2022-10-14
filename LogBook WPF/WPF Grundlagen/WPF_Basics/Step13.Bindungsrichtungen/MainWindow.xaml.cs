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

namespace BindingDirectionApplication
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new User("RuRat");
        }

        private void TextBox_SourceUpdated(object sender, DataTransferEventArgs e)
        {
            Console.WriteLine("SourceUpdated: " + e.Source.GetType().Name + " > " + e.TargetObject.GetType().Name);
            Console.WriteLine("  Property: " + (e.Property!=null ? "'" + e.Property.Name + '"' : "[null]"));
        }

        private void TextBox_TargetUpdated(object sender, DataTransferEventArgs e)
        {
            Console.WriteLine("TargetUpdated: " + e.TargetObject.GetType().Name + " > " + e.Source.GetType().Name);
            Console.WriteLine("  Property: " + (e.Property!=null ? "'" + e.Property.Name + '"' : "[null]"));
        }
    }

}

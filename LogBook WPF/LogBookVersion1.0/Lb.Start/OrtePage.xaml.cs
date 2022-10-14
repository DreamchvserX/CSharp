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
    /// Interaction logic for OrtePage.xaml
    /// </summary>
    public partial class OrtePage : Page
    {
        public OrtePage()
        {
            InitializeComponent();
            lsvOrte.ItemsSource = new Orte().getOrte();

        }
    }
}

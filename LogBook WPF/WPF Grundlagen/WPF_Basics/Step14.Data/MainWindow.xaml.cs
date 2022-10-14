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
using System.ComponentModel;

namespace DataApplication
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public static readonly RoutedCommand NewCustomerCommand = new RoutedCommand("NewCustomerCommand", typeof(MainWindow));

        protected void NewCustomerCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            NewCustomerWindow win = new NewCustomerWindow();
            win.ShowDialog();
        }

        private void OpenCustomerCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Öffne Kundendaten...");
        }

        protected void SortMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem menuItem = e.Source as MenuItem;
            SortField field = (SortField)menuItem.Tag;
            switch (field)
            {
                case SortField.Name:
                    SortListView("Name");
                    break;

                case SortField.Created:
                    SortListView("Created");
                    break;
            }
       }

        private void PrevButton_Click(object sender, RoutedEventArgs e)
        {
            ObjectDataProvider d1 = FindResource("D1") as ObjectDataProvider;
            if (d1 == null)
                return;

            ICollectionView view = CollectionViewSource.GetDefaultView(d1.Data);
            if (view != null)
                view.MoveCurrentToPrevious();
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            ObjectDataProvider d1 = FindResource("D1") as ObjectDataProvider;
            if (d1 == null)
                return;

            ICollectionView view = CollectionViewSource.GetDefaultView(d1.Data);
            if (view != null)
                view.MoveCurrentToNext();
        }

        private void ListView1_ColumnHeaderClick(object sender, RoutedEventArgs e)
        {
            ObjectDataProvider d1 = FindResource("D1") as ObjectDataProvider;
            if (d1 == null)
                return;

            ICollectionView view = CollectionViewSource.GetDefaultView(d1.Data);
            if (view == null)
                return;
            SortListView("Name");
        }

        private void GroupingComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ObjectDataProvider d1 = FindResource("D1") as ObjectDataProvider;
            if (d1 == null)
                return;

            ICollectionView view = CollectionViewSource.GetDefaultView(d1.Data);
            if (view == null)
                return;

            view.SortDescriptions.Clear();
            view.SortDescriptions.Add(new SortDescription("Created", ListSortDirection.Ascending));
            view.GroupDescriptions.Clear();
            view.GroupDescriptions.Add(new PropertyGroupDescription("Created.Year"));
            view.Refresh();
        }

        protected void SortListView(string field)
        {
            ObjectDataProvider d1 = FindResource("D1") as ObjectDataProvider;
            if (d1 == null)
                return;

            ICollectionView view = CollectionViewSource.GetDefaultView(d1.Data);
            view.SortDescriptions.Clear();
            view.SortDescriptions.Add(new SortDescription(field, ListSortDirection.Descending));
            view.Refresh();
        }
    }

}

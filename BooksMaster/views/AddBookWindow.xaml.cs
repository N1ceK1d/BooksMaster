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
using System.Windows.Shapes;

namespace BooksMaster.views
{
    /// <summary>
    /// Логика взаимодействия для AddBookWindow.xaml
    /// </summary>
    public partial class AddBookWindow : Window
    {
        public AddBookWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource bookViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("bookViewSource")));
            // Загрузите данные, установив свойство CollectionViewSource.Source:
            // bookViewSource.Source = [универсальный источник данных]
            System.Windows.Data.CollectionViewSource bookViewSource1 = ((System.Windows.Data.CollectionViewSource)(this.FindResource("bookViewSource1")));
            // Загрузите данные, установив свойство CollectionViewSource.Source:
            // bookViewSource1.Source = [универсальный источник данных]
            System.Windows.Data.CollectionViewSource bookViewSource2 = ((System.Windows.Data.CollectionViewSource)(this.FindResource("bookViewSource2")));
            // Загрузите данные, установив свойство CollectionViewSource.Source:
            // bookViewSource2.Source = [универсальный источник данных]
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource bookViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("bookViewSource")));
            // Загрузите данные, установив свойство CollectionViewSource.Source:
            // bookViewSource.Source = [универсальный источник данных]
        }

        private void Window_Loaded_2(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource bookViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("bookViewSource")));
            // Загрузите данные, установив свойство CollectionViewSource.Source:
            // bookViewSource.Source = [универсальный источник данных]
        }
    }
}

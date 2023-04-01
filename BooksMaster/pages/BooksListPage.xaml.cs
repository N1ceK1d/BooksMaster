using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace BooksMaster.pages
{
    /// <summary>
    /// Логика взаимодействия для BooksListPage.xaml
    /// </summary>
    public partial class BooksListPage : Page
    {
        BooksMasterEntities booksMaster = new BooksMasterEntities();
        CollectionViewSource bookViewSource;
        public BooksListPage()
        {
            InitializeComponent();
            bookViewSource = ((CollectionViewSource)(FindResource("bookViewSource")));
            DataContext = this;
            booksMaster.Book.Load();

            bookViewSource.Source = booksMaster.Book.Local;
            System.Windows.Data.CollectionViewSource bookViewSource4 = ((System.Windows.Data.CollectionViewSource)(this.FindResource("bookViewSource")));
        }

        private void AddBook_Click(object sender, RoutedEventArgs e)
        {
            var view = new views.AddBookWindow();
            view.ShowDialog();
        }
    }
}

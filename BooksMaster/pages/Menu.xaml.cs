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

namespace BooksMaster.pages
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Page
    {
        public static BooksListPage booksView { get; set; } = new BooksListPage();
        public static ProfilePage profileView { get; set; } = new ProfilePage();
        public static CollectionsPage collectionsView { get; set; } = new CollectionsPage();
        public Menu()
        {
            InitializeComponent();
            home.Content = booksView;
            profile.Content = profileView;
            collections.Content = collectionsView;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Close();
        }
    }
}

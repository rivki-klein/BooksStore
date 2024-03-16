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

namespace BooksStoreGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BooksStoreBL.BookStoreBL booksStoreBL; 
        public MainWindow()
        {
            booksStoreBL = new BooksStoreBL.BookStoreBL();
            
            InitializeComponent();
            var res = booksStoreBL.GetAllBooks();
            BooksDataGrid.ItemsSource = res;
            //1
            var on30 = booksStoreBL.GetBooksOn30();
            BooksDataGrid.ItemsSource = on30;
            //2
            var sort = booksStoreBL.OrderBooks();
            BooksDataGrid.ItemsSource = sort;
            //3
            var comics = booksStoreBL.OnlyComics();
            BooksDataGrid.ItemsSource = comics.Select(x => new { Value = x }).ToList();
            //4
            var age9 = booksStoreBL.FitAge9();
            BooksDataGrid.ItemsSource = age9.Select(x => new { Value = x }).ToList();
        }
    }
}

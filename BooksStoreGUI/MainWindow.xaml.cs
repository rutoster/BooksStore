using BooksStoreBL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            //var res = booksStoreBL.BookExpensive();
            //BooksDataGrid.ItemsSource = res;
            //var res1 = booksStoreBL.Arranged();
            //BooksDataGrid.ItemsSource = res1;
            //var res2 = booksStoreBL.PriceOfComics();
            //BooksDataGrid.ItemsSource = res2.Select(x => new { Value = x }).ToList();
            var res3 = booksStoreBL.BooksSuitableForAge9();
            BooksDataGrid.ItemsSource = res3.Select(x => new { Value = x }).ToList();


        }


    }
}

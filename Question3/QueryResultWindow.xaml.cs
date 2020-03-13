using Microsoft.EntityFrameworkCore;
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

namespace Question3
{
    /// <summary>
    /// Interaction logic for QueryResultWindow.xaml
    /// </summary>
    public partial class QueryResultWindow : Window
    {
        MainWindow _mainWindow;
        public QueryResultWindow(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ////var list = dbContext.Titles.Include("AuthorIsbn.Author").ToList();
            //var list = _mainWindow.dbContext.AuthorIsbn.Include("Author").Include("IsbnNavigation").ToList();
            //var list = _mainWindow.dbContext.AuthorIsbn.Include("Author.AuthorIsbn").ToList();
            var list = _mainWindow.dbContext.Titles.Include("AuthorIsbn.Author").OrderBy(b => b.Title).ToList();



            System.Windows.Data.CollectionViewSource titlesViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("titlesViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            titlesViewSource.Source = list;

            System.Windows.Data.CollectionViewSource authorsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("authorsViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            authorsViewSource.Source = _mainWindow.dbContext.Titles.Include("AuthorIsbn.Author").ToList();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _mainWindow.Close();
        }
    }
}

using BooksClassLibrary.Models;
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
            IQueryable<TitleAuthor> query = null;
            IOrderedQueryable<IGrouping<string, Titles>> groupQuery = null;

            if (_mainWindow.selectedQuery == SelectedQuery.query1)
            {
                query = from AI in _mainWindow.dbContext.AuthorIsbn
                    join A in _mainWindow.dbContext.Authors
                        on AI.AuthorId equals A.AuthorId
                    join T in _mainWindow.dbContext.Titles
                        on AI.Isbn equals T.Isbn
                    orderby T.Title
                    select new TitleAuthor { Title = T.Title, FirstName = A.FirstName, LastName = A.LastName };
            } 
            else if (_mainWindow.selectedQuery == SelectedQuery.query2)
            {
                query = from AI in _mainWindow.dbContext.AuthorIsbn
                        join A in _mainWindow.dbContext.Authors
                            on AI.AuthorId equals A.AuthorId
                        join T in _mainWindow.dbContext.Titles
                            on AI.Isbn equals T.Isbn
                        orderby T.Title, A.LastName, A.FirstName
                        select new TitleAuthor { Title = T.Title, FirstName = A.FirstName, LastName = A.LastName };
            }
            else
            {
                query = from AI in _mainWindow.dbContext.AuthorIsbn
                        join A in _mainWindow.dbContext.Authors
                            on AI.AuthorId equals A.AuthorId
                        join T in _mainWindow.dbContext.Titles
                            on AI.Isbn equals T.Isbn
                        orderby T.Title, A.LastName, A.FirstName
                        select new TitleAuthor { Title = T.Title, FirstName = A.FirstName, LastName = A.LastName };
            }
            
            System.Windows.Data.CollectionViewSource resultsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("resultsViewSource")));
            List<TitleAuthor> list = new List<TitleAuthor>();

            foreach (var item in query)
            {
                list.Add(item);
            }
            resultsViewSource.Source = list;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //_mainWindow.Close();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.Show();
            this.Close();
        }

    }

    public class TitleAuthor
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

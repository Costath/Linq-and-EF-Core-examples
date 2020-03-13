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
using BooksClassLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace Question3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public BooksContext dbContext = new BooksContext();
        public MainWindow()
        {
            InitializeComponent();
            dbContext.AuthorIsbn.Load();
            dbContext.Authors.Load();
            dbContext.Titles.Load();
        }

        private void Query1Btn_Click(object sender, RoutedEventArgs e)
        {
            QueryResultWindow queryResultWindow = new QueryResultWindow(this);

            queryResultWindow.Show();
            Hide();
        }

    }
}

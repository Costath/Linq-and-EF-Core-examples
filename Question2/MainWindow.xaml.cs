using BaseballClassLibrary.Models;
using Microsoft.EntityFrameworkCore;
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

namespace Question2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public BaseballContext dbContext = new BaseballContext();
        public MainWindow()
        {
            InitializeComponent();
            dbContext.Players.Load();
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            SearchWindow _searchWindow = new SearchWindow(this);
            _searchWindow.Show();
            Hide();
        }

        private void ShowAllBtn_Click(object sender, RoutedEventArgs e)
        {
            ContentWindow _contentWindow = new ContentWindow(this);
            _contentWindow.Show();
            Hide();
        }

        private void AddNewPlayerBtn_Click(object sender, RoutedEventArgs e)
        {
            AddNewPlayerWindow _addNewPlayerWindow = new AddNewPlayerWindow(this);
            _addNewPlayerWindow.Show();
            Hide();
        }
    }
}

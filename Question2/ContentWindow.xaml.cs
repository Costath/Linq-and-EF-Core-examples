using Microsoft.EntityFrameworkCore;
using BaseballClassLibrary.Models;
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
using System.Collections.ObjectModel;

namespace Question2
{
    /// <summary>
    /// Interaction logic for InitialWindow.xaml
    /// </summary>
    public partial class ContentWindow : Window
    {
        MainWindow _mainWindow;
        public ContentWindow(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CollectionViewSource baseballContextViewSource = (CollectionViewSource)FindResource("baseballContextViewSource");
            
            baseballContextViewSource.Source = _mainWindow.dbContext.Players.Local.ToObservableCollection();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.Show();
            Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _mainWindow.Close();
        }
    }
}

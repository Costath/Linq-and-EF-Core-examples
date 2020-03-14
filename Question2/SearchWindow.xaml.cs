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

namespace Question2
{
    /// <summary>
    /// Interaction logic for SearchWindow.xaml
    /// </summary>
    public partial class SearchWindow : Window
    {
        MainWindow _mainWindow;
        public SearchWindow(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.Show();
            Close();
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            CollectionViewSource playersViewSource = (CollectionViewSource)FindResource("playersViewSource");
            // Load data by setting the CollectionViewSource.Source property:
            playersViewSource.Source = _mainWindow.dbContext.Players.Where(p => p.LastName == SearchTextBox.Text).ToList();

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //_mainWindow.Close();
        }
    }
}

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
using BaseballClassLibrary.Models;

namespace Question2
{
    /// <summary>
    /// Interaction logic for AddNewPlayerWindow.xaml
    /// </summary>
    public partial class AddNewPlayerWindow : Window
    {
        MainWindow _mainWindow;
        public AddNewPlayerWindow(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.Show();
            Close();
        }

        private void AddPlayerBtn_Click(object sender, RoutedEventArgs e)
        {
            string FirstName = FirstNameTextBox.Text;
            string LastName = LastNameTextBox.Text;
            string BattingAverage = BattingAverageTextBox.Text;
            Players player = new Players();

            try
            {
                player.FirstName = FirstName;
                player.LastName = LastName;
                player.BattingAverage = decimal.Parse(BattingAverage);
                _mainWindow.dbContext.Players.Add(player);
                _mainWindow.dbContext.SaveChanges();
                MessageBox.Show("Player saved");

                _mainWindow.Show();
                Close();
            }
            catch (System.FormatException)
            {
                _mainWindow.dbContext.Players.Remove(player);
                MessageBox.Show("It was not possible to save the information. Make sure all fields are filled.", "Error Saving");
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException)
            {
                _mainWindow.dbContext.Remove(player);
                MessageBox.Show("It was not possible to save the information. Make sure the Batting Average is equal or less then 0.999", "Error Saving");
            }

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _mainWindow.Close();
        }
    }
}

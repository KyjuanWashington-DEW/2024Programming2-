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

namespace DEWsBatsOfBrackenCave
{
    /// <summary>
    /// Interaction logic for SetupPage.xaml
    /// </summary>
    public partial class SetupPage : Page
    {
        MainWindow win = (MainWindow)Application.Current.MainWindow;
        public SetupPage()
        {
            InitializeComponent();
        }

        private bool isFirstClick = true;
        private void NameTextBox_GotFocus(object sender, RoutedEventArgs e)
        {

            if (isFirstClick && NameTextBox.Text == "Enter Your Name Here")
            {
                NameTextBox.Text = string.Empty;
                NameTextBox.Foreground = new SolidColorBrush(Colors.Black);
                isFirstClick = false;
            }
        }

        private void NameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
              
               
                win.player.PlayerName = NameTextBox.Text;


                NavigationService.Navigate(new GamePage());
            }
        }




        private void OneButton_GotFocus(object sender, RoutedEventArgs e)
        {
            OneButton.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 255, 251, 0));
        }

        private void TwoButton_GotFocus(object sender, RoutedEventArgs e)
        {
            TwoButton.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 255, 251, 0));
        }


        private void TwoButton_Click(object sender, RoutedEventArgs e)
        {
            OneButton.Opacity = 0.5;
            TwoButton.Opacity = 1.0;
            OneButton.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 162, 0, 0));
        }

        private void OneButton_Click(object sender, RoutedEventArgs e)
        {
            TwoButton.Opacity = 0.5;
            OneButton.Opacity = 1.0;
            TwoButton.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 162, 0, 0));
        }
    }
}

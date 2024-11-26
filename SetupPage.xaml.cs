using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;
using System.Windows.Media;

namespace DEWsOggleWPF
{
    public partial class SetupPage : Page
    {
        
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
                Player player = new Player();

                player.Playername = NameTextBox.Text;

                
                NavigationService.Navigate(new GameTimePage(player));
            }
        }

    }
}

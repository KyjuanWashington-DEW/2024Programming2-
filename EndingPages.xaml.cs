using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Numerics;
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


namespace DEWsOggleWPF
{
    public partial class EndingPages : Page
    {
        private int WinPoints;
        private Player player;
        private int Rounds;
        private Stopwatch gameTimer;

        public EndingPages(int WinPoints, Player player, Stopwatch gameTimer, int Rounds)
        {
            InitializeComponent();
            this.WinPoints = WinPoints;
            this.player = player;
            this.gameTimer = gameTimer;
            this.Rounds = Rounds;
            Ended();
        }

        public void Ended()
        {
            if (Rounds == 3)
            {
                LeaderboardTextBlock.Text = $"\nCongrats, You Guessed All Of The Words.\n\n----LEADERBOARD----\n{player.Playername}  Final Score:{player.Score}\n\nRounds Played:{Rounds} Time Played:{gameTimer}\n\nContinue Playing?";

            }
           else LeaderboardTextBlock.Text = $"\nCongrats, You Won.\n\n----LEADERBOARD----\n{player.Playername}  Final Score:{player.Score}\n\nRounds Played:{Rounds} Time Played:{gameTimer}\n\nContinue Playing?";
        }

        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
            LeaderboardTextBlock.Text = "WELL BYE THEN I SUPPOSE.";
            NoButton.Visibility = Visibility.Collapsed;
            YesButton.Visibility = Visibility.Collapsed;
            ByeButton.Visibility = Visibility.Visible;
            //maybe I could Add A Timer Till App Close Herre
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WinPoints = 4;
            NavigationService?.Navigate(new GameTimePage(player));
        }

        private void ByeButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}

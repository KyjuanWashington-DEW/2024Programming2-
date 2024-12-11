using DEWsBatsOfBrackenCave;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace DEWsBatsOfBrackenCave
{
    public partial class GamePage : Page
    {
        public int ChangeInMoney;
        public string[] ItemsSold;
        public string[] ItemsPurchased;
        public int Day;
        public bool fox = false;
        public bool owl = false;
        public bool snake = false;

        public enum Weekday
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        private GameClock gameClock;
        private Player player;
        private Environment environment;
        private Entity entity;
        private Prey prey;
        private Predator predator;
        private Item item;
        private SetupPage setupPage;
        private Shopkeep shopkeep;
        private Random random = new Random();

        MainWindow win = (MainWindow)Application.Current.MainWindow;
        private DispatcherTimer gameTimer;

        public Weekday CurrentDay { get; set; }

        public GamePage()
        {
            InitializeComponent();
            this.setupPage = new SetupPage();
            this.player = new Player();
            shopkeep = new Shopkeep();
            prey = new Prey("Bat Prey", "A nocturnal mammal that is preyed upon by various predators.", 15, 100, 0, 5, "Guano");
            ShopTextBlock.Text = shopkeep.DisplayShopInventory();
            gameClock = new GameClock(UpdateClockAndBackground);
            gameClock.Start();
            UIUpdateCurrent(); 
            gameTimer = new DispatcherTimer();
            gameTimer.Interval = TimeSpan.FromSeconds(1);
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (gameClock.Gamepaused == false)
            {
                RandomEventCallEveryFewSeconds();
            }

            if (gameClock.elapsedSeconds >= 1200)
            {
                NextDay();
            }
            UIUpdateCurrent(); 
        }

        private void UIUpdateCurrent()
        {
            BatIrritation.Text = $"{prey.Irritation}";
            BatsPopulation.Text = $"{prey.Population}";
            HUDBOX.Text = $"{win.player.PlayerName} {win.player.Money.ToString("C")}";

            if (setupPage.oneButton == true)
            {
                PlayerPictureBlock.Background = new SolidColorBrush(Colors.Red);
            }
            else if (setupPage.twoButton == true)
            {
                PlayerPictureBlock.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF0061FF"));
            }
            WeekdayTextBlock.Text = CurrentDay.ToString();
        }

        private void BackgroundUpdate()
        {
            if (gameClock.elapsedSeconds >= 60 && gameClock.elapsedSeconds < 300)
            {
                SkyBlock.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF0061FF"));
            }
            else if (gameClock.elapsedSeconds >= 300 && gameClock.elapsedSeconds < 450)
            {
                SkyBlock.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF4B0082"));
            }
            else if (gameClock.elapsedSeconds >= 450 && gameClock.elapsedSeconds < 600)
            {
                SkyBlock.Background = new SolidColorBrush(Colors.Purple);
            }
            else if (gameClock.elapsedSeconds >= 600 && gameClock.elapsedSeconds < 660)
            {
                SkyBlock.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#800000"));
            }
            else if (gameClock.elapsedSeconds >= 660)
            {
                SkyBlock.Background = new SolidColorBrush(Colors.Black);
            }
        }

        private void UpdateClockAndBackground(string time, SolidColorBrush background)
        {
            ClockBlock.Text = time;
            BackgroundUpdate();
        }

        public void RandomEventCallEveryFewSeconds()
        {
            if (prey.Irritation < 10)
            {
                prey.Population += 5;
            }

            if (prey.Irritation < 40)
            {
                prey.IncreaseIrritation();
            }

            if (prey.Irritation >= 40)
            {
                prey.DecreasePopulation(6);

                if (prey.Irritation >= 60)
                {
                    prey.DecreasePopulation(10);
                }

                if (prey.Population <= 0)
                {
                    GameEnd.Text = "Game over! All bats died.";
                }
            }

            if (gameClock.elapsedSeconds < 1200)
            {
                RandomPredatorCallTimes();
            }

            if (gameClock.elapsedSeconds % 10 == 0)
            {
                if (fox == true)
                {
                    MessageBox.Show("A fox wants to put the bats in a box");
                    prey.IncreaseIrritation();
                    prey.DecreasePopulation();
                }

                if (owl == true && gameClock.elapsedSeconds >= 480)
                {
                    MessageBox.Show("An owl is on the prowl");
                    prey.IncreaseIrritation();
                    prey.DecreasePopulation(2);
                }

                if (snake == true && gameClock.elapsedSeconds <= 240)
                {
                    MessageBox.Show("A snake is putting the bat's lives at stake");
                    prey.IncreaseIrritation();
                }
            }
        }

        public void RandomPredatorCallTimes()
        {
            if (random.Next(1, 16) == 1)
            {
                RandomPredatorPick();
            }
        }

        public void RandomPredatorPick()
        {
            int choice = random.Next(1, 4);
            string imagePath = string.Empty;

            switch (choice)
            {
                case 1:
                    fox = true;
                    imagePath = "Images/fox.png";
                    break;
                case 2:
                    owl = true;
                    imagePath = "Images/owl.png";
                    break;
                case 3:
                    snake = true;
                    imagePath = "Images/snake.png";
                    break;
            }

            PredatorImage.ImageSource = new BitmapImage(new Uri(imagePath, UriKind.Relative));
        }

        private void NextDay()
        {
            gameClock.elapsedSeconds = 0;
            Day++;

            if (CurrentDay == Weekday.Sunday)
            {
                CurrentDay = Weekday.Monday;
            }
            else
            {
                CurrentDay++;
            }

            UIUpdateCurrent();
        }

        private void PopupMessages()
        {
            if (gameClock.Timestopped == true)
            {
                MessageBox.Show($"Your Earnings for Today: {ChangeInMoney}\n\n" +
                    $"Items Sold:{ItemsSold + ","}" +
                    $"Items Bought:{ItemsPurchased + ","}" +
                    $"\n\n\n{win.player.PlayerName} {win.player.Money.ToString("C")}");
                gameClock.Reset();
            }

            if (gameClock.Gamepaused == true)
            {
                MessageBox.Show("The Game Timer Is Paused");
                gameClock.Start();
            }
        }

        private void RandomPredator_Click(object sender, RoutedEventArgs e)
        {
            RepellPredator();
        }

        public void RepellPredator()
        {
            if (snake == true)
            {
                player.UseItem(player.snakeRepellant);
            }
            else if (owl == true)
            {
                player.UseItem(player.owlRepellant);
            }
            else if (fox == true)
            {
                player.UseItem(player.foxRepellant);
            }

            snake = false;
            owl = false;
            fox = false;
            PredatorImage.ImageSource = null;
        }

        private void NextDay_Click(object sender, RoutedEventArgs e)
        {
            gameClock.Timestopped = true;
            PopupMessages();
        }

        private void ShopButton_Click(object sender, RoutedEventArgs e)
        {
            gameClock.Pause();
            gameClock.Gamepaused = true;
            BackButton.Visibility = Visibility.Visible;
            SellButton.Visibility = Visibility.Visible;
            BuyButton.Visibility = Visibility.Visible;
            ItemNumberTextBox.Visibility = Visibility.Visible;
            ItemQuantityTextBox.Visibility = Visibility.Visible;
            ShopSellTextBlock.Visibility = Visibility.Visible;
            ShopTextBlock.Visibility = Visibility.Visible;
        }

        private void EnterCave_Click(object sender, RoutedEventArgs e)
        {
            SkyBlock.Visibility = Visibility.Collapsed;
            CaveStone.Visibility = Visibility.Collapsed;
            CaveBlack.Visibility = Visibility.Collapsed;
            CaveText.Visibility = Visibility.Collapsed;
            RandomPredator.Visibility = Visibility.Collapsed;
            Nextday.Visibility = Visibility.Collapsed;
            ShopButton.Visibility = Visibility.Collapsed;
            SellButton.Visibility = Visibility.Collapsed;
            BuyButton.Visibility = Visibility.Collapsed;

            PlayerPictureBlock.Visibility = Visibility.Visible;
            ClockBlock.Visibility = Visibility.Visible;
            HUDBOX.Visibility = Visibility.Visible;
            BackButton.Visibility = Visibility.Visible;
        }

        private void SellButton_Click(object sender, RoutedEventArgs e)
        {

        }

        public void DisplayShopItems(Player player, TextBlock shopTextBlock)
        {
            shopTextBlock.Text = "";
            shopTextBlock.Text += $"Shop Items:\n";
            shopTextBlock.Text += $"1. {player.owlRepellant.Name} - ${player.owlRepellant.Value} (In Stock: {player.owlRepellant.Amount})\n";
            shopTextBlock.Text += $"2. {player.foxRepellant.Name} - ${player.foxRepellant.Value} (In Stock: {player.foxRepellant.Amount})\n";
            shopTextBlock.Text += $"3. {player.snakeRepellant.Name} - ${player.snakeRepellant.Value} (In Stock: {player.snakeRepellant.Amount})\n";
        }

        private void BuyButton_Click(object sender, RoutedEventArgs e)
        {
            string itemName = "Owl Repellant";
            bool success = shopkeep.SellItem(itemName, player);

            if (success)
            {
                MessageBox.Show($"{win.player.PlayerName} bought {itemName}!");
                ShopTextBlock.Text = shopkeep.DisplayShopInventory();
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            ItemNumberTextBox.Visibility = Visibility.Hidden;
            ItemQuantityTextBox.Visibility = Visibility.Hidden;
            ShopSellTextBlock.Visibility = Visibility.Hidden;
            ShopTextBlock.Visibility = Visibility.Hidden;
            BuyButton.Visibility = Visibility.Hidden;
            SellButton.Visibility = Visibility.Hidden;
            BackButton.Visibility = Visibility.Hidden;

            gameClock.Start();
            gameClock.Gamepaused = false;
        }

        private void TouristTime_Click(object sender, RoutedEventArgs e)
        {
            win.player.Money += 100;
            prey.Irritation += 10;
        }

        private void Feed_Click(object sender, RoutedEventArgs e)
        {
            prey.Irritation -= 10;
            win.player.Money -= 80;
            prey.Population += 5;
        }
    }
}

//HUDBOX.Text = $"{win.player.PlayerName} {win.player.Money.ToString("C")}";
//BatIrritation.Text = $"{prey.Irritation}";

//// Optionally, you can also display a message box to give feedback to the player
//MessageBox.Show($"You earned 100 money! Current Money: {player.Money.ToString("C")}\nPrey Irritation: {prey.Irritation}");
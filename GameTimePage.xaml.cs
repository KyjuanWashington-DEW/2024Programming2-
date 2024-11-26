using DEWsOggleWPF;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Numerics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;





namespace DEWsOggleWPF
{
    public partial class GameTimePage : Page
{
    public  Stopwatch gameTimer = new();
    private  Gameboard board = new();
    private string input = string.Empty;
        private string s = "s ";
    public Player player { get; }
    public int WinPoints { get; set; } = 4;
    public int Rounds { get; set; } = 1;

    public GameTimePage(Player player)
    {
        InitializeComponent();
        this.player = player;

        
        this.PreviewKeyDown += Page_PreviewKeyDown;
           
            gameTimer.Start();
        RoundTextBlock.Text = $"{Rounds}";
        ScoreTextBlock.Text = $"{player.Score}";
        InfoMessageTextBlock.Text = $"You Need To Guess {WinPoints} Word{s}To Win.";

        PlayerNameTextBlock.Text = player.Playername;
        SetupBoard();
    }

    private void SetupBoard()
    {
           
        var random = new Random();
        var shuffledLetters = board.boardLetters.OrderBy(_ => random.Next()).ToList();

        foreach (string letter in shuffledLetters)
        {
            Button tile = new Button
            {
                Content = letter,
                Width = 60,
                Height = 40,
                Margin = new Thickness(5)
            };
            tile.Click += Tile_Click;
            Boggleboard.Children.Add(tile);
        }

      
    }

    private void Tile_Click(object sender, RoutedEventArgs e)
    {
        if (sender is Button clickedButton && clickedButton.Content is string letter)
        {
            input += letter;
            AnswerBox.Text = $"Word: {input}";
        }
    }

    private void Page_PreviewKeyDown(object sender, KeyEventArgs e)
    {
        if (e.Key == Key.Back)
        {
            e.Handled = true; 
            if (input.Length > 0)
            {
                input = input.Remove(input.Length - 1);
                AnswerBox.Text = $"Word: {input}";
            }
        }
    }
        private void TransitionToEnding()
        {
            NavigationService?.Navigate(new EndingPages(WinPoints, player,gameTimer,Rounds));
        }
        private bool isValid(string word)
    {
        return board.potentialWords.Any(w => string.Equals(w, word, StringComparison.OrdinalIgnoreCase));
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        

            if (WinPoints == 1)
            {
                s = " ";
            }
        if (!string.IsNullOrWhiteSpace(input))
        {
            if (isValid(input))
            {
                if (!player.guessedWords.Contains(input, StringComparer.OrdinalIgnoreCase))
                {
                    WinPoints--;
                    player.Score += input.Length;
                    player.guessedWords.Add(input);
                        InfoMessageTextBlock.Text = $"You need to guess {WinPoints} word{s} to win.";

                        PopupMessageTextBlock.Text = $"You Found A Word! It Was Worth {input.Length} Points.";
                    PopupMessageTextBlock.Foreground = System.Windows.Media.Brushes.Green;

                        WordsEntered.Text = $"Words Found: {string.Join(", ", player.guessedWords)}";
                    }
                else
                {
                    PopupMessageTextBlock.Text = "You Have Already Guessed This Word!";
                    PopupMessageTextBlock.Foreground = System.Windows.Media.Brushes.Red;
                }
            }
            else
            {
                PopupMessageTextBlock.Text = "Incorrect Guess. Try Again.";
                PopupMessageTextBlock.Foreground = System.Windows.Media.Brushes.Red;
            }
        }
        else
        {
            PopupMessageTextBlock.Text = "Enter A Word Before Submitting.";
            PopupMessageTextBlock.Foreground = System.Windows.Media.Brushes.Red;
        }

        ScoreTextBlock.Text = $"{player.Score}";
        PopupMessageTextBlock.Visibility = Visibility.Visible;

        input = string.Empty;
        AnswerBox.Text = "Word:";
            if (WinPoints == 0)
            {
                Rounds++;
                TransitionToEnding();
                return;
            }
        }

        private void ShuffleButton_Click(object sender, RoutedEventArgs e)
        {
            Boggleboard.Children.Clear();
            SetupBoard();
        }
    }
}



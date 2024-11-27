using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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
    public partial class GamePage : Page
    {
        MainWindow win = (MainWindow)Application.Current.MainWindow;

        public GamePage()
        {
            InitializeComponent();

            UIUpdate();



        }
        private void UIUpdate()
        {
            HUDBOX.Text = $"{win.player.PlayerName} {win.player.Money.ToString("C")}";
        }
        
    }
}

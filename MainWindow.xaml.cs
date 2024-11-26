using System.Numerics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DEWsOggleWPF;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        Main.Content = new SetupPage();
    }

   

}



//INPUT LOGIC ENTER KEY READING FOR ANSWERING
//private void Input_KeyDown(object sender, KeyEventArgs e)
//{
//    string word = Input.Text;
//    if (e.Key == Key.Return)
//    {
//        Input.Text = "";
//        SolveFor(word);
//    }
//}
//private void SolveFor()
//{

//}
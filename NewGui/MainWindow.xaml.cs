using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
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
using SudokuGame;

namespace NewGui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Game _game;
        private Button _currentButton;
        private int[,] _sudokuBtns = new int[9,9]; 
        public MainWindow()
        {
            _game = new Game();
            _game.Load();

            InitializeComponent();      
            GenerateSudokuButtons();
        }

        private void GenerateSudokuButtons()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Button btn = new Button();
                    if (_game.sudoku.GetNumber(i, j) !=0) btn.Content = _game.sudoku.GetNumber(i, j);
                    btn.Click += new RoutedEventHandler(this.BtnSudoku_Click);
                    
                    btn.Width = 30;
                    btn.Height = 30;
                    btn.Margin = new Thickness(-500 + 70*i, -300 + 70*j, 0, 0);
                    _grid.Children.Add(btn);
                }
            }
        }

        private EventHandler BtnClick()
        {
            throw new NotImplementedException();
        }

        private void BtnSudoku_Click(object sender, RoutedEventArgs e)
        {
            _currentButton = (Button) sender;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _currentButton.Content = "1";
            //remember to update logic....
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _currentButton = (Button)sender;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            _currentButton = (Button)sender;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            _currentButton = (Button)sender;
        }

        private void add2_Click(object sender, RoutedEventArgs e)
        {
            _currentButton.Content = "2";
            //remember to add value to sudoku as well
        }

        private void add3_Click(object sender, RoutedEventArgs e)
        {
            _currentButton.Content = "3";
        }
    }
}

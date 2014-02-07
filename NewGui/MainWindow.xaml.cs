using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        private Button[,] _sudokuBtns = new Button[9,9]; 
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
                    if (_game.sudoku.GetNumber(i, j) !=0) 
                    {
                        btn.Content = _game.sudoku.GetNumber(i, j);
                        btn.IsEnabled = false;
                    }
                    btn.Click += new RoutedEventHandler(this.BtnSudoku_Click);
                    
                    btn.Width = 30;
                    btn.Height = 30;
                    btn.Margin = new Thickness(-500 + 70*i, -300 + 70*j, 0, 0);
                    
                    // add the btn to my 2d array
                    _sudokuBtns[i, j] = btn;
                    
                    //add it to the gui
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

        private void add4_Click(object sender, RoutedEventArgs e)
        {
            _currentButton.Content = 4;
        }

        private void add5_Click(object sender, RoutedEventArgs e)
        {
            _currentButton.Content = 5;
        }

        private void add6_Click(object sender, RoutedEventArgs e)
        {
            _currentButton.Content = 6;
        }

        private void add7_Click(object sender, RoutedEventArgs e)
        {
            _currentButton.Content = 7;
        }

        private void add8_Click(object sender, RoutedEventArgs e)
        {
            _currentButton.Content = 8;
        }

        private void add9_Click(object sender, RoutedEventArgs e)
        {
            _currentButton.Content = 9;
        }

        private void BtnValidate_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("BEFORE UPDATE");
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    System.Diagnostics.Debug.Write(_game.sudoku.Numbers[i, j]);
                    Debug.WriteLine("");

                }
            }

            //update logic part
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                   _game.sudoku.Numbers[j,i] = Convert.ToInt16(_sudokuBtns[i, j].Content);
                }
            }

            MessageBoxResult result = MessageBox.Show(_game.isValid().ToString());

            Debug.WriteLine("AFTER UPDATE");
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    System.Diagnostics.Debug.Write( _game.sudoku.Numbers[i, j] );
                    Debug.WriteLine("");
                    
                }
            }
        }
    }
}

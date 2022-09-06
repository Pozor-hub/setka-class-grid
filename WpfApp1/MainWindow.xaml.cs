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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int buttonCounter = 0;
        private int buttonContentCounter = 1;
        private int rowConter = 0;
        private int columnCounter = 0;



        private Brush[] brushes = new Brush[]
        {
            Brushes.White,
            Brushes.Black,
            Brushes.Yellow,
            Brushes.YellowGreen
        };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonClick(object knopka, RoutedEventArgs p);
        {
          UIElement eelement = (UIElement)sender;
          ButtonGrid.Children.Remove(element);
        }
            private bool InEmty
    }
}
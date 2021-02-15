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

namespace EsercizioCinema
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            posto1.Fill = System.Windows.Media.Brushes.Green;
            posto2.Fill = System.Windows.Media.Brushes.Green;
            posto3.Fill = System.Windows.Media.Brushes.Green;
            posto4.Fill = System.Windows.Media.Brushes.Green;
            posto5.Fill = System.Windows.Media.Brushes.Green;
            posto6.Fill = System.Windows.Media.Brushes.Green;
            posto7.Fill = System.Windows.Media.Brushes.Green;
            posto8.Fill = System.Windows.Media.Brushes.Green;
            posto9.Fill = System.Windows.Media.Brushes.Green;
           
        }

        private void btnSvuotaCinema_Click(object sender, RoutedEventArgs e)
        {
            posto1.Fill = System.Windows.Media.Brushes.Green;
            posto2.Fill = System.Windows.Media.Brushes.Green;
            posto3.Fill = System.Windows.Media.Brushes.Green;
            posto4.Fill = System.Windows.Media.Brushes.Green;
            posto5.Fill = System.Windows.Media.Brushes.Green;
            posto6.Fill = System.Windows.Media.Brushes.Green;
            posto7.Fill = System.Windows.Media.Brushes.Green;
            posto8.Fill = System.Windows.Media.Brushes.Green;
            posto9.Fill = System.Windows.Media.Brushes.Green;
        }
    }
}

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
        private static object x = new object();
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


        private void btnCassa2_Click(object sender, RoutedEventArgs e)
        {
            Cassa2();
        }

        private void btnCassa1_Click(object sender, RoutedEventArgs e)
        {
            Cassa1();
        }
        public void Cassa1()
        {
            int prenotazioneInput = int.Parse(txt1.Text);
            lock (x)
            {
                if (prenotazioneInput == 1 || prenotazioneInput == 2 || prenotazioneInput == 3 || prenotazioneInput == 4 || prenotazioneInput == 5 || prenotazioneInput == 6 || prenotazioneInput == 7 || prenotazioneInput == 8 || prenotazioneInput == 9)
                {
                    if (prenotazioneInput == 1)
                    {
                        if(posto1.Fill== System.Windows.Media.Brushes.Green)
                        {
                            posto1.Fill = System.Windows.Media.Brushes.Red;
                            MessageBox.Show("Il posto è stato prenotato");
                            txt1.Clear();
                        }
                        else if(posto1.Fill== System.Windows.Media.Brushes.Red)
                        {
                            MessageBox.Show("Il posto è gia occupato");
                            txt1.Clear();
                        }
                    }
                    if (prenotazioneInput == 2)
                    {
                        if (posto2.Fill == System.Windows.Media.Brushes.Green)
                        {
                            posto2.Fill = System.Windows.Media.Brushes.Red;
                            MessageBox.Show("Il posto è stato prenotato");
                            txt1.Clear();
                        }
                        else if (posto2.Fill == System.Windows.Media.Brushes.Red)
                        {
                            MessageBox.Show("Il posto è gia occupato");
                            txt1.Clear();
                        }
                    }
                    if (prenotazioneInput == 3)
                    {
                        if (posto3.Fill == System.Windows.Media.Brushes.Green)
                        {
                            posto3.Fill = System.Windows.Media.Brushes.Red;
                            MessageBox.Show("Il posto è stato prenotato");
                            txt1.Clear();
                        }
                        else if (posto3.Fill == System.Windows.Media.Brushes.Red)
                        {
                            MessageBox.Show("Il posto è gia occupato");
                            txt1.Clear();
                        }
                    }
                    if (prenotazioneInput == 4)
                    {
                        if (posto4.Fill == System.Windows.Media.Brushes.Green)
                        {
                            posto4.Fill = System.Windows.Media.Brushes.Red;
                            MessageBox.Show("Il posto è stato prenotato");
                            txt1.Clear();
                        }
                        else if (posto4.Fill == System.Windows.Media.Brushes.Red)
                        {
                            MessageBox.Show("Il posto è gia occupato");
                            txt1.Clear();
                        }
                    }
                    if (prenotazioneInput == 5)
                    {
                        if (posto5.Fill == System.Windows.Media.Brushes.Green)
                        {
                            posto5.Fill = System.Windows.Media.Brushes.Red;
                            MessageBox.Show("Il posto è stato prenotato");
                            txt1.Clear();
                        }
                        else if (posto5.Fill == System.Windows.Media.Brushes.Red)
                        {
                            MessageBox.Show("Il posto è gia occupato");
                            txt1.Clear();
                        }
                    }
                    if (prenotazioneInput == 6)
                    {
                        if (posto6.Fill == System.Windows.Media.Brushes.Green)
                        {
                            posto6.Fill = System.Windows.Media.Brushes.Red;
                            MessageBox.Show("Il posto è stato prenotato");
                            txt1.Clear();
                        }
                        else if (posto6.Fill == System.Windows.Media.Brushes.Red)
                        {
                            MessageBox.Show("Il posto è gia occupato");
                            txt1.Clear();
                        }
                    }
                    if (prenotazioneInput == 7)
                    {
                        if (posto7.Fill == System.Windows.Media.Brushes.Green)
                        {
                            posto7.Fill = System.Windows.Media.Brushes.Red;
                            MessageBox.Show("Il posto è stato prenotato");
                            txt1.Clear();
                        }
                        else if (posto7.Fill == System.Windows.Media.Brushes.Red)
                        {
                            MessageBox.Show("Il posto è gia occupato");
                            txt1.Clear();
                        }
                    }
                    if (prenotazioneInput == 8)
                    {
                        if (posto8.Fill == System.Windows.Media.Brushes.Green)
                        {
                            posto8.Fill = System.Windows.Media.Brushes.Red;
                            MessageBox.Show("Il posto è stato prenotato");
                            txt1.Clear();
                        }
                        else if (posto8.Fill == System.Windows.Media.Brushes.Red)
                        {
                            MessageBox.Show("Il posto è gia occupato");
                            txt1.Clear();
                        }
                    }
                    if (prenotazioneInput == 9)
                    {
                        if (posto9.Fill == System.Windows.Media.Brushes.Green)
                        {
                            posto9.Fill = System.Windows.Media.Brushes.Red;
                            MessageBox.Show("Il posto è stato prenotato");
                            txt1.Clear();
                        }
                        else if (posto9.Fill == System.Windows.Media.Brushes.Red)
                        {
                            MessageBox.Show("Il posto è gia occupato");
                            txt1.Clear();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Il numero del posto inserito non rientra nel range");
                    txt1.Clear();
                }
            }
        }
        public void Cassa2()
        {
            int prenotazioneInput = int.Parse(txt2.Text);
            //stessi comandi per cassa2
            lock (x)
            {
                if (prenotazioneInput == 1 || prenotazioneInput == 2 || prenotazioneInput == 3 || prenotazioneInput == 4 || prenotazioneInput == 5 || prenotazioneInput == 6 || prenotazioneInput == 7 || prenotazioneInput == 8 || prenotazioneInput == 9)
                {
                    if (prenotazioneInput == 1)
                    {
                        if (posto1.Fill == System.Windows.Media.Brushes.Green)
                        {
                            posto1.Fill = System.Windows.Media.Brushes.Red;
                            MessageBox.Show("Il posto è stato prenotato");
                            txt2.Clear();
                        }
                        else if (posto1.Fill == System.Windows.Media.Brushes.Red)
                        {
                            MessageBox.Show("Il posto è gia occupato");
                            txt2.Clear();
                        }
                    }
                    if (prenotazioneInput == 2)
                    {
                        if (posto2.Fill == System.Windows.Media.Brushes.Green)
                        {
                            posto2.Fill = System.Windows.Media.Brushes.Red;
                            MessageBox.Show("Il posto è stato prenotato");
                            txt2.Clear();
                        }
                        else if (posto2.Fill == System.Windows.Media.Brushes.Red)
                        {
                            MessageBox.Show("Il posto è gia occupato");
                            txt2.Clear();
                        }
                    }
                    if (prenotazioneInput == 3)
                    {
                        if (posto3.Fill == System.Windows.Media.Brushes.Green)
                        {
                            posto3.Fill = System.Windows.Media.Brushes.Red;
                            MessageBox.Show("Il posto è stato prenotato");
                            txt2.Clear();
                        }
                        else if (posto3.Fill == System.Windows.Media.Brushes.Red)
                        {
                            MessageBox.Show("Il posto è gia occupato");
                            txt2.Clear();
                        }
                    }
                    if (prenotazioneInput == 4)
                    {
                        if (posto4.Fill == System.Windows.Media.Brushes.Green)
                        {
                            posto4.Fill = System.Windows.Media.Brushes.Red;
                            MessageBox.Show("Il posto è stato prenotato");
                            txt2.Clear();
                        }
                        else if (posto4.Fill == System.Windows.Media.Brushes.Red)
                        {
                            MessageBox.Show("Il posto è gia occupato");
                            txt2.Clear();
                        }
                    }
                    if (prenotazioneInput == 5)
                    {
                        if (posto5.Fill == System.Windows.Media.Brushes.Green)
                        {
                            posto5.Fill = System.Windows.Media.Brushes.Red;
                            MessageBox.Show("Il posto è stato prenotato");
                            txt2.Clear();
                        }
                        else if (posto5.Fill == System.Windows.Media.Brushes.Red)
                        {
                            MessageBox.Show("Il posto è gia occupato");
                            txt2.Clear();
                        }
                    }
                    if (prenotazioneInput == 6)
                    {
                        if (posto6.Fill == System.Windows.Media.Brushes.Green)
                        {
                            posto6.Fill = System.Windows.Media.Brushes.Red;
                            MessageBox.Show("Il posto è stato prenotato");
                            txt2.Clear();
                        }
                        else if (posto6.Fill == System.Windows.Media.Brushes.Red)
                        {
                            MessageBox.Show("Il posto è gia occupato");
                            txt2.Clear();
                        }
                    }
                    if (prenotazioneInput == 7)
                    {
                        if (posto7.Fill == System.Windows.Media.Brushes.Green)
                        {
                            posto7.Fill = System.Windows.Media.Brushes.Red;
                            MessageBox.Show("Il posto è stato prenotato");
                            txt2.Clear();
                        }
                        else if (posto7.Fill == System.Windows.Media.Brushes.Red)
                        {
                            MessageBox.Show("Il posto è gia occupato");
                            txt2.Clear();
                        }
                    }
                    if (prenotazioneInput == 8)
                    {
                        if (posto8.Fill == System.Windows.Media.Brushes.Green)
                        {
                            posto8.Fill = System.Windows.Media.Brushes.Red;
                            MessageBox.Show("Il posto è stato prenotato");
                            txt2.Clear();
                        }
                        else if (posto8.Fill == System.Windows.Media.Brushes.Red)
                        {
                            MessageBox.Show("Il posto è gia occupato");
                            txt2.Clear();
                        }
                    }
                    if (prenotazioneInput == 9)
                    {
                        if (posto9.Fill == System.Windows.Media.Brushes.Green)
                        {
                            posto9.Fill = System.Windows.Media.Brushes.Red;
                            MessageBox.Show("Il posto è stato prenotato");
                            txt2.Clear();
                        }
                        else if (posto9.Fill == System.Windows.Media.Brushes.Red)
                        {
                            MessageBox.Show("Il posto è gia occupato");
                            txt2.Clear();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Il numero del posto inserito non rientra nel range");
                    txt2.Clear();
                }
            }
        }

     
       
    }
}

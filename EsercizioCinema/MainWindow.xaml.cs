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
using System.Threading;

namespace EsercizioCinema
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static object x = new object();
        Thread t1;
        Thread t2;

        int prenotazioneInput = 0;
       
       

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

        private void btnCassa2_Click(object sender, RoutedEventArgs e)
        {
            prenotazioneInput = int.Parse(txt2.Text);
            t2 = new Thread(new ThreadStart(Cassa2));
            
            t2.Start();
          
        }

        private void btnCassa1_Click(object sender, RoutedEventArgs e)
        {
            prenotazioneInput = int.Parse(txt1.Text);
            t1 = new Thread(new ThreadStart(Cassa1));
            t1.Start();

        }
        public void Cassa1()
        {
           
            lock (x)
            {
                if (prenotazioneInput == 1 || prenotazioneInput == 2 || prenotazioneInput == 3 || prenotazioneInput == 4 || prenotazioneInput == 5 || prenotazioneInput == 6 || prenotazioneInput == 7 || prenotazioneInput == 8 || prenotazioneInput==9)
                {
                    switch (prenotazioneInput)
                    {
                        case 1:
                            {
                                if (prenotazioneInput == 1)
                                {

                                    this.Dispatcher.BeginInvoke(new Action(() =>
                                    {
                                        if (posto1.Fill == System.Windows.Media.Brushes.Green)
                                        {
                                            posto1.Fill = System.Windows.Media.Brushes.Red;
                                            MessageBox.Show("Il posto è stato prenotato");
                                            txt1.Clear();
                                        }
                                        else if (posto1.Fill == System.Windows.Media.Brushes.Red)
                                        {
                                            MessageBox.Show("Il posto è gia occupato");
                                            txt1.Clear();
                                        }
                                    }));
                                }
                                break;
                            }



                        case 2:
                            {
                                if (prenotazioneInput == 2)
                                {

                                    this.Dispatcher.BeginInvoke(new Action(() =>
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
                                    }));
                                }
                                break;
                            }
                        case 3:
                            {
                                if (prenotazioneInput == 3)
                                {

                                    this.Dispatcher.BeginInvoke(new Action(() =>
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
                                    }));
                                }
                                break;
                            }
                        case 4:
                            {
                                if (prenotazioneInput == 4)
                                {

                                    this.Dispatcher.BeginInvoke(new Action(() =>
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
                                    }));
                                }
                                break;
                            }
                        case 5:
                            {
                                if (prenotazioneInput == 5)
                                {

                                    this.Dispatcher.BeginInvoke(new Action(() =>
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
                                    }));
                                }
                                break;
                            }
                        case 6:
                            {
                                if (prenotazioneInput == 6)
                                {

                                    this.Dispatcher.BeginInvoke(new Action(() =>
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
                                    }));
                                }
                                break;
                            }
                        case 7:
                            {
                                if (prenotazioneInput == 7)
                                {

                                    this.Dispatcher.BeginInvoke(new Action(() =>
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
                                    }));
                                }
                                break;
                            }
                        case 8:
                            {
                                if (prenotazioneInput == 8)
                                {

                                    this.Dispatcher.BeginInvoke(new Action(() =>
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
                                    }));
                                }
                                break;
                            }
                        case 9:
                            {
                                if (prenotazioneInput == 9)
                                {

                                    this.Dispatcher.BeginInvoke(new Action(() =>
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
                                    }));
                                }
                                break;
                            }

                    }
                    
                }
                else
                {
                    MessageBox.Show("Il numero nesiderato nonn rientra nel range");
                    txt1.Clear();
                }

            }
        }
        public void Cassa2()
        {

            //stessi comandi di cassa1
            
            lock (x)
            {
                if (prenotazioneInput == 1 || prenotazioneInput == 2 || prenotazioneInput == 3 || prenotazioneInput == 4 || prenotazioneInput == 5 || prenotazioneInput == 6 || prenotazioneInput == 7 || prenotazioneInput == 8 || prenotazioneInput == 9)
                {
                    switch (prenotazioneInput)
                    {
                        case 1:
                            {
                                if (prenotazioneInput == 1)
                                {

                                    this.Dispatcher.BeginInvoke(new Action(() =>
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
                                    }));
                                }
                                break;
                            }



                        case 2:
                            {
                                if (prenotazioneInput == 2)
                                {

                                    this.Dispatcher.BeginInvoke(new Action(() =>
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
                                    }));
                                }
                                break;
                            }
                        case 3:
                            {
                                if (prenotazioneInput == 3)
                                {

                                    this.Dispatcher.BeginInvoke(new Action(() =>
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
                                    }));
                                }
                                break;
                            }
                        case 4:
                            {
                                if (prenotazioneInput == 4)
                                {

                                    this.Dispatcher.BeginInvoke(new Action(() =>
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
                                    }));
                                }
                                break;
                            }
                        case 5:
                            {
                                if (prenotazioneInput == 5)
                                {

                                    this.Dispatcher.BeginInvoke(new Action(() =>
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
                                    }));
                                }
                                break;
                            }
                        case 6:
                            {
                                if (prenotazioneInput == 6)
                                {

                                    this.Dispatcher.BeginInvoke(new Action(() =>
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
                                    }));
                                }
                                break;
                            }
                        case 7:
                            {
                                if (prenotazioneInput == 7)
                                {

                                    this.Dispatcher.BeginInvoke(new Action(() =>
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
                                    }));
                                }
                                break;
                            }
                        case 8:
                            {
                                if (prenotazioneInput == 8)
                                {

                                    this.Dispatcher.BeginInvoke(new Action(() =>
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
                                    }));
                                }
                                break;
                            }
                        case 9:
                            {
                                if (prenotazioneInput == 9)
                                {

                                    this.Dispatcher.BeginInvoke(new Action(() =>
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
                                    }));
                                }
                                break;
                            }

                    }
                    
                }
                else
                {
                    MessageBox.Show("Il numero nesiderato nonn rientra nel range");
                    txt2.Clear();
                }
              

            }
            
        }

        private void btnSvuotaCinema_Click(object sender, RoutedEventArgs e)
        {
            ;
            lblSchemo.Visibility = Visibility.Visible;
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

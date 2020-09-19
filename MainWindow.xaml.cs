using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using YahooFinanceApi;
using TradingApp;
using System.Globalization;
using System.Printing;
using MaterialDesignColors.Recommended;
using System.Runtime.CompilerServices;
using TradingApp.Pages;

namespace TradingApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        private StocksInfo stocksInfo { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            stocksInfo = new StocksInfo("Other");
            OtherStackPanel.Children.Add(stocksInfo.GetLabel("Most Capitalize Company"));
            foreach (var i in stocksInfo.companyesSymbols)
            {
                OtherStackPanel.Children.Add(stocksInfo.GetExpander(i));
            }
            Update_Click(null, null);
        }
        private void Power_OFF_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void UnShow_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.MainWindow = this;
            Application.Current.MainWindow.Height = 600;
            Application.Current.MainWindow.Width = 1000;
        }

        private void Clip_Click(object sender, RoutedEventArgs e)
        {
            if (Topmost == true)
            {
                Topmost = false;
            }
            else
            {
                Topmost = true;
            }
        }

        private async void Update_Click(object sender, RoutedEventArgs e)
        {
             foreach(var i in stocksInfo.companyesSymbols)
             {
                await stocksInfo.GetData(i.Symbols);
                if(stocksInfo.InformationCompany[i.Symbols].Item2 < 0)
                {
                    i.label_price.Foreground = Brushes.Red;
                    i.label_procent.Foreground = Brushes.Red;
                    i.label_price.Content = stocksInfo.InformationCompany[i.Symbols].Item1.ToString() + "$";
                    i.label_procent.Content = stocksInfo.InformationCompany[i.Symbols].Item2.ToString() + "%";
                }
                else
                {
                    i.label_price.Foreground = Brushes.Green;
                    i.label_procent.Foreground = Brushes.Green;
                    i.label_price.Content = stocksInfo.InformationCompany[i.Symbols].Item1.ToString() + "$";
                    i.label_procent.Content = stocksInfo.InformationCompany[i.Symbols].Item2.ToString() + "%";
                }
             }
        }

        private void Communication_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
            {
                if (WindowState == WindowState.Maximized)
                {
                    var point = PointToScreen(e.MouseDevice.GetPosition(this));

                    if (point.X <= RestoreBounds.Width / 2)
                        Left = 0;

                    else if (point.X >= RestoreBounds.Width)
                        Left = point.X - (RestoreBounds.Width - (this.ActualWidth - point.X));

                    else
                        Left = point.X - (RestoreBounds.Width / 2);

                    Top = point.Y - (((FrameworkElement)sender).ActualHeight / 2);
                    WindowState = WindowState.Normal;
                }
                DragMove();
        }

        private void Game_Click(object sender, RoutedEventArgs e)
        {
            page_GameCompanyes game = new page_GameCompanyes();
            game.Show();
            this.Close();
        }
    }
}

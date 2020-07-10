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

namespace TradingApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
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
        private void GetGrid(string? str = null)
        {
            if(str == null)
            {

            }
        }

        private async void Update_Click(object sender, RoutedEventArgs e)
        {
            string[] companyes = { "AAPL", "GOOG", "KO", "MSFT", "AMZN", "FB", "005930.KS", "DIS", "TM", "MCD", "ATNI" };

            lable_AppleProcent.Content = lable_ApplePrice.Content = "";
            var securities = await Yahoo.Symbols(companyes[0]).Fields(Field.Symbol, Field.RegularMarketPrice, Field.RegularMarketChangePercent, Field.FiftyTwoWeekHigh).QueryAsync();
            var aapl = securities[companyes[0]];
            var price = aapl[Field.RegularMarketPrice];
            var procent = aapl[Field.RegularMarketChangePercent];
            lable_ApplePrice.Content = (Convert.ToString(price) + "$");
            lable_AppleProcent.Content = (Convert.ToString(procent) + "%");
            if (procent < 0)
            {
                lable_ApplePrice.Foreground = Brushes.Red;
                lable_AppleProcent.Foreground = Brushes.Red;
            }
            else
            {
                lable_ApplePrice.Foreground = Brushes.Green;
                lable_AppleProcent.Foreground = Brushes.Green;
            }
            lable_GoogleProcent.Content = lable_GooglePrice.Content = "";
            securities = await Yahoo.Symbols(companyes[1]).Fields(Field.Symbol, Field.RegularMarketPrice, Field.RegularMarketChangePercent, Field.FiftyTwoWeekHigh).QueryAsync();
            aapl = securities[companyes[1]];
            price = aapl[Field.RegularMarketPrice];
            procent = aapl[Field.RegularMarketChangePercent];
            lable_GooglePrice.Content = (Convert.ToString(price) + "$");
            lable_GoogleProcent.Content = (Convert.ToString(procent) + "%");
            if (procent < 0)
            {
                lable_GooglePrice.Foreground = Brushes.Red;
                lable_GoogleProcent.Foreground = Brushes.Red;
            }
            else
            {
                lable_GooglePrice.Foreground = Brushes.Green;
                lable_GoogleProcent.Foreground = Brushes.Green;
            }
            lable_ColaProcent.Content = lable_ColaPrice.Content = "";
            securities = await Yahoo.Symbols(companyes[2]).Fields(Field.Symbol, Field.RegularMarketPrice, Field.RegularMarketChangePercent, Field.FiftyTwoWeekHigh).QueryAsync();
            aapl = securities[companyes[2]];
            price = aapl[Field.RegularMarketPrice];
            procent = aapl[Field.RegularMarketChangePercent];
            lable_ColaPrice.Content = (Convert.ToString(price) + "$");
            lable_ColaProcent.Content = (Convert.ToString(procent) + "%");
            if (procent < 0)
            {
                lable_ColaPrice.Foreground = Brushes.Red;
                lable_ColaProcent.Foreground = Brushes.Red;
            }
            else
            {
                lable_ColaPrice.Foreground = Brushes.Green;
                lable_ColaProcent.Foreground = Brushes.Green;
            }
            microsoft_Price.Content = microsoft_Procent.Content = "";
            securities = await Yahoo.Symbols(companyes[3]).Fields(Field.Symbol, Field.RegularMarketPrice, Field.RegularMarketChangePercent, Field.FiftyTwoWeekHigh).QueryAsync();
            aapl = securities[companyes[3]];
            price = aapl[Field.RegularMarketPrice];
            procent = aapl[Field.RegularMarketChangePercent];
            microsoft_Price.Content = (Convert.ToString(price) + "$");
            microsoft_Procent.Content = (Convert.ToString(procent) + "%");
            if (procent < 0)
            {
                microsoft_Price.Foreground = Brushes.Red;
                microsoft_Procent.Foreground = Brushes.Red;
            }
            else
            {
                microsoft_Price.Foreground = Brushes.Green;
                microsoft_Procent.Foreground = Brushes.Green;
            }
            amazon_Price.Content = amazon_Procent.Content = "";
            securities = await Yahoo.Symbols(companyes[4]).Fields(Field.Symbol, Field.RegularMarketPrice, Field.RegularMarketChangePercent, Field.FiftyTwoWeekHigh).QueryAsync();
            aapl = securities[companyes[4]];
            price = aapl[Field.RegularMarketPrice];
            procent = aapl[Field.RegularMarketChangePercent];
            amazon_Price.Content = (Convert.ToString(price) + "$");
            amazon_Procent.Content = (Convert.ToString(procent) + "%");
            if (procent < 0)
            {
                amazon_Price.Foreground = Brushes.Red;
                amazon_Procent.Foreground = Brushes.Red;
            }
            else
            {
                amazon_Price.Foreground = Brushes.Green;
                amazon_Procent.Foreground = Brushes.Green;
            }
            microsoft_Price.Content = microsoft_Procent.Content = "";
            securities = await Yahoo.Symbols(companyes[3]).Fields(Field.Symbol, Field.RegularMarketPrice, Field.RegularMarketChangePercent, Field.FiftyTwoWeekHigh).QueryAsync();
            aapl = securities[companyes[3]];
            price = aapl[Field.RegularMarketPrice];
            procent = aapl[Field.RegularMarketChangePercent];
            microsoft_Price.Content = (Convert.ToString(price) + "$");
            microsoft_Procent.Content = (Convert.ToString(procent) + "%");
            if (procent < 0)
            {
                microsoft_Price.Foreground = Brushes.Red;
                microsoft_Procent.Foreground = Brushes.Red;
            }
            else
            {
                microsoft_Price.Foreground = Brushes.Green;
                microsoft_Procent.Foreground = Brushes.Green;
            }
            facebook_Price.Content = facebook_Procent.Content = "";
            securities = await Yahoo.Symbols(companyes[5]).Fields(Field.Symbol, Field.RegularMarketPrice, Field.RegularMarketChangePercent, Field.FiftyTwoWeekHigh).QueryAsync();
            aapl = securities[companyes[5]];
            price = aapl[Field.RegularMarketPrice];
            procent = aapl[Field.RegularMarketChangePercent];
            facebook_Price.Content = (Convert.ToString(price) + "$");
            facebook_Procent.Content = (Convert.ToString(procent) + "%");
            if (procent < 0)
            {
                facebook_Price.Foreground = Brushes.Red;
                facebook_Procent.Foreground = Brushes.Red;
            }
            else
            {
                facebook_Price.Foreground = Brushes.Green;
                facebook_Procent.Foreground = Brushes.Green;
            }
            samsung_Price.Content = samsung_Procent.Content = "";
            securities = await Yahoo.Symbols(companyes[6]).Fields(Field.Symbol, Field.RegularMarketPrice, Field.RegularMarketChangePercent, Field.FiftyTwoWeekHigh).QueryAsync();
            aapl = securities[companyes[6]];
            price = aapl[Field.RegularMarketPrice];
            procent = aapl[Field.RegularMarketChangePercent];
            samsung_Price.Content = (Convert.ToString(price) + "$");
            samsung_Procent.Content = (Convert.ToString(procent) + "%");
            if (procent < 0)
            {
                samsung_Price.Foreground = Brushes.Red;
                samsung_Procent.Foreground = Brushes.Red;
            }
            else
            {
                samsung_Price.Foreground = Brushes.Green;
                samsung_Procent.Foreground = Brushes.Green;
            }
            disney_Price.Content = disney_Procent.Content = "";
            securities = await Yahoo.Symbols(companyes[7]).Fields(Field.Symbol, Field.RegularMarketPrice, Field.RegularMarketChangePercent, Field.FiftyTwoWeekHigh).QueryAsync();
            aapl = securities[companyes[7]];
            price = aapl[Field.RegularMarketPrice];
            procent = aapl[Field.RegularMarketChangePercent];
            disney_Price.Content = (Convert.ToString(price) + "$");
            disney_Procent.Content = (Convert.ToString(procent) + "%");
            if (procent < 0)
            {
                disney_Price.Foreground = Brushes.Red;
                disney_Procent.Foreground = Brushes.Red;
            }
            else
            {
                disney_Price.Foreground = Brushes.Green;
                disney_Procent.Foreground = Brushes.Green;
            }
            toyota_Price.Content = toyota_Procent.Content = "";
            securities = await Yahoo.Symbols(companyes[8]).Fields(Field.Symbol, Field.RegularMarketPrice, Field.RegularMarketChangePercent, Field.FiftyTwoWeekHigh).QueryAsync();
            aapl = securities[companyes[8]];
            price = aapl[Field.RegularMarketPrice];
            procent = aapl[Field.RegularMarketChangePercent];
            toyota_Price.Content = (Convert.ToString(price) + "$");
            toyota_Procent.Content = (Convert.ToString(procent) + "%");
            if (procent < 0)
            {
                toyota_Price.Foreground = Brushes.Red;
                toyota_Procent.Foreground = Brushes.Red;
            }
            else
            {
                toyota_Price.Foreground = Brushes.Green;
                toyota_Procent.Foreground = Brushes.Green;
            }
            mcdonalds_Price.Content = mcdonalds_Procent.Content = "";
            securities = await Yahoo.Symbols(companyes[9]).Fields(Field.Symbol, Field.RegularMarketPrice, Field.RegularMarketChangePercent, Field.FiftyTwoWeekHigh).QueryAsync();
            aapl = securities[companyes[9]];
            price = aapl[Field.RegularMarketPrice];
            procent = aapl[Field.RegularMarketChangePercent];
            mcdonalds_Price.Content = (Convert.ToString(price) + "$");
            mcdonalds_Procent.Content = (Convert.ToString(procent) + "%");
            if (procent < 0)
            {
                mcdonalds_Price.Foreground = Brushes.Red;
                mcdonalds_Procent.Foreground = Brushes.Red;
            }
            else
            {
                mcdonalds_Price.Foreground = Brushes.Green;
                mcdonalds_Procent.Foreground = Brushes.Green;
            }
            atni_Price.Content = atni_Procent.Content = "";
            securities = await Yahoo.Symbols(companyes[10]).Fields(Field.Symbol, Field.RegularMarketPrice, Field.RegularMarketChangePercent, Field.FiftyTwoWeekHigh).QueryAsync();
            aapl = securities[companyes[10]];
            price = aapl[Field.RegularMarketPrice];
            procent = aapl[Field.RegularMarketChangePercent];
            atni_Price.Content = (Convert.ToString(price) + "$");
            atni_Procent.Content = (Convert.ToString(procent) + "%");
            if (procent < 0)
            {
                atni_Price.Foreground = Brushes.Red;
                atni_Procent.Foreground = Brushes.Red;
            }
            else
            {
                atni_Price.Foreground = Brushes.Green;
                atni_Procent.Foreground = Brushes.Green;
            }
        }

        private void Communication_Click(object sender, RoutedEventArgs e)
        {
            GetStocksMain stocks = new GetStocksMain();
            MessageBox.Show(stocks._Price_with_name.Keys.Count.ToString());
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
    }
}

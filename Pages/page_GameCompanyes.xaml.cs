using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using YahooFinanceApi;
namespace TradingApp.Pages
{
    /// <summary>
    /// Interaction logic for page_GameCompanyes.xaml
    /// </summary>
    public partial class page_GameCompanyes
    {
        public page_GameCompanyes()
        {
            InitializeComponent();
            Update_Click(null, null);
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.MainWindow = this;
            Application.Current.MainWindow.Height = 600;
            Application.Current.MainWindow.Width = 1000;
        }

        private async void Update_Click(object sender, RoutedEventArgs e)
        {
                string[] companyes = { "TCEHY", "SNE", "ATVI", "MSFT", "NTES", "EA", "NTDOY", "NCBDF", "UBI.PA", "TTWO" };

                lable_TencentProcent.Content = lable_TencentPrice.Content = "";
                var securities = await Yahoo.Symbols(companyes[0]).Fields(Field.Symbol, Field.RegularMarketPrice, Field.RegularMarketChangePercent, Field.FiftyTwoWeekHigh).QueryAsync();
                var company_inf = securities[companyes[0]];
                var price = company_inf[Field.RegularMarketPrice];
                var procent = company_inf[Field.RegularMarketChangePercent];
                lable_TencentPrice.Content = (Convert.ToString(price) + "$");
                lable_TencentProcent.Content = (Convert.ToString(procent) + "%");
                if (procent < 0)
                {
                    lable_TencentPrice.Foreground = Brushes.Red;
                    lable_TencentProcent.Foreground = Brushes.Red;
                }
                else
                {
                    lable_TencentPrice.Foreground = Brushes.Green;
                    lable_TencentProcent.Foreground = Brushes.Green;
                }
                lable_sonyProcent.Content = lable_sonyPrice.Content = "";
                securities = await Yahoo.Symbols(companyes[1]).Fields(Field.Symbol, Field.RegularMarketPrice, Field.RegularMarketChangePercent, Field.FiftyTwoWeekHigh).QueryAsync();
                company_inf = securities[companyes[1]];
                price = company_inf[Field.RegularMarketPrice];
                procent = company_inf[Field.RegularMarketChangePercent];
                lable_sonyPrice.Content = (Convert.ToString(price) + "$");
                lable_sonyProcent.Content = (Convert.ToString(procent) + "%");
                if (procent < 0)
                {
                    lable_sonyPrice.Foreground = Brushes.Red;
                    lable_sonyProcent.Foreground = Brushes.Red;
                }
                else
                {
                    lable_sonyPrice.Foreground = Brushes.Green;
                    lable_sonyProcent.Foreground = Brushes.Green;
                }
                lable_actblizProcent.Content = lable_actblizPrice.Content = "";
                securities = await Yahoo.Symbols(companyes[2]).Fields(Field.Symbol, Field.RegularMarketPrice, Field.RegularMarketChangePercent, Field.FiftyTwoWeekHigh).QueryAsync();
                company_inf = securities[companyes[2]];
                price = company_inf[Field.RegularMarketPrice];
                procent = company_inf[Field.RegularMarketChangePercent];
                lable_actblizPrice.Content = (Convert.ToString(price) + "$");
                lable_actblizProcent.Content = (Convert.ToString(procent) + "%");
                if (procent < 0)
                {
                    lable_actblizPrice.Foreground = Brushes.Red;
                    lable_actblizProcent.Foreground = Brushes.Red;
                }
                else
                {
                    lable_actblizPrice.Foreground = Brushes.Green;
                    lable_actblizProcent.Foreground = Brushes.Green;
                }
                label_microsoftProcent.Content = label_microsoftPrice.Content = "";
                securities = await Yahoo.Symbols(companyes[3]).Fields(Field.Symbol, Field.RegularMarketPrice, Field.RegularMarketChangePercent, Field.FiftyTwoWeekHigh).QueryAsync();
                company_inf = securities[companyes[3]];
                price = company_inf[Field.RegularMarketPrice];
                procent = company_inf[Field.RegularMarketChangePercent];
                label_microsoftPrice.Content = (Convert.ToString(price) + "$");
                label_microsoftProcent.Content = (Convert.ToString(procent) + "%");
                if (procent < 0)
                {
                    label_microsoftPrice.Foreground = Brushes.Red;
                    label_microsoftProcent.Foreground = Brushes.Red;
                }
                else
                {
                    label_microsoftPrice.Foreground = Brushes.Green;
                    label_microsoftProcent.Foreground = Brushes.Green;
                }
                label_microsoftProcent.Content = label_microsoftPrice.Content = "";
                securities = await Yahoo.Symbols(companyes[3]).Fields(Field.Symbol, Field.RegularMarketPrice, Field.RegularMarketChangePercent, Field.FiftyTwoWeekHigh).QueryAsync();
                company_inf = securities[companyes[3]];
                price = company_inf[Field.RegularMarketPrice];
                procent = company_inf[Field.RegularMarketChangePercent];
                label_microsoftPrice.Content = (Convert.ToString(price) + "$");
                label_microsoftProcent.Content = (Convert.ToString(procent) + "%");
                if (procent < 0)
                {
                    label_microsoftPrice.Foreground = Brushes.Red;
                    label_microsoftProcent.Foreground = Brushes.Red;
                }
                else
                {
                    label_microsoftPrice.Foreground = Brushes.Green;
                    label_microsoftProcent.Foreground = Brushes.Green;
                }
                label_NetEasePrice.Content = label_NetEasePrice.Content = "";
                securities = await Yahoo.Symbols(companyes[4]).Fields(Field.Symbol, Field.RegularMarketPrice, Field.RegularMarketChangePercent, Field.FiftyTwoWeekHigh).QueryAsync();
                company_inf = securities[companyes[4]];
                price = company_inf[Field.RegularMarketPrice];
                procent = company_inf[Field.RegularMarketChangePercent];
                label_NetEasePrice.Content = (Convert.ToString(price) + "$");
                label_NetEaseProcent.Content = (Convert.ToString(procent) + "%");
                if (procent < 0)
                {
                    label_NetEasePrice.Foreground = Brushes.Red;
                    label_NetEaseProcent.Foreground = Brushes.Red;
                }
                else
                {
                    label_NetEasePrice.Foreground = Brushes.Green;
                    label_NetEaseProcent.Foreground = Brushes.Green;
                }
                lable_eaProcent.Content = lable_eaPrice.Content = "";
                securities = await Yahoo.Symbols(companyes[5]).Fields(Field.Symbol, Field.RegularMarketPrice, Field.RegularMarketChangePercent, Field.FiftyTwoWeekHigh).QueryAsync();
                company_inf = securities[companyes[5]];
                price = company_inf[Field.RegularMarketPrice];
                procent = company_inf[Field.RegularMarketChangePercent];
                lable_eaPrice.Content = (Convert.ToString(price) + "$");
                lable_eaProcent.Content = (Convert.ToString(procent) + "%");
                if (procent < 0)
                {
                    lable_eaPrice.Foreground = Brushes.Red;
                    lable_eaProcent.Foreground = Brushes.Red;
                }
                else
                {
                    lable_eaPrice.Foreground = Brushes.Green;
                    lable_eaProcent.Foreground = Brushes.Green;
                }
                label_ntProcent.Content = label_ntPrice.Content = "";
                securities = await Yahoo.Symbols(companyes[6]).Fields(Field.Symbol, Field.RegularMarketPrice, Field.RegularMarketChangePercent, Field.FiftyTwoWeekHigh).QueryAsync();
                company_inf = securities[companyes[6]];
                price = company_inf[Field.RegularMarketPrice];
                procent = company_inf[Field.RegularMarketChangePercent];
                label_ntPrice.Content = (Convert.ToString(price) + "$");
                label_ntProcent.Content = (Convert.ToString(procent) + "%");
                if (procent < 0)
                {
                    label_ntPrice.Foreground = Brushes.Red;
                    label_ntProcent.Foreground = Brushes.Red;
                }
                else
                {
                    label_ntPrice.Foreground = Brushes.Green;
                    label_ntProcent.Foreground = Brushes.Green;
                }
                label_bandainProcent.Content = label_bandainPrice.Content = "";
                securities = await Yahoo.Symbols(companyes[7]).Fields(Field.Symbol, Field.RegularMarketPrice, Field.RegularMarketChangePercent, Field.FiftyTwoWeekHigh).QueryAsync();
                company_inf = securities[companyes[7]];
                price = company_inf[Field.RegularMarketPrice];
                procent = company_inf[Field.RegularMarketChangePercent];
                label_bandainPrice.Content = (Convert.ToString(price) + "$");
                label_bandainProcent.Content = (Convert.ToString(procent) + "%");
                if (procent < 0)
                {
                    label_bandainPrice.Foreground = Brushes.Red;
                    label_bandainProcent.Foreground = Brushes.Red;
                }
                else
                {
                    label_bandainPrice.Foreground = Brushes.Green;
                    label_bandainProcent.Foreground = Brushes.Green;
                }
                label_ubiProcent.Content = label_ubiPrice.Content = "";
                securities = await Yahoo.Symbols(companyes[8]).Fields(Field.Symbol, Field.RegularMarketPrice, Field.RegularMarketChangePercent, Field.FiftyTwoWeekHigh).QueryAsync();
                company_inf = securities[companyes[8]];
                price = company_inf[Field.RegularMarketPrice];
                procent = company_inf[Field.RegularMarketChangePercent];
                label_ubiPrice.Content = (Convert.ToString(price) + "$");
                label_ubiProcent.Content = (Convert.ToString(procent) + "%");
                if (procent < 0)
                {
                    label_ubiPrice.Foreground = Brushes.Red;
                    label_ubiProcent.Foreground = Brushes.Red;
                }
                else
                {
                    label_ubiPrice.Foreground = Brushes.Green;
                    label_ubiProcent.Foreground = Brushes.Green;
                }
                label_2kProcent.Content = label_2kPrice.Content = "";
                securities = await Yahoo.Symbols(companyes[9]).Fields(Field.Symbol, Field.RegularMarketPrice, Field.RegularMarketChangePercent, Field.FiftyTwoWeekHigh).QueryAsync();
                company_inf = securities[companyes[9]];
                price = company_inf[Field.RegularMarketPrice];
                procent = company_inf[Field.RegularMarketChangePercent];
                label_2kPrice.Content = (Convert.ToString(price) + "$");
                label_2kProcent.Content = (Convert.ToString(procent) + "%");
                if (procent < 0)
                {
                    label_2kPrice.Foreground = Brushes.Red;
                    label_2kProcent.Foreground = Brushes.Red;
                }
                else
                {
                    label_2kPrice.Foreground = Brushes.Green;
                    label_2kProcent.Foreground = Brushes.Green;
                }
        }

        private void UnShow_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Power_OFF_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
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

        private void Other_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}

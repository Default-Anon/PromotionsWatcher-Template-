using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using YahooFinanceApi;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace TradingApp
{
    class GetStocksMain
    {
        #region Stocks

        public Dictionary<string,string> _Price_with_name { get; set; }
        private List<string> _lstCompany { get; set; }
        public GetStocksMain()
        {
            string[] default_companyies = { "AAPL", "TSLA","GOOG" };
            _Price_with_name = new Dictionary<string, string>();
            _lstCompany = new List<string>();
            _lstCompany.AddRange(default_companyies);
            GetStocks(_lstCompany);
        }
        private async void GetStocks(List<string> _lst)
        {
            foreach (var company in _lst)
            {
                var securities = await Yahoo.Symbols(company).Fields(Field.Symbol, Field.RegularMarketPrice, Field.FiftyTwoWeekHigh).QueryAsync();
                var aapl = securities[company];
                var price = aapl[Field.RegularMarketPrice];
                _Price_with_name.Add(company, price.ToString());
            }
        }
        #endregion
    }
}

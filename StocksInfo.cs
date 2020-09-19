using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using YahooFinanceApi;
namespace TradingApp
{
    class StocksInfo : AutoExpanderGeneration
    {
        #region DataCompanyes
        public List<CompanyStruct> companyesSymbols { get; set; }
        public Dictionary<string, Tuple<double, double>> InformationCompany { get; set; }
        #endregion
        public StocksInfo(string genre_Stocks)
        {
            InformationCompany = new Dictionary<string, Tuple<double, double>>();
            switch (genre_Stocks)
            {
                case "Game":
                    //companyesSymbols =
                    //new List<string>(){"TCEHY", "SNE", "ATVI", "MSFT", "NTES", "EA", "NTDOY", "NCBDF", "UBI.PA", "TTWO" };
                    break;
                case "Other":
                    //companyesSymbols =
                    //new List<string>() { "GTX", "AAPL", "GOOG", "KO", "MSFT", "AMZN", "FB", "005930.KS", "DIS", "TM", "MCD", "ATNI" };
                    companyesSymbols =
                        new List<CompanyStruct>()
                        {
                            //new CompanyStruct("Garret","GTX","https://bemotors.com.pe/wp-content/uploads/2016/06/Garrett-logo.jpg"),
                            new CompanyStruct("Apple","AAPL","https://www.apple.com/ac/structured-data/images/knowledge_graph_logo.png"),
                            new CompanyStruct("Google","GOOG","https://pbs.twimg.com/profile_images/1045580248467886080/_uwwJdr3_400x400.jpg"),
                            new CompanyStruct("Cola","KO","https://www.coca-cola.com/content/dam/brands/tw/coca-cola/image/coke-logo.png"),
                            new CompanyStruct("Microsoft","MSFT","https://cdn.imgbin.com/16/19/8/imgbin-logo-microsoft-corporation-brand-windows-server-2016-windows-xp-intellect-j5EKTEzZXrj0MCRYKuTjcnXxK.jpg"),
                            new CompanyStruct("Amazon","AMZN","https://thumbs.dreamstime.com/b/amazon-logo-editorial-vector-illustration-market-136495269.jpg"),
                            new CompanyStruct("Facebook","FB","https://w7.pngwing.com/pngs/739/443/png-transparent-social-media-facebook-logo-computer-icons-facebook-icon-blue-internet-facebook-icon.png"),
                            new CompanyStruct("Samsung","005930.KS","https://mobcompany.info/wp-content/uploads/2016/10/logo-square-letter.png"),
                            new CompanyStruct("Disney","DIS","https://www.arabianbusiness.com/public/images/2017/01/16/disney_logo.jpg"),
                            new CompanyStruct("Toyota","TM","https://i2.wp.com/tvojauto.ru/wp-content/uploads/2014/04/toyota.jpg?ssl=1.jpg"),
                            new CompanyStruct("MacDonalds","MCD","https://c7.hotpng.com/preview/676/74/342/fast-food-mcdonald-s-logo-golden-arches-restaurant-mcdonalds.jpg"),
                            new CompanyStruct("ATN","ATNI","https://static2.seekingalpha.com/uploads/sa_presentations/380/40380/slides/1.jpg")
                        };
                    break;
                default:
                    companyesSymbols = new List<CompanyStruct>();
                    break;
            }

        }
        public async Task<(double,double)> GetData(string symbols)
        {
            var securities = await Yahoo.Symbols(symbols).Fields(Field.Symbol, Field.RegularMarketPrice, Field.RegularMarketChangePercent, Field.FiftyTwoWeekHigh).QueryAsync();
            var company = securities[symbols];
            var price = company[Field.RegularMarketPrice];
            var procent = company[Field.RegularMarketChangePercent];
            var name = symbols;
            InformationCompany.Add(symbols, ((double)price, (double)procent).ToTuple());
            return (price, procent);
        }
    }
}

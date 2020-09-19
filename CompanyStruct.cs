using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace TradingApp
{
    class CompanyStruct
    {
        public string CompanyName { get; set; }
        public string Symbols { get; set; }
        public string ImageUrl { get; set; }

        public readonly string CompanyNameCorp;

        public Label label_price { get; set; }

        public Label label_procent { get; set; }
        public CompanyStruct(string name,string symbols,string image_url)
        {
            CompanyName = name;
            Symbols = symbols;
            ImageUrl = image_url;
            CompanyNameCorp = name + "CORP";
            label_price = new Label();
            label_procent = new Label();
        }

    }
}

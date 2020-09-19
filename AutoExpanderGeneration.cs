using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace TradingApp
{
    class AutoExpanderGeneration
    {
        public Expander GetExpander(CompanyStruct obj)
        {
            var expander = new Expander();
            var grid = new Grid();
            grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(100) });
            grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(200) });
            grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(200) });
            grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(200) });
            grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1300) });
            grid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(20) });
            grid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(50) });
            grid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(5) });
            var image = new Image();
            BitmapImage img = new BitmapImage();
            img.BeginInit();
            img.UriSource = new Uri(obj.ImageUrl);
            img.EndInit();
            image.Source = img;
            image.Stretch = Stretch.Fill;
            image.HorizontalAlignment = HorizontalAlignment.Left;
            Grid.SetRowSpan(image, 3);
            Grid.SetColumn(image, 0);
            grid.Children.Add(image);
            var label_title = new Label();
            label_title.Content = obj.CompanyNameCorp;
            label_title.Foreground = Brushes.White;
            Grid.SetColumn(label_title, 1);
            Grid.SetRow(label_title, 1);
            label_title.FontSize = 23;
            label_title.HorizontalContentAlignment = HorizontalAlignment.Center;
            grid.Children.Add(label_title);
            Grid.SetColumn(obj.label_price, 2);
            Grid.SetRow(obj.label_price, 1);
            obj.label_price.HorizontalContentAlignment = HorizontalAlignment.Center;
            obj.label_price.Foreground = Brushes.Green;
            obj.label_price.Content = "0.00";
            obj.label_price.FontSize = 23;
            grid.Children.Add(obj.label_price);
            Grid.SetColumn(obj.label_procent, 3);
            Grid.SetRow(obj.label_procent, 1);
            obj.label_procent.HorizontalContentAlignment = HorizontalAlignment.Center;
            obj.label_procent.Foreground = Brushes.Green;
            obj.label_procent.Content = "0.00";
            obj.label_procent.FontSize = 23;
            grid.Children.Add(obj.label_procent);
            var first_grid = new Grid();
            Grid.SetColumnSpan(first_grid, 4);
            Grid.SetColumn(first_grid, 1);
            Grid.SetRow(first_grid, 0);
            first_grid.Background = Brushes.Gray;
            grid.Children.Add(first_grid);
            var second_grid = new Grid();
            Grid.SetColumnSpan(second_grid, 4);
            Grid.SetColumn(second_grid, 1);
            Grid.SetRow(second_grid, 3);
            second_grid.Background = Brushes.Gray;
            grid.Children.Add(second_grid);
            BulletDecorator bp = new BulletDecorator();
            expander.Content = obj.CompanyName;
            bp.Child = grid;
            expander.Header = bp;
            return expander;
        }
        public Label GetLabel(string content)
        {
            var label = new Label();
            label.Content = content;
            label.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
            label.Foreground = Brushes.White;
            label.FontSize = 22;
            return label;
        }
    }
}

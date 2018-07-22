using System;
using System.Collections.Generic;
using learnUWP16.ViewModels;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;
using WinRTXamlToolkit.Controls.DataVisualization.Charting;

namespace learnUWP16.Views
{
    public class SmartPhone
    {
        public string Name { get; set; }
        public int Amount { get; set; }

    }

    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel => DataContext as MainViewModel;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            LoadChartContents();
        }

        private void LoadChartContents()
        {
            var random = new Random();
            var listSource = new List<SmartPhone>();
            listSource.Add(new SmartPhone() { Name = "IPhone",  Amount = random.Next(0,100) });
            listSource.Add(new SmartPhone() { Name = "Android", Amount = random.Next(0, 100) });
            listSource.Add(new SmartPhone() { Name = "UWP",     Amount = random.Next(0, 100) });
            listSource.Add(new SmartPhone() { Name = "Other",   Amount = random.Next(0, 100) });
            (ColumnChart.Series[0] as ColumnSeries).ItemsSource = listSource;
            (PieChart.Series[0] as PieSeries).ItemsSource = listSource;
            (LineChart.Series[0] as LineSeries).ItemsSource = listSource;
            (BarChart.Series[0] as BarSeries).ItemsSource = listSource;
            (BubbleChart.Series[0] as BubbleSeries).ItemsSource = listSource;
        }
    }
}

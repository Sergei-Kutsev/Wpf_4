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

namespace Wpf_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calcDollar_Click(object sender, RoutedEventArgs e)
        {
            double RateDollar = Convert.ToDouble(rateDollar.Text);
            double SumDollar = Convert.ToDouble(sumDollar.Text);
            double ResultDollar = RateDollar * SumDollar;
            resultDollar.Text = ResultDollar.ToString();
        }

        private void calcEuro_Click(object sender, RoutedEventArgs e)
        {
            double RateEuro = Convert.ToDouble(rateEuro.Text);
            double SumEuro = Convert.ToDouble(sumEuro.Text);
            double ResultEuro = RateEuro * SumEuro;
            resultEuro.Text = ResultEuro.ToString();
        }

        private void calcGrivn_Click(object sender, RoutedEventArgs e)
        {
            double RateGrivn = Convert.ToDouble(rateGrivn.Text);
            double SumGrivn = Convert.ToDouble(sumGrivn.Text);
            double ResultGrivn = RateGrivn * SumGrivn;
            resultGrivn.Text = ResultGrivn.ToString();
        }

        private void calcPound_Click(object sender, RoutedEventArgs e)
        {
            double RatePound = Convert.ToDouble(ratePound.Text);
            double SumPound = Convert.ToDouble(sumPound.Text);
            double ResultPound = RatePound * SumPound;
            resultPound.Text = ResultPound.ToString();
        }

        private void inch_Click(object sender, RoutedEventArgs e)
        {
            double Inch = Convert.ToDouble(convertInch.Text);
            resultInch.Text = Convert.ToString(Inch * 0.0254);
        }

        private void foot_Click(object sender, RoutedEventArgs e)
        {
            double Foot = Convert.ToDouble(convertFoot.Text);
            resultFoot.Text = Convert.ToString(Foot * 0.3047992424196);
        }

        private void miles_Click(object sender, RoutedEventArgs e)
        {
            double Miles = Convert.ToDouble(convertMiles.Text);
            resultMiles.Text = Convert.ToString(Miles * 1609.34);
        }

        private void verst_Click(object sender, RoutedEventArgs e)
        {
            double Verst = Convert.ToDouble(convertVerst.Text);
            resultVerst.Text = Convert.ToString(Verst * 1066.8);
        }
    }
}

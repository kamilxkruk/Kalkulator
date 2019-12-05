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

namespace KalkulatorWPFX.View
{
    /// <summary>
    /// Interaction logic for CalculatorView.xaml
    /// </summary>
    public partial class CalculatorView : UserControl
    {
        public CalculatorView()
        {
            InitializeComponent();
        }

        private void Plus_OnClick(object sender, RoutedEventArgs e)
        {
                var userData = ConvertUserData();
                if (userData != null)
                {
                    ResultTextBlock.Text = userData.Sum().ToString();
                }
        }

        private void Minus_OnClick(object sender, RoutedEventArgs e)
        {
            var userData = ConvertUserData();
            if (userData != null)
            {
                ResultTextBlock.Text = (userData.X - userData.Y).ToString();
            }
        }

        private void Multiply_OnClick(object sender, RoutedEventArgs e)
        {
            var userData = ConvertUserData();
            if (userData != null)
            {
                ResultTextBlock.Text = (userData.X * userData.Y).ToString();
            }
        }

        private void Divide_OnClick(object sender, RoutedEventArgs e)
        {
            var userData = ConvertUserData();
            if (userData != null)
            {
                ResultTextBlock.Text = (userData.X / userData.Y).ToString();
            }
        }

        private CalculatorData ConvertUserData()
        {
            try
            {
                var x = Convert.ToInt32(XTextBox.Text);
                var y = Convert.ToInt32(YTextBox.Text);
                var userData = new CalculatorData();
                userData.X = x;
                userData.Y = y;
                return userData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd konwersji danych");
                return null;
            }
        }
    }

    class CalculatorData
    {
        public int X  { get; set; }
        public int Y { get; set; }

        public int Sum()
        {
            return X + Y;
        }
    }
}

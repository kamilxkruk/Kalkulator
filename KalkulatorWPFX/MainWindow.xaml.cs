using System.Windows;
using System.Windows.Controls;
using KalkulatorWPFX.View;

namespace KalkulatorWPFX
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private UserControl calculatorView;
        private UserControl homeView;
        private UserControl palindromView;

        public MainWindow()
        {
            InitializeComponent();
            calculatorView = new CalculatorView();
            homeView = new HomeView();
        }

        private void Home_OnClick(object sender, RoutedEventArgs e)
        {
            ContentPresenter.Content = homeView;
        }

        private void Calculator_OnClick(object sender, RoutedEventArgs e)
        {
            ContentPresenter.Content = calculatorView;
        }

    }
}

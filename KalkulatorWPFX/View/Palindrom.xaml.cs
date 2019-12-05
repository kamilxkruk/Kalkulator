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
    /// Interaction logic for Palindrom.xaml
    /// </summary>
    public partial class Palindrom : UserControl
    {
        public Palindrom()
        {
            InitializeComponent();
        }

        private bool CzyPalindrom(string tekst)
        {
            return tekst == new string(tekst.ToCharArray().Reverse().ToArray());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBlock.Text = CzyPalindrom(TextBox.Text).ToString();
        }
    }
}

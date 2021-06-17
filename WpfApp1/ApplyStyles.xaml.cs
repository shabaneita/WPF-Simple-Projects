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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for ApplyStyles.xaml
    /// </summary>
    public partial class ApplyStyles : Window
    {
        public ApplyStyles()
        {
            InitializeComponent();
        }

        private void click1(object sender, RoutedEventArgs e)
        {
            //bestCode 
            //Firststyle
            button4.Style = (Style)Resources["btn1style"];
            button5.Style = (Style)Resources["btn1style"];
            button6.Style = (Style)Resources["btn1style"];

        }

        private void click2(object sender, RoutedEventArgs e)
        {
            //Secondstyle

            button4.Style = (Style)Resources["btn2style"];
            button5.Style = (Style)Resources["btn2style"];
            button6.Style = (Style)Resources["btn2style"];
        }

        private void click3(object sender, RoutedEventArgs e)
        {

            //Thirdstyle

            button4.Style = (Style)Resources["btn3style"];
            button5.Style = (Style)Resources["btn3style"];
            button6.Style = (Style)Resources["btn3style"];

        }
    }
}

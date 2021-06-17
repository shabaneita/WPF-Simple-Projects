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
    /// Interaction logic for TextBox.xaml
    /// </summary>
    public partial class TextBox : Window
    {
        public TextBox()
        {
            InitializeComponent();
        }

        private void setBtn(object sender, RoutedEventArgs e)
        {
            txt1.Text = "This is the initial Text";
        }

        private void selectBtn(object sender, RoutedEventArgs e)
        {
            txt1.SelectAll();

        }

        private void clearBtn(object sender, RoutedEventArgs e)
        {
            txt1.Text = string.Empty;
        }

        private void appendBtn(object sender, RoutedEventArgs e)
        {
            txt1.AppendText("< ***appended text ***>");

        }
        private void prependBtn(object sender, RoutedEventArgs e)
        {
            
                txt1.Text = txt1.Text.Insert(0, "<***Prepend***>");
            

        }

        private void insertBtn(object sender, RoutedEventArgs e)
        {
            txt1.Text = txt1.Text.Insert(txt1.CaretIndex, "<new text>");
        }

     

        private void cutBtn(object sender, RoutedEventArgs e)
        {
            txt1.Cut();
        }

        private void pasteBtn(object sender, RoutedEventArgs e)
        {
            txt1.Paste();
        }

        private void copyBtn(object sender, RoutedEventArgs e)
        {
            txt1.Copy();

        }

        private void undoBtn(object sender, RoutedEventArgs e)
        {
            txt1.Undo();
        }
        private void ReadOnly(object sender, RoutedEventArgs e)
        {
            txt1.IsReadOnly = true;
            MessageBox.Show("TextBox is Readonly Now");
        }

        private void Ediatable(object sender, RoutedEventArgs e)
        {
            txt1.IsReadOnly = false;
            MessageBox.Show("TextBox is Ediatable Now");
        }

        private void Left(object sender, RoutedEventArgs e)
        {
            txt1.TextAlignment = TextAlignment.Left;
        }

        private void Center(object sender, RoutedEventArgs e)
        {

            txt1.TextAlignment = TextAlignment.Center;
        }

        private void Right(object sender, RoutedEventArgs e)
        {
            txt1.TextAlignment = TextAlignment.Right;

        }

       
    }
}

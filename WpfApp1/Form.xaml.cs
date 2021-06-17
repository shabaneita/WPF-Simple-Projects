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
    /// Interaction logic for Form.xaml
    /// </summary>
    public partial class Form : Window
    {
        public Form()
        {
            InitializeComponent();
        }

        private void okHandeler(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Hello");
            MessageBoxResult r = MessageBox.Show($"FirstName={txt1.Text}\n LastName={txt2.Text} \n Gender={txt3.Text} \n Adress={txt4.Text} \n Phone={txt5.Text} \n Mobile={txt6.Text} \n Email={txt7.Text} \n Job Title={txt8.Text} ", " Error", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            switch (r)
            {
                case MessageBoxResult.OK:
                    MessageBox.Show("Saved");
                    break;
                case MessageBoxResult.Cancel:

                    //foreach(UIElement element in stc.Children)
                    //{
                    //    if (element.GetType()==typeof(TextBox))
                    //    {
                    //        TextBox textBox = (TextBox)element;
                    //        textBox.txt1 = null;
                    //    }
                    //}
                    txt1.Text = txt2.Text = txt3.Text = txt4.Text = txt5.Text = txt6.Text = txt7.Text = txt8.Text = "";

                    break;
            }
        }

        private void cancelHandeler(object sender, RoutedEventArgs e)
        {
          
            txt1.Text=txt2.Text = txt3.Text = txt4.Text = txt5.Text = txt6.Text = txt7.Text = txt8.Text ="";
           
        }
    }
}

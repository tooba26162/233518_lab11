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

namespace activity_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void HandleCheck(object sender, RoutedEventArgs e)
        {
            if (sender == checkBox1)
            {
                textBox1.Text = "CheckBox1 is checked";
            }
            else if (sender == checkBox2)
            {
                textBox2.Text = "CheckBox2 is checked";
            }
        }
        private void HandleUnChecked(object sender, RoutedEventArgs e)
        {
            if (sender == checkBox1)
            {
                textBox1.Text = "CheckBox1 is unchecked";
            }
            else if (sender == checkBox2)
            {
                textBox2.Text = "CheckBox2 is unchecked";
            }
        }

        private void HandleThirdState(object sender, RoutedEventArgs e)
        {
            if (sender == checkBox2)
            {
                textBox2.Text = "CheckBox2 is in indeterminate state";
            }
        }
    }
}

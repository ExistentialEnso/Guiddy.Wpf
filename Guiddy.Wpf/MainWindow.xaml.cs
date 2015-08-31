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

namespace Guiddy.Wpf
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

        private void generateButton_Click(object sender, RoutedEventArgs e)
        {
            var guid = Guid.NewGuid().ToString();

            if (!checkBoxHyphens.IsChecked.GetValueOrDefault(true))
            {
                guid = guid.Replace("-", "");
            }

            guid = (checkBoxUppercase.IsChecked.GetValueOrDefault(true))
                ? guid.ToUpperInvariant()
                : guid.ToLowerInvariant();

            outputTextBox.Text = guid;
            outputTextBox.Focus();
            outputTextBox.SelectAll();

            if (checkBoxClipboard.IsChecked.GetValueOrDefault(true))
            {
                outputTextBox.Copy();
            }
        }
    }
}

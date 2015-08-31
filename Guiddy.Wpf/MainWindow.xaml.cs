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
            var guid = GuidGenerator.Generate(checkBoxHyphens.IsChecked.GetValueOrDefault(true),
                checkBoxUppercase.IsChecked.GetValueOrDefault(true));

            outputTextBox.Text = guid;
            outputTextBox.Focus();
            outputTextBox.SelectAll();

            // Do automatic clipboard copy if setting enabled
            if (checkBoxClipboard.IsChecked.GetValueOrDefault(true))
            {
                outputTextBox.Copy();
            }
        }
    }
}

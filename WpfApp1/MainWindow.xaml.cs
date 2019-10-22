using System.Linq;
using System.Windows;
using System.Windows.Controls;
using static WpfApp1.WindowHelpers;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
        /// <summary>
        /// Disable all TextBox controls in StackPanel1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StackPanel1.EnableTextBoxes<StackPanel>(true);
        }
        /// <summary>
        /// Clear all TextBox controls in StackPanel2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            StackPanel2.ClearTextBoxes<StackPanel>();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FindChildren<StackPanel>(this).ToList()
                .ForEach(sp => sp.ClearTextBoxes<StackPanel>());
        }
    }
}

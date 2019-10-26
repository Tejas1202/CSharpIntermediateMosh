using System.Windows;
using System.Windows.Controls;

namespace WPFApp
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender; //sender. doesn't gives us the properties/methods of button. So we downcasted it
            //Here as we know that it's a button click event, hence it's safe to downcast. But in other cases, use 'as' or 'is' keywords first

            var buttonOne = sender as Button;
            if (buttonOne != null)
            {
                MessageBox.Show(button.ActualHeight.ToString());
            }

            if (sender is Button)
            {
                var buttonTwo = (Button)sender;
                MessageBox.Show(buttonTwo.ActualWidth.ToString());
            }


            MessageBox.Show("Hello World");
        }
    }
}

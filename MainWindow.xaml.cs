using AXNotification.Tools;
using System.Windows;


namespace AXNotification
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

        private void ToastButtonClick(object sender, RoutedEventArgs e)
        {
            var timer = Tools.Timer.Build();
            timer.Start();
        }

    }
}
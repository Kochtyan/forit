using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;


namespace Planner.Views
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
# endif

        }
        private void closeButton_Click(object sender, RoutedEventArgs e) =>
            Close();


        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}

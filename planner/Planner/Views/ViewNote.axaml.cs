using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;

namespace Planner.Views
{
    public partial class ViewNote : Window
    {
        public ViewNote()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }
        private void closeButton_Click(object sender, RoutedEventArgs e) =>
            Close();

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}

using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System;



namespace Planner.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            var datep = this.FindControl<DatePicker>("datepicker1");
            var today = DateTime.Today;
            datep.SelectedDate = today;

        }
        private void openNewNote(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }

        private void openNote(object sender, RoutedEventArgs e)
        {
            ViewNote window1 = new ViewNote();
            window1.Show();
        }

    }
}

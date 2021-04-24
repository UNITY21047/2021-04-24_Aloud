using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace _2021_04_24_Aloud
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
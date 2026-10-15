using System.IO;
using Avalonia.Controls;
using Avalonia.Media.Imaging;

namespace Controls.Views;

public partial class ImagesWindow : Window {
    public ImagesWindow() {
        InitializeComponent();

        LoadImage(StackPanel1, "../../../Assets/img-2.png");
    }

    private static void LoadImage(StackPanel stackPanel, string path) {
        if (!File.Exists(path)) return;

        var image = new Image();
        var bmp = new Bitmap(path);

        image.Source = bmp;
        image.Width = 100;

        stackPanel.Children.Add(image);
    }
}
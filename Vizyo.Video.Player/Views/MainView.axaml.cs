using Avalonia.Controls;
using Avalonia.Media;

namespace Vizyo.Video.Player.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();

        //var player1 = new MpvPlayerView() { Width = 300, Height = 200, Background = Brush.Parse("#000000"), Source = "http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4" };
        //Canvas.SetLeft(player1, 10); Canvas.SetTop(player1, 10);
        //MainCanvas.Children.Add(player1);

        var player2 = new VlcPlayerView() { Width = 300, Height = 200, Source = "http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/ElephantsDream.mp4" };
        Canvas.SetLeft(player2, 400); Canvas.SetTop(player2, 10);
        MainCanvas.Children.Add(player2);

        //var player2 = new PlayerView() { Width = 300, Height = 200, Source = "http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/ElephantsDream.mp4" };
        //Canvas.SetLeft(player2, 400); Canvas.SetTop(player2, 10);
        //MainCanvas.Children.Add(player2);

        //var player3 = new PlayerView() { Width = 300, Height = 200, Source = "https://test-videos.co.uk/vids/bigbuckbunny/mp4/av1/360/Big_Buck_Bunny_360_10s_1MB.mp4" };
        //Canvas.SetLeft(player3, 100); Canvas.SetTop(player3, 300);
        //MainCanvas.Children.Add(player3);

        //MainCanvas.Children.Add(new PlayerView() { Width = 300, Height = 200, Source = "http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4" });
        //MainCanvas.Children.Add(new PlayerView() { Width = 300, Height = 200, Source = "http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/ElephantsDream.mp4" });
        //MainCanvas.Children.Add(new PlayerView() { Width = 300, Height = 200, Background=Brush.Parse("#000000"), Source = "https://test-videos.co.uk/vids/bigbuckbunny/mp4/av1/360/Big_Buck_Bunny_360_10s_1MB.mp4" });
        //MainCanvas.Children.Add(new PlayerView() { Width = 300, Height = 200, Source = "stock-video.mp4" });
    }
}
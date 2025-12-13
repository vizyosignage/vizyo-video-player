using System;
using System.Diagnostics;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using LibMPVSharp;
using LibMPVSharp.Avalonia;

namespace Vizyo.Video.Player;

public partial class PlayerView : UserControl, IDisposable
{
    public MPVMediaPlayer? Player { get; set; } = new();
    public string Source { get; set; } = string.Empty;

    public PlayerView()
    {
        InitializeComponent();

        Debug.WriteLine("VideoPlayer InitializeComponent");

        MediaView.MediaPlayer = Player;

        //PlayButton.Click += (sender, e) => TryOpenFile();

        this.Loaded += (_, _) =>
        {
            TryOpenFile();
        };
    }

    private async void TryOpenFile()
    {
        if (MediaView.MediaPlayer == null) return;

        MediaView.MediaPlayer.EnsureRenderContextCreated();

        //MediaView.MediaPlayer.ExecuteCommand(new[] { "set", "mute", "yes" }); // sessiz

        //string uriString = "http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4"; //"https://test-videos.co.uk/vids/bigbuckbunny/mp4/av1/360/Big_Buck_Bunny_360_10s_1MB.mp4";
        await MediaView.MediaPlayer.ExecuteCommandAsync([MPVMediaPlayer.PlaylistManipulationCommands.Loadfile, Source, "append-play"]);

        //MediaView.MediaPlayer.ExecuteCommand(new[] { "set", "loop", "inf" });

        //SetCurrentValue(PlayingProperty, true);
    }

    private void Playlist()
    {
        // Listeye medya ekleme, append-play - sıranın sonuna ekler ve oynatma bitince sıradaki medyaya geçilir.
        Player?.ExecuteCommand(new[] { "loadfile", "video1.mp4", "append-play" });
        Player?.ExecuteCommand(new[] { "loadfile", "video2.mp4", "append-play" });
        Player?.ExecuteCommand(new[] { "loadfile", "video3.mp4", "append-play" });

        Player?.ExecuteCommand(new[] { "playlist-clear" });

        //mpv.Command("set", "playlist-pos", "0"); // ilk dosya
        //mpv.Command("set", "playlist-pos", "1"); // ikinci dosya

        Player?.ExecuteCommand(new[] { "set", "playlist-loop", "inf" });
        Player?.ExecuteCommand(new[] { "set", "loop", "inf" });

    }

    protected override void OnAttachedToVisualTree(VisualTreeAttachmentEventArgs e)
    {
        if (Player != null)
        {
            Debug.WriteLine("VideoPlayer OnAttachedToVisualTree");

            //MediaView.MediaPlayer = Player;

            //Player?.ExecuteCommand(new[] { "set", "vo", "gpu" });
            //Player?.ExecuteCommand(new[] { "set", "gpu-context", "android" });
            //Player?.ExecuteCommand(new[] { "set", "opengl-es", "yes" });
            //Player?.ExecuteCommand(new[] { "set", "hwdec", "no" });
            //Player?.ExecuteCommand(new[] { "set", "gpu-sw", "no" });

            //Player?.ExecuteCommand(new[] { "loadfile", Source, "append-play" });
            //Player?.ExecuteCommand(new[] { "loadfile", Source });
            //Player?.ExecuteCommand(new[] { "loadfile", "http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4", "append-play" });

            //Player?.ExecuteCommand(new[] { "set", "mute", "yes" }); // ses kapat
            ////Player?.ExecuteCommand(new[] { "set", "mute", "no" }); // ses aç
            ////Player?.ExecuteCommand(new[] { "set", "volume", "0" }); // ses ayarı

            //Player?.ExecuteCommand(new[] { "set", "playlist-loop", "inf" });
            //Player?.ExecuteCommand(new[] { "set", "loop", "inf" });

            //Player?.StartPlayback(Source);

            ////Player?.StartPlayback(Path.Join(AppContext.BaseDirectory, "stock-video.mp4"));
            ////Player?.StartPlayback("http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/ElephantsDream.mp4");

            //Player.EnsureRenderContextCreated();

            //TryOpenFile();
        }

        base.OnAttachedToVisualTree(e);
    }

    protected override void OnDetachedFromVisualTree(VisualTreeAttachmentEventArgs e)
    {
        base.OnDetachedFromVisualTree(e);
        Dispose();
    }

    protected bool disposed = false;
    protected virtual void Dispose(bool disposing)
    {
        if (!this.disposed && disposing)
        {
            //Player?.ExecuteCommand(new[] {"stop"});
            Player?.Dispose();
            Player = null;
            Debug.WriteLine("VideoPlayer Dispose");
        }

        this.disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
        GC.Collect();
    }
}
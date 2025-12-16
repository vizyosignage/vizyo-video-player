using System;
using System.Diagnostics;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using LibVLCSharp.Shared;
using Vizyo.Video.Player.Views;

namespace Vizyo.Video.Player;

public partial class VlcPlayerView : UserControl, IDisposable
{
    public MediaPlayer Player { get; }
    public string Source { get; set; } = string.Empty;

    public VlcPlayerView()
    {
        InitializeComponent();

        Debug.WriteLine("VlcVideoPlayer InitializeComponent");

        Player = new MediaPlayer(App.Instance._libVlc);
        MediaView.MediaPlayer = Player;

        this.Loaded += (_, _) =>
        {
            Play();
        };
    }
    public void Play()
    {
        //using var media = new Media(App.Instance._libVlc, new Uri("http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4"));
        using var media = new Media(App.Instance._libVlc, new Uri(Source));
        Player.Play(media);
    }


    protected override void OnAttachedToVisualTree(VisualTreeAttachmentEventArgs e)
    {
        if (Player != null)
        {
            Debug.WriteLine("VlcVideoPlayer OnAttachedToVisualTree");

            
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
            Player?.Dispose();
            Debug.WriteLine("VlcVideoPlayer Dispose");
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
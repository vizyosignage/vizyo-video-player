using System;
using System.Diagnostics;
using Avalonia.Controls;
using LibVLCSharp.Shared;

namespace Vizyo.Video.Player.Views;

public partial class MainWindow : Window, IDisposable
{
    public MainWindow()
    {
        InitializeComponent();
    }

    protected bool disposed = false;
    protected virtual void Dispose(bool disposing)
    {
        if (!this.disposed && disposing)
        {
            App.Instance._libVlc?.Dispose();
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
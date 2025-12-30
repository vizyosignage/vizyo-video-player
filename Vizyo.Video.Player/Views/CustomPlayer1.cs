using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Media;

namespace Vizyo.Video.Player.Views
{
    public class CustomPlayer1(int width, int height)
    {
        public Grid GetPlayer(string source)
        {
            var player = new MpvPlayerView() { Width = width, Height = height , Source = source };

            var topBar = new Border
            {
                Background = Brush.Parse("#ffffff"),
                Height = 30,
                VerticalAlignment = Avalonia.Layout.VerticalAlignment.Top,
                Opacity = 0.7,
                Child = new TextBlock
                {
                    Text = "Video Player",
                    Foreground = Brushes.Black,
                    HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center,
                    VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center,
                    FontSize = 14
                }
            };

            var footerBar = new Border
            {
                Background = Brush.Parse("#000000"),
                Height = 30,
                VerticalAlignment = Avalonia.Layout.VerticalAlignment.Bottom,
                Opacity = 0.7,
                Child = new TextBlock
                {
                    Text = "Video Player",
                    Foreground = Brushes.White,
                    HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center,
                    VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center,
                    FontSize = 14
                }
            };

            var grid = new Grid()
            {
                Width = width,
                Height = height,
            };

            grid.Children.Add(player);
            grid.Children.Add(topBar);
            grid.Children.Add(footerBar);

            return grid;
        }
    }
}

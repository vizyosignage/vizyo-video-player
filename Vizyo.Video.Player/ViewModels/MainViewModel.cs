using CommunityToolkit.Mvvm.ComponentModel;

namespace Vizyo.Video.Player.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _greeting = "Welcome to Avalonia!";
}

using Microsoft.UI.Xaml.Controls;

using WinUI3TestRunInVSCode.ViewModels;

namespace WinUI3TestRunInVSCode.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}

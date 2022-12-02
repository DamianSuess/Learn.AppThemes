using Prism.Commands;
using Prism.Navigation;
using Sample.AppThemes.Views;
using Xamarin.Essentials;

namespace Sample.AppThemes.ViewModels
{
  public class MainViewModel : ViewModelBase
  {
    public MainViewModel(INavigationService navigationService)
      : base(navigationService)
    {
      Title = "Main Page";
    }

    public DelegateCommand CmdSubPage => new DelegateCommand(async () =>
    {
      await NavigationService.NavigateAsync(nameof(MainView));
    });

    public DelegateCommand CmdThemedPage => new DelegateCommand(async () =>
    {
      await NavigationService.NavigateAsync(nameof(ThemedView));
    });

    public string AppName => AppInfo.Name;

    public string AppPackageName => AppInfo.PackageName;

    public string AppTheme => AppInfo.RequestedTheme.ToString();
  }
}

using Prism.Commands;
using Prism.Navigation;
using Sample.AppThemes.Views;
using Xamarin.Essentials;

namespace Sample.AppThemes.ViewModels
{
  public class ThemedViewModel : ViewModelBase
  {
    public ThemedViewModel(INavigationService navigationService)
      : base(navigationService)
    {
      Title = "Themed Page";
    }

    public string AppName => AppInfo.Name;

    public string AppPackageName => AppInfo.PackageName;

    public string AppTheme => AppInfo.RequestedTheme.ToString();
  }
}

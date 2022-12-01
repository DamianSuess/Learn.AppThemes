using Prism.Navigation;
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

    public string AppName => AppInfo.Name;

    public string AppPackageName => AppInfo.PackageName;

    public string AppTheme => AppInfo.RequestedTheme.ToString();
  }
}

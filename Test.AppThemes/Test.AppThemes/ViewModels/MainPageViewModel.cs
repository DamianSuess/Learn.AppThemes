/* Copyright Xeno Innovations, Inc. 2020
 * Date:    2020-1-15
 * Author:  Damian Suess
 * File:    MainPageViewModel.cs
 * Description:
 *
 */

using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;
using Test.AppThemes.Views;

namespace Test.AppThemes.ViewModels
{
  public class DashboardViewModel : ViewModelBase
  {
    public DashboardViewModel(INavigationService navigationService)
      : base(navigationService)
    {
      Title = "Main Page";
    }

    public DelegateCommand CmdShowSettings => new DelegateCommand(OnShowSettings);

    public async void OnShowSettings()
    {
      await NavigationService.NavigateAsync(nameof(SettingsView));
    }
  }
}

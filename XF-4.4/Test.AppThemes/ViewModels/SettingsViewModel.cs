/* Copyright Xeno Innovations, Inc. 2020
 * Date:    2020-1-15
 * Author:  Damian Suess
 * File:    SettingsViewModel.cs
 * Description:
 *
 */

using Prism.Navigation;

namespace Test.AppThemes.ViewModels
{
  public class SettingsViewModel : ViewModelBase
  {
    public SettingsViewModel(INavigationService navigationService)
      : base(navigationService)
    {
    }
  }
}

/* Copyright Xeno Innovations, Inc. 2020
 * Date:    2020-1-15
 * Author:  Damian Suess
 * File:    MasterDetailViewModel.cs
 * Description:
 *
 */

using Prism.Mvvm;
using Prism.Navigation;

namespace Test.AppThemes.ViewModels
{
  public class MasterDetailViewModel : ViewModelBase
  {
    public MasterDetailViewModel(INavigationService navigationService)
      : base(navigationService)
    {
    }
  }
}

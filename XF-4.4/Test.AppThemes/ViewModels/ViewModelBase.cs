/* Copyright Xeno Innovations, Inc. 2020
 * Date:    2020-1-15
 * Author:  Damian Suess
 * File:    ViewModelBase.cs
 * Description:
 *
 */

using Prism.Mvvm;
using Prism.Navigation;

namespace Test.AppThemes.ViewModels
{
  public class ViewModelBase : BindableBase, IInitialize, INavigationAware, IDestructible
  {
    private string _title;

    public ViewModelBase(INavigationService navigationService)
    {
      NavigationService = navigationService;
    }

    public string Title
    {
      get { return _title; }
      set { SetProperty(ref _title, value); }
    }

    protected INavigationService NavigationService { get; private set; }

    public virtual void Initialize(INavigationParameters parameters)
    {
    }

    public virtual void OnNavigatedFrom(INavigationParameters parameters)
    {
    }

    public virtual void OnNavigatedTo(INavigationParameters parameters)
    {
    }

    public virtual void Destroy()
    {
    }
  }
}

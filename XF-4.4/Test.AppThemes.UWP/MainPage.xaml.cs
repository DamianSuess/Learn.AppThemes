/* Copyright Xeno Innovations, Inc. 2020
 * Date:    2020-1-15
 * Author:  Damian Suess
 * File:    MainPage.xaml.cs
 * Description:
 *
 */

using Prism;
using Prism.Ioc;

namespace Test.AppThemes.UWP
{
  public sealed partial class MainPage
  {
    public MainPage()
    {
      this.InitializeComponent();

      LoadApplication(new Test.AppThemes.App(new UwpInitializer()));
    }
  }

  public class UwpInitializer : IPlatformInitializer
  {
    public void RegisterTypes(IContainerRegistry containerRegistry)
    {
      // Register any platform specific implementations
    }
  }
}

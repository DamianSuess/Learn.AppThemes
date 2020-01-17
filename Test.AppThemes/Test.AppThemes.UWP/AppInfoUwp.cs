/* Copyright Xeno Innovations, Inc. 2020
 * Date:    2020-1-15
 * Author:  Damian Suess
 * File:    AppInfoUwp.cs
 * Description:
 *  Application information UWP
 *
 *  Using this namespace on purpose so when the time comes, we can just remove it.
 *  Currently, only Xamarin.Essentials is at v1.3, not v1.4+
 */

using Test.AppThemesShared;
using Windows.UI.Xaml;

namespace Xamarin.Essentials
{
  public static partial class AppInfo
  {
    private static AppTheme PlatformRequestedTheme() =>
      Application.Current.RequestedTheme == ApplicationTheme.Dark ? AppTheme.Dark : AppTheme.Light;
  }
}

/* Copyright Xeno Innovations, Inc. 2020
 * Date:    2020-1-15
 * Author:  Damian Suess
 * File:    Main.cs
 * Description:
 *
 */

using UIKit;

namespace Test.AppThemes.iOS
{
  public class Application
  {
    // This is the main entry point of the application.
    private static void Main(string[] args)
    {
      // if you want to use a different Application Delegate class from "AppDelegate"
      // you can specify it here.
      UIApplication.Main(args, null, "AppDelegate");
    }
  }
}

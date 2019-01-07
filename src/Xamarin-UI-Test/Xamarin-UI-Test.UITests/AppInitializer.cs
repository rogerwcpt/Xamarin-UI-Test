using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Xamarin_UI_Test.UITests
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp.Android.StartApp();
            }

            var exePath = "/Users/rogerweiss/Projects/Github.Personal/Xamarin-UI-Test/src/Xamarin-UI-Test/Xamarin-UI-Test.iOS/bin/iPhoneSimulator/Debug/Xamarin_UI_Test.iOS.exe";
            return ConfigureApp.iOS.AppBundle(exePath).DeviceIdentifier("C6BE5D23-A662-45C5-9F74-36B0028BCDE9").StartApp();
            //return ConfigureApp.iOS.StartApp();
        }
    }
}
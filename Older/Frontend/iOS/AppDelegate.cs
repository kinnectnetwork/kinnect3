using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace kinnect.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            UINavigationBar.Appearance.BarTintColor = UIColor.FromRGB(red: 69, green: 113, blue: 134);
            UINavigationBar.Appearance.TintColor = UIColor.White;

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}

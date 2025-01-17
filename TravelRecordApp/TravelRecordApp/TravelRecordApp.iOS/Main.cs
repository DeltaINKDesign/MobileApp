﻿using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace TravelRecordApp.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args) =>
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");
        [Register("AppDelegate")]
        public partial class AppDelegate : UIApplicationDelegate
        {
            public override UIWindow Window
            {
                get;
                set;
            }

        }
    }
}
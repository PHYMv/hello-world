using System;
using Xamarin.UITest;
using System.Linq;
using System.Runtime;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Text;
using NUnit.Framework;
using Xamarin.UITest.Utils;

namespace Freshdirect_iPhone
{
	//Initialize the application on Simulator/Device
	public class AppInitializer
	{
		public static string appPath = Config.appPath;
		public static IApp StartApp ()
		{
			//Launch the application on Simulator/Device
			if(Config.RunOn.Contains("Simulator")){
				return ConfigureApp.iOS.AppBundle(appPath).EnableLocalScreenshots().StartApp();
			}else{
				return ConfigureApp.iOS.InstalledApp(appPath).EnableLocalScreenshots().StartApp();
			}
		}
	}
}



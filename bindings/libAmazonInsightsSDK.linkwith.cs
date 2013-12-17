using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libAmazonInsightsSDK.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, ForceLoad = true, Frameworks = "CoreTelephony CoreLocation SystemConfiguration")]

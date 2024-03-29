﻿using Android.App;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Xamarin.Forms;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("App3.Android")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("App3.Android")]
[assembly: AssemblyCopyright("Copyright ©  2014")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

// Add some common permissions, these can be removed if not needed
[assembly: UsesPermission(Android.Manifest.Permission.Internet)]
[assembly: UsesPermission(Android.Manifest.Permission.WriteExternalStorage)]

//Fonts Family Add
[assembly: ExportFont("Quicksand-SemiBold.ttf", Alias = "QuicksandSB")]
[assembly: ExportFont("Quicksand-Bold.ttf", Alias = "QuicksandBold")]
[assembly: ExportFont("Quicksand-Light.ttf", Alias = "QuicksandLight")]
[assembly: ExportFont("Quicksand-Medium.ttf", Alias = "QuicksandMedium")]
[assembly: ExportFont("Quicksand-Regular.ttf", Alias = "QuicksandRegular")]
﻿using System.Reflection;
using System.Text;
using Android.App;
using Android.OS;
using Xamarin.Android.NUnitLite;

namespace Tests.Droid
{
    [Activity(Label = "Tests.Droid", MainLauncher = true)]
    public class MainActivity : TestSuiteActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            var r = new Virgil.Crypto.Pfs.VirgilPFS();
            var p = new Virgil.Crypto.Pythia.VirgilPythia();

            // tests can be inside the main assembly
            AddTest(Assembly.GetExecutingAssembly());
            // or in any reference assemblies
            // AddTest (typeof (Your.Library.TestClass).Assembly);

            // Once you called base.OnCreate(), you cannot add more assemblies.
          
            base.OnCreate(bundle);
        }
    }
}

using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms;
using XamSQLiteRelationships.Providers.Colors;

namespace XamSQLiteRelationships.Droid
{
    [Activity(Label = "circle", Icon = "@drawable/logo", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);
            Rg.Plugins.Popup.Popup.Init(this, bundle);
            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
           
            Window.SetStatusBarColor(Android.Graphics.Color.Rgb(Colors.TBBRColor, Colors.TBBGColor, Colors.TBBBColor));
            //            Window.SetStatusBarColor(Android.Graphics.Color.Rgb(208, 138, 138));  #14ACC3

        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using XamSQLiteRelationships.Droid.Providers;
using XamSQLiteRelationships.Providers.ToastNotifier;

[assembly: Dependency(typeof(ToastNotifier))]
namespace XamSQLiteRelationships.Droid.Providers
{
    public class ToastNotifier : IToastNotifier
    {
        public Task<bool> Notify(string title, string description, TimeSpan duration, object context = null, bool showOnTop = true)
        {
            var taskCompletionSource = new TaskCompletionSource<bool>();
            var toast = Toast.MakeText(Forms.Context, description, ToastLength.Short);
            if (showOnTop)
                toast.SetGravity(GravityFlags.Top, 0, 0);
            toast.Show();
            return taskCompletionSource.Task;
        }

        public void HideAll()
        {
            throw new NotImplementedException();
        }
    }
}
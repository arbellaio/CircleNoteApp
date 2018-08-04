using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamSQLiteRelationships.Providers.ToastNotifier;

namespace XamSQLiteRelationships.StringExtensions
{
    public static partial class StringExtension
    {
        public static void ToToast(this string message, string title = null, bool showOnTop = false)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                var toaster = DependencyService.Get<IToastNotifier>();
                toaster?.Notify(title, message, TimeSpan.FromMilliseconds(300), showOnTop: showOnTop);
            });
        }
    }
}

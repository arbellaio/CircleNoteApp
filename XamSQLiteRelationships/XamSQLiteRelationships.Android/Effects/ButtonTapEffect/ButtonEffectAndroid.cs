using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamSQLiteRelationships.Droid.Effects.ButtonTapEffect;
using XamSQLiteRelationships.Effects.ButtonHoverTapEffect;
using Button = Android.Widget.Button;
[assembly: ExportEffect(typeof(ButtonEffectAndroid), "ButtonEffect")]
namespace XamSQLiteRelationships.Droid.Effects.ButtonTapEffect
{
    public class ButtonEffectAndroid : PlatformEffect
    {
        protected override void OnAttached()
        {
            try
            {
                var control = Control as Button;
                var buttonEffect = (ButtonEffect)Element.Effects.FirstOrDefault(x => x is ButtonEffect);
                if (buttonEffect != null)
                {
                    if (control != null) control.Elevation = 80f;
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                
            }
            
        }

        protected override void OnDetached()
        {
            throw new NotImplementedException();
        }
    }
}
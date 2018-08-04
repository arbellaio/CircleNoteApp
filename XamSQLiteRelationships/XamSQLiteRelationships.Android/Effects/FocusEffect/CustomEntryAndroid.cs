using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using XamSQLiteRelationships.Droid.Effects.FocusEffect;
using XamSQLiteRelationships.Effects.EntryFocusEffect;
using Color = Android.Graphics.Color;
[assembly:ResolutionGroupName("XamSQLiteRelationships")]
[assembly:ExportEffect(typeof(CustomEntryAndroid),"CustomEntry")]
namespace XamSQLiteRelationships.Droid.Effects.FocusEffect
{
    public class CustomEntryAndroid : PlatformEffect
    {

        protected override void OnAttached()
        {
                             
            try
            {
                var control = Control as EditText;
                var entryEffect = (CustomEntry)Element.Effects.FirstOrDefault(x => x is CustomEntry);

                if (entryEffect != null)
                {
                    var gradientDrawable = new GradientDrawable();                                                          
                    gradientDrawable.SetCornerRadius(entryEffect.BorderRadius);
                    gradientDrawable.SetColor(entryEffect.BackgroundColor.ToAndroid());
                    gradientDrawable.SetStroke(entryEffect.BorderStroke, entryEffect.BorderColor.ToAndroid());


                    if (control != null)
                    {
                        control.Elevation = 20f;
                        control.SetBackground(gradientDrawable);
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot set property an attached control. Errors: " , e.Message);                
            }
        }


        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);

            var control = Control as EditText;
            var entryEffect = (CustomEntry)Element.Effects.FirstOrDefault(x => x is CustomEntry);

            if (entryEffect != null)
            {
                var gradientDrawable = new GradientDrawable();
                gradientDrawable.SetCornerRadius(entryEffect.BorderRadius);
                gradientDrawable.SetColor(entryEffect.BackgroundColor.ToAndroid());

                try
                {
                    if (control != null && control.HasFocus)
                    {
                        gradientDrawable.SetStroke(entryEffect.OnFocusBorderStroke, entryEffect.OnFocusBorderColor.ToAndroid());
                        control.SetBackground(gradientDrawable);

                    }
                    else
                    {
                        if (control != null && control.HasFocus == false)
                        {
                            control.SetPadding(20, 10, 0, 0);
                            gradientDrawable.SetStroke(entryEffect.BorderStroke, entryEffect.BorderColor.ToAndroid());
                            control.SetBackground(gradientDrawable);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);                    
                }
              

            }


        }
        

        protected override void OnDetached()
        {
            throw new NotImplementedException();
        }
        // control.SetShadowLayer(radius,distanceX,distanceY,color);


    }
}
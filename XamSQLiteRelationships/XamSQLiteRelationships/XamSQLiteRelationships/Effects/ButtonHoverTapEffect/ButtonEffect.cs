using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamSQLiteRelationships.Effects.ButtonHoverTapEffect
{
    public class ButtonEffect : RoutingEffect
    {
        public ButtonEffect() : base("XamSQLiteRelationships.ButtonEffect")
        {

        }
        public float ShadowEffect { get; set; }
        public float BorderRadius { get; set; }
        public float DistanceX { get; set; }
        public float DistanceY { get; set; }
        public Color BackgroundColor { get; set; }
        public int BorderStroke { get; set; }
        public Color BorderColor { get; set; }
        public Color OnFocusBorderColor { get; set; }
        public int OnFocusBorderStroke { get; set; }
        public int Opacity { get; set; }
    }
}

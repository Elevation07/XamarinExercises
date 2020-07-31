using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinExercise1;
using XamarinExercise1.Droid;


#pragma warning disable CS0612 // Type or member is obsolete
[assembly: ExportRenderer(typeof(MyButton), typeof(MyButtonRenderer))]
#pragma warning restore CS0612 // Type or member is obsolete


namespace XamarinExercise1.Droid
{
    [Obsolete]
    public class MyButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);
            var button = this.Control;
            button.SetAllCaps(false);
        }
        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
        }
    }
}
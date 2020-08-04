using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


[assembly: ResolutionGroupName("Xamarin")]
[assembly: ExportEffect(typeof(Effects.Droid.ButtonEffect), nameof(Effects.Droid.ButtonEffect))]
namespace Effects.Droid
{
    public class ButtonEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            try
            {
                var control = Control as Android.Widget.Button;
                control.SetAllCaps(false);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
            }
        }

        protected override void OnDetached()
        {
        }

        protected override void OnElementPropertyChanged(System.ComponentModel.PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);
        }
    }
}
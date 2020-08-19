using System;
using System.Runtime.Remoting.Contexts;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinExercise1;
using XamarinExercise1.Droid.CustomRenderers;

#pragma warning disable CS0612 // Type or member is obsolete
[assembly: ExportRenderer(typeof(EntryNew),typeof(CustomRoundedEntryRenderer))]
#pragma warning restore CS0612 // Type or member is obsolete
namespace XamarinExercise1.Droid.CustomRenderers
{
    [Obsolete]
    public class CustomRoundedEntryRenderer : EntryRenderer
    {
        
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.Background = this.Resources.GetDrawable(Resource.Drawable.RoundedEntry);
            }
        }

    }

}
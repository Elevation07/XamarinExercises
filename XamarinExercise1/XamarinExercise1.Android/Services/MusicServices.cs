using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using Android.App;
using Android.Content;
using Android.Media;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XamarinExercise1.Droid.Services;
using XamarinExercise1.Services;

[assembly: Xamarin.Forms.Dependency(typeof(MusicServices))]
namespace XamarinExercise1.Droid.Services
{
    public class MusicServices : ISound
    {
        public MusicServices() { }

        private MediaPlayer _mediaPlayer;
        public void PlayMp3File(string fileName)
        {
            
            _mediaPlayer = MediaPlayer.Create(Application.Context, Resource.Drawable.Music);
            _mediaPlayer.Start();


        }
    }
}
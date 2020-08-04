using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Media;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XamarinExercise1.Services;

namespace XamarinExercise1.Droid.Services
{
    public class MusicServices : ISound
    {
        public MusicServices() { }

        private MediaPlayer _mediaPlayer;
        public void PlayMp3File(string fileName)
        {
            throw new NotImplementedException();
            _mediaPlayer = MediaPlayer.Create(Application.Context, Resource.Drawable.Music);
            _mediaPlayer.Prepare();
            _mediaPlayer.Start();


        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinExercise1.Services;

namespace XamarinExercise1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

   
    public partial class DependencyAudio : ContentPage
    {

        bool audioClickButton = false;
        public DependencyAudio()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
           
            if(audioClickButton != true)
            {

                DependencyService.Get<ISound>().PlayMp3File("Music.mp3");
                buttonPlay.Text = "PAUSE";
                audioClickButton = true;

            }
            else
            {              
                        
                DependencyService.Get<ISound>().PauseMp3File("Music.mp3");
                buttonPlay.Text = "PLAY";
                audioClickButton = false;

            }

        }

     
    }
}
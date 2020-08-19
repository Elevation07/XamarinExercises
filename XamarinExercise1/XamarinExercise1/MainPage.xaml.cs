using System;
using System.ComponentModel;
using Xamarin.Forms;
using XamarinExercise1.ViewModel;
using XamarinExercise1.Views;

namespace XamarinExercise1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

      
        public MainPage()

        {
            InitializeComponent();

          
        }



       void Button_Clicked(object sender, EventArgs e)
        {
            switch(int.Parse((sender as Button).StyleId))
            {
                case 0:
                    Navigation.PushAsync(new StacklayoutBasicPage());
                    break;

                case 1:
                    Navigation.PushAsync(new LayoutOptions());
                    break;

                case 2:
                    Navigation.PushAsync(new StackLayoutSample());
                    break;

                case 3:
                    Navigation.PushAsync(new Grid());
                    break;

                case 4:
                    Navigation.PushAsync(new ProfilePage());
                    break;

                case 5:
                    Navigation.PushAsync(new SecondPage());
                    break;

                case 6:
                    Navigation.PushAsync(new TelephoneBehaviorPage());
                    break;

                case 7:
                    Navigation.PushAsync(new DependencyAudio());
                    break;

                case 8:
                    Navigation.PushAsync(new VerticalListPage());
                    break;

                case 9:
                    Navigation.PushAsync(new SignUpPage());
                    break;



            }

        }

   
    }
}

using System;
using Xamarin.Forms;
using XamarinExercise1.ViewModel;

namespace XamarinExercise1.Views
{
    public partial class VerticalListPage : ContentPage
    {
        public VerticalListPage()
        {
          
            InitializeComponent();
            BindingContext = new MonkeysViewModel();
        }

      
    }
}

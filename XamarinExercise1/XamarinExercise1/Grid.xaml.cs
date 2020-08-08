using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinExercise1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Grid : ContentPage
    {
        static int ButtonCount = 0;
        public Grid()
        {
            InitializeComponent();
           
        }
        

private void Button_Clicked(object sender, EventArgs e)
        {
           
             
                if (ButtonCount < 1)
                {
                    
                   
                labelText.Text = "Xamarin.Forms is an open source cross-platform framework from Microsoft for building iOS, Android, & Windows apps with .NET from a single shared codebase.";
                ButtonCount++;
                 }
                else
                {
               
                labelText.Text = "I am a Xamarin Developer";
                ButtonCount = 0;

                 }
               



        }
    }
}
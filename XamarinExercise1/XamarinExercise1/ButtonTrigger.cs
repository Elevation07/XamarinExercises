using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinExercise1
{
    public class ButtonTrigger : TriggerAction<MyButton>
    {

        bool clickButton;
        protected override void Invoke(MyButton button)
        {
            if (clickButton)
            {
                clickButton = false;
                button.Text = "Edit";
                button.StyleId = "0";
            }
            else
            {
                clickButton = true;
                button.Text = "Done";
                button.StyleId = "1";
            }


        }
    }
}

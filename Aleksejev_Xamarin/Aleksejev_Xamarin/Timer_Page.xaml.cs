using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aleksejev_Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Timer_Page : ContentPage
    {
        public Timer_Page()
        {
            Button Backbtn = new Button
            {
                Text = "Back",
                BackgroundColor = Color.Fuchsia,
                TextColor = Color.Black,
            };
            Backbtn.Clicked += Backbtn_Clicked;

            Content = new StackLayout
           {
                Children = { Backbtn }
            };
        }

        private async void NaitaAeg()
        {
            while (onoff)
            {
                lbl.Text = DateTime.Now.ToString("T");
                await Task.Delay(1000);
            }
            
        }
        bool onoff;
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            NaitaAeg();
        }
        private async void Backbtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        private void onoff_btn_Clicked(object sender, EventArgs e)
        {
            if (onoff)
            {
                onoff = false;
                onoff_btn.Text = "Lülita sisse";
            }
            else
            {
                onoff = true;
                onoff_btn.Text = "Lülita valja";

            }
        }

    }
}
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
        Button Backbtn;
        public Timer_Page()
        {
            InitializeComponent();
            Button Backbtn = new Button
            {
                Text = "Back",
                BackgroundColor = Color.Fuchsia,
                TextColor = Color.Black,
            };
            Backbtn.Clicked += Backbtn_Clicked;
            Stopbtn.Clicked += Stopbtn_Clicked;

            Content = new StackLayout { Children = { Backbtn, lbl, Stopbtn } };
        }
        bool onoff = false;

        private void Stopbtn_Clicked(object sender, EventArgs e)
        {
            if (onoff)
            {
                onoff = false;
                Stopbtn.Text = "Lülita sisse";
            }
            else
            {
                onoff = true;
                Stopbtn.Text = "Lülita välja";
            }

        }

        private async void Backbtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void NaitaAeg()
        {
            while (onoff)
            {
                lbl.Text = DateTime.Now.ToString("T");
                await Task.Delay(1000);
            }

        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            NaitaAeg();
        }
    }
}
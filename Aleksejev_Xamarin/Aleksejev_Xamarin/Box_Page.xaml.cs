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
    public partial class Box_Page : ContentPage
    {
        BoxView box;
        public Box_Page()
        {
            box = new BoxView()
            {
                Color = Color.Chocolate,
                CornerRadius = 10,
                WidthRequest = 20,
                HeightRequest = 30,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
            };
            TapGestureRecognizer tap=new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            box.GestureRecognizers.Add(tap);
            Content = box;
            

            Button Backbtn = new Button
            {
                Text = "Back",
                BackgroundColor = Color.Fuchsia,
                TextColor = Color.Black,
            };
            
            Backbtn.Clicked += Backbtn_Clicked;

           
        }

        Random rnd;
        int x = 10;
        private void Tap_Tapped(object sender, EventArgs e)
        {
            rnd = new Random();
            box.Color= Color.FromRgb(rnd.Next(0,255), rnd.Next(0,255), rnd.Next(0,255));
            x += 10;
            box.WidthRequest = box.Width + 5;
            box.HeightRequest= box.Height + 7;
            box.Rotation += 10;
        }
        private async void Backbtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
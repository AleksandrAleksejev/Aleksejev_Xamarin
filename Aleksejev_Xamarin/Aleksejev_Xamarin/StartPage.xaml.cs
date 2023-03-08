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
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            Button Textbtn = new Button
            {
                Text= "Text Page",
                BackgroundColor= Color.Fuchsia,
                TextColor= Color.Black,
            };
            
            Button Timerbtn = new Button
            {
                Text = "Timer",
                BackgroundColor= Color.Fuchsia,
            };
            Button Boxbtn = new Button
            {
                Text = "Box",
                BackgroundColor = Color.Fuchsia,
            };
            StackLayout st = new StackLayout
            {
                Orientation= StackOrientation.Vertical,
                BackgroundColor = Color.Beige,
                Children= {Textbtn, Timerbtn, Boxbtn}
            };
            st.BackgroundColor= Color.Aqua;
            Content= st;
            Textbtn.Clicked += Textbtn_Clicked;
            Timerbtn.Clicked += Timerbtn_Clicked;
            Boxbtn.Clicked += Boxbtn_Clicked;


        }


        private async void Textbtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Text_Page());
        }
        private async void Timerbtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Timer_Page());
        }
        private async void Boxbtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Box_Page());
        }
    }
}
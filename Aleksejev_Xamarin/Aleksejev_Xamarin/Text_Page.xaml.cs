using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace Aleksejev_Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Text_Page : ContentPage
    {

        Editor editor;
        Label lbl;
        Button Backbtn;
        public Text_Page()
        {
            Button Backbtn = new Button
            {
                Text = "Back",
                BackgroundColor = Color.Fuchsia,
                TextColor = Color.Black,
            };
            Backbtn.Clicked += Backbtn_Clicked;
            Editor editor = new Editor()
            {
                Placeholder = "Kirjuta text",
                BackgroundColor = Color.Red,
                PlaceholderColor = Color.BlueViolet,
                TextColor = Color.Brown,

            };

            editor.TextChanged += Editor_TextChanged;

            lbl = new Label
            {
                Text = "Siia tuled ka text",
                BackgroundColor = Color.Red,
                TextColor = Color.Brown,


        };

            Content = new StackLayout
            {
                Children = { lbl ,editor, Backbtn, }
            };
        }
        private async void Backbtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        int i;
        private async void Editor_TextChanged(object sender, TextChangedEventArgs e)
        {
            lbl.Text=editor.Text;
            char key = e.NewTextValue?.LastOrDefault() ?? ' ';
            if(key == 'A' || key == 'a')
            {
                i++;
                Backbtn.Text = key.ToString() + ": " + i.ToString();
            }
            await Navigation.PopAsync();
        }
    }
}
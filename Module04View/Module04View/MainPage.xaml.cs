using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Module04View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public async void Open_textcell(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TextCell());
        }
        public async void Open_imagecell(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ImageCell());
        }
        public async void Open_switchcell(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SwitchCell());
        }
        public async void Open_entrycell(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EntryCell());
        }
        public void DisplayAlert(Object sender, EventArgs e)
        {
            DisplayAlert("Alertttt", "This is an Alert", "OK");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module04View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryCell : ContentPage
    {
        public EntryCell()
        {
            InitializeComponent();
        }
        void OnSubmitEntry(object sender, EventArgs e)
        {
            string entry1Text = Title.Text;
            string entry2Text = Description.Text;
            string entry3Text = email.Text;
            DisplayAlert("Enter Values", $"Title: {entry1Text}\nDescription: {entry2Text}\nEmail: {entry3Text}\n are you sure you want to submit?", "Ok", "Cancel");
        }
    }
}
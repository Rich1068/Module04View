using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module04View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageCell : ContentPage
    {
        ObservableCollection<Example> examples = new ObservableCollection<Example>();
        public ObservableCollection<Example> Examples { get { return examples; } }
        public ImageCell()
        {
            InitializeComponent();

            ExampleView.ItemsSource = examples;

            examples.Add(new Example { Title = "Example 1", Description = "Description 1", Image = "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/83240012-8303-4d4b-abac-4176896a795d/dgkr9w8-df64af14-e6a1-4d55-a467-39a2577c6403.png?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcLzgzMjQwMDEyLTgzMDMtNGQ0Yi1hYmFjLTQxNzY4OTZhNzk1ZFwvZGdrcjl3OC1kZjY0YWYxNC1lNmExLTRkNTUtYTQ2Ny0zOWEyNTc3YzY0MDMucG5nIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.Yyd9mvUlSM_1eajXcIEolFltYbijAuiDtDqkQcwP_Qg" });
            examples.Add(new Example { Title = "Example 2", Description = "Description 2", Image = "" });
            examples.Add(new Example { Title = "Example 3", Description = "Description 3", Image = "" });
            examples.Add(new Example { Title = "Example 4", Description = "Description 4", Image = "" });
            examples.Add(new Example { Title = "Example 5", Description = "Description 5", Image = "" });
        }
    }
}
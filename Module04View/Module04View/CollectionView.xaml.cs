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
	public partial class CollectionView : ContentPage
	{
        ObservableCollection<Example> examples = new ObservableCollection<Example>();
        public ObservableCollection<Example> Examples { get { return examples; } }
        public CollectionView ()
		{
			InitializeComponent ();

            ExampleView.ItemsSource = examples;

            examples.Add(new Example { Title = "Example 1", Description = "Description 1", Image = "https://64.media.tumblr.com/15c6297baeb5f0c32a790c85283c7881/78b263366d7c367c-c6/s1280x1920/73d5c784586714f68f77de1f2073282f05562702.png" });
            examples.Add(new Example { Title = "Example 2", Description = "Description 2", Image = "https://static.wikia.nocookie.net/houkai-star-rail/images/c/c7/Jing_Yuan_Sticker_02.png/revision/latest?cb=20230420194038" });
            examples.Add(new Example { Title = "Example 3", Description = "Description 3", Image = "https://64.media.tumblr.com/1ac4e3703c2011cec19e8113223e4fb9/78b263366d7c367c-45/s1280x1920/9b13a37406db015b4f7f0ed63a32adb9e617d2a1.png" });
            examples.Add(new Example { Title = "Example 4", Description = "Description 4", Image = "https://64.media.tumblr.com/775c6e14d485eaf7509406c1595d864f/78b263366d7c367c-ef/s1280x1920/f5bb6df943143e347a2f5cb70c6d2822728c43e4.png" });
            examples.Add(new Example { Title = "Example 5", Description = "Description 5", Image = "https://64.media.tumblr.com/3bdfc7471d7f23ad4ecb1aee89751915/78b263366d7c367c-90/s1280x1920/a57e62ff54d4766f28e70590165f63678f5b14d8.png" });
        }
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aisle.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{

        private readonly List<string> _names = new List<string>
        {
            "hulu","lulu","bholu","Jhulu","chullu","mulu"
        };

		public HomePage ()
		{
			InitializeComponent ();

            Item.ItemsSource = _names;
		}

        private void ItemSearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            string keyword = ItemSearchBar.Text;

           IEnumerable<string> searchResult = _names.Where(name => name.Contains(keyword));

            Item.ItemsSource = searchResult;

        }
    }
}
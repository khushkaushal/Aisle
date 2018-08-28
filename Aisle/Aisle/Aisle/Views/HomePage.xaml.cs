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

        public HomePage()
        {
            InitializeComponent();

            Item newItems = new Item();

            BindingContext = newItems.makeList();


        }

        void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            String keyword = sBar.Text;

            Item item = new Item();
            BindingContext = item.searchItem(keyword);
            
        }
    }
}
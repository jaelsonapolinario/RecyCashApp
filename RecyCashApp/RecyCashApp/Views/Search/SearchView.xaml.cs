using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecyCashApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RecyCashApp.Views.Search
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchView : ContentPage
    {
        private SearchViewModel _viewModel;
        public SearchView()
        {
            InitializeComponent();
            BindingContext = _viewModel = new SearchViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _ = _viewModel.LoadSearchItems();
        }
    }
}
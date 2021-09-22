using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RecyCashApp.Models;
using RestSharp;

namespace RecyCashApp.ViewModels
{
    public class SearchViewModel : BaseViewModel
    {
        private ObservableCollection<SearchItemModel> _itemSource;

        public ObservableCollection<SearchItemModel> ItemSource
        {
            get => _itemSource;
            set
            {
                _itemSource = value;
                OnPropertyChanged();
            }
        }

        public async Task LoadSearchItems()
        {
            try
            {
                var request = new RestRequest("?key=9LNB-BSRC-4GKW-T8K6&ref=6ac1wzgc", Method.GET);
                var client = new RestClient("https://randomapi.com/api/");

                var response = await client.ExecuteAsync<string>(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var obResponse = JsonConvert.DeserializeObject<ApiResponseModel>(response.Data);
                    var searchs = obResponse?.Results?.FirstOrDefault();
                    if (searchs != null)
                    {
                        var items = new ObservableCollection<SearchItemModel>();
                        foreach (var searchItem in searchs.Searchs)
                        {
                            items.Add(searchItem);
                        }
                        ItemSource = items;
                    }
                }
                else
                {
                    Debug.WriteLine("ERRO - " + response.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("ERRO - " + ex.ToString());
            }
        }
    }
}
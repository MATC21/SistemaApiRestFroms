using Newtonsoft.Json;
using SistemaApiRestFroms.ModelView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SistemaApiRestFroms
{
    public partial class MainPage : ContentPage
    {
        APIs api = new APIs();
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<ModelPost> _post;
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            string content = await client.GetStringAsync(api.UrlPost);
            List<ModelPost> posts = JsonConvert.DeserializeObject<List<ModelPost>>(content);
            _post = new ObservableCollection<ModelPost>(posts);
            MiListaview.ItemsSource = _post;
            base.OnAppearing();
        }
    }
}

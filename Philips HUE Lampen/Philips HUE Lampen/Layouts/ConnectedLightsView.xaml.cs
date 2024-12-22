using System.Windows.Input;
using Windows.Security.EnterpriseData;

namespace Philips_HUE_Lampen {
    public partial class ConnectedLamps : ContentPage {
        public List<HueLight> lightsobjects;
        public bool IsRefresh { get; set; }


        public ConnectedLamps() {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            APIConnection.InitializeList();
            lightsobjects = APIConnection.LampList;
            listView.ItemsSource = APIConnection.LampList;
            base.OnAppearing();
        }

        public ICommand RefreshCommand => new Command(async () =>
        {
            IsRefresh = true;
            APIConnection.InitializeList();
            listView.ItemsSource = APIConnection.LampList;
            IsRefresh = false;
        });

        private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e) {
            Navigation.PushAsync(new DetailView((HueLight)listView.SelectedItem));
        }
    }

}

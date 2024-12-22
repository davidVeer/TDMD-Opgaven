namespace Philips_HUE_Lampen {
    public partial class ConnectedLamps : ContentPage {
        List<HueLight> lightsobjects;

        public ConnectedLamps() {
            InitializeComponent();
            lightsobjects = APIConnection.LampList;
            listView.ItemsSource = lightsobjects;
        }

        private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e) {
            Navigation.PushAsync(new DetailView());
        }
    }

}

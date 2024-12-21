namespace Philips_HUE_Lampen
{
    public partial class ConnectedLamps : ContentPage
    {
        List<Lightsobject> lightsobjects;

        public ConnectedLamps()
        {
            InitializeComponent();
            lightsobjects = APIConnection.LampList;
            listView.ItemsSource = lightsobjects;
        }

    }

}

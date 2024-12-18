namespace Philips_HUE_Lampen
{
    public partial class ConnectedLamps : ContentPage
    {
        public ConnectedLamps()
        {
            InitializeComponent();

            var lamps = new List<Lamp>
            {
                new Lamp {id = "1"},
                new Lamp {id = "2"},
                new Lamp {id = "3"},
                new Lamp {id = "4"},
                new Lamp {id = "5"},
                new Lamp {id = "6"}
            };

            listView.ItemsSource = APIConnection.list;
        }

    }

}

namespace Philips_HUE_Lampen;

public partial class DetailView : ContentPage {
    HueLight hueLight;
    public DetailView(HueLight input) {
        InitializeComponent();

        hueLight = input;
        nameLabel.Text = hueLight.name;
        
    }

    private void UpdateLampButton_Clicked(object sender, EventArgs e)
    {

        string sat = SatEntry.Text;
        if (sat != null)
        {
            if (int.Parse(sat) > 254)
                sat = "254";
        } else
        {
            sat = hueLight.state.sat.ToString();
        }

        string bri = BriEntry.Text;
        if (bri != null)
        {
            if (int.Parse(bri) > 254)
                bri = "254";
        }
        else
        {
            bri = hueLight.state.bri.ToString();
        }

        string hue = HueEntry.Text;
        if (hue != null)
        {
            if (int.Parse(hue) > 65535)
                hue = "65535";
        }
        else
        {
            hue = hueLight.state.hue.ToString();
        }

        string message = @"{'on':" + hueLight.state.on + ", 'sat':" + sat + ", 'bri':" + bri + ", 'hue':" + hue + "}";


        API_Requests.SendHTTPRequestPut(Char.ToString(hueLight.name.Last()), message);
        Navigation.PushAsync(new ConnectedLamps());
    }

    private void PowerButton_Clicked(Object sender, EventArgs e)
    {
        string message = @"{'on':" + !hueLight.state.on + "}";
        
        API_Requests.SendHTTPRequestPut(Char.ToString(hueLight.name.Last()) ,message);
        Navigation.PushAsync(new ConnectedLamps());
    }
}
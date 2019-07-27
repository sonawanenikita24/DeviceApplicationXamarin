//--------------------------------------------------------------------------------------------------------------------
// <copyright file="CheckNetwork.cs" company="BridgeLabz">
// copyright @2019 
// </copyright>
// <creater name="Nikita Sonawane"/>
//------------------------------------------------------------------------------------------------------------------
namespace DeviceApplication.View
{
    using Xamarin.Essentials;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;    

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CheckNetwork : ContentPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckNetwork"/> class.
        /// </summary>
        public CheckNetwork()
        {
            InitializeComponent();

            var current = Connectivity.NetworkAccess;
            var profile = Connectivity.ConnectionProfiles;
            ////var profiles = Connectivity.ConnectionProfiles;
            if (current == NetworkAccess.Internet)
            {
                lblNetworkStatus.Text = "Network is available";
            }
            else
            {
                lblNetworkStatus.Text = "Network is not available";
            }

            if (profile.Equals(ConnectionProfile.WiFi))
            {
                lblNetworkProfile.Text = profile.ToString();
            }
            else
            {
                lblNetworkProfile.Text = profile.ToString();
            }
        }
    }
}
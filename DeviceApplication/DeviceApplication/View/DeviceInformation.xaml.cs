//--------------------------------------------------------------------------------------------------------------------
// <copyright file="DeviceInformation.cs" company="BridgeLabz">
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
	public partial class DeviceInformation : ContentPage
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceInformation"/> class.
        /// </summary>
        public DeviceInformation()
		{
            
			InitializeComponent();

            lblDevName.Text = "Device Name :" + DeviceInfo.Name;
            lblDevType.Text = "DeviceType :" + DeviceInfo.DeviceType.ToString();
            lblPlt.Text = "Platform : " + DeviceInfo.Platform;
            lblVer.Text = "Version :" + DeviceInfo.Version;
            lblIdiom.Text = "Idiom :" + DeviceInfo.Idiom;
            lblMdl.Text = "Model :" + DeviceInfo.Model;
            lblMfg.Text = "Manufacturer :" + DeviceInfo.Manufacturer;
        }
	}
}
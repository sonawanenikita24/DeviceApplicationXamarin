//--------------------------------------------------------------------------------------------------------------------
// <copyright file="AppInformation.cs" company="BridgeLabz">
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
	public partial class AppInformation : ContentPage
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="AppInformation"/> class.
        /// </summary>
        public AppInformation()
		{
   			InitializeComponent();

            //// getting all information about application
            lblAppName.Text = "App Name : " + AppInfo.Name;
            lblPackageName.Text = "Package Name : " + AppInfo.PackageName;
            lblVersion.Text = "Version : " + AppInfo.Version;
            lblBuildNumber.Text = "Build Number : " + AppInfo.BuildString;
        }
	}
}
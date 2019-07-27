//--------------------------------------------------------------------------------------------------------------------
// <copyright file="XamVersionTracking.cs" company="BridgeLabz">
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
	public partial class XamVersionTracking : ContentPage
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="XamVersionTracking"/> class.
        /// </summary>
        public XamVersionTracking()
		{
			InitializeComponent();

            lable_firstLaunch.Text = " IsFirstLauncher : " + VersionTracking.IsFirstLaunchEver.ToString();
            lable_firstLaunchCurrent.Text = "IsFirstLaunchForCurrentVersion : " + VersionTracking.IsFirstLaunchForCurrentVersion.ToString();
            lable_firstLaunchBuild.Text = "IsFirstLaunchForCurrentBuild : " + VersionTracking.IsFirstLaunchForCurrentBuild.ToString();
            lable_currentVersion.Text = " Current Version : " + VersionTracking.CurrentVersion.ToString();
            lable_currentBuild.Text = " Current Build : " + VersionTracking.CurrentBuild.ToString();

            if (VersionTracking.PreviousVersion != null)
            {
                lable_previousVersion.Text = "Previous Version : " + VersionTracking.PreviousVersion.ToString();
            }

            if (VersionTracking.PreviousBuild != null)
            {
                lable_previousBuild.Text = " Previous Build : " + VersionTracking.PreviousBuild.ToString();
            }

            lable_firstVersion.Text = "First Installed Version : " + VersionTracking.FirstInstalledVersion.ToString();
            lable_firstBuild.Text = "First Installed Build : " + VersionTracking.FirstInstalledBuild.ToString();

            foreach (string item in VersionTracking.VersionHistory)
            {
                lable_versionHistory.Text = "Version History : " + item.ToString();
            }

            foreach (string item in VersionTracking.BuildHistory)
            {
                lable_buildHistory.Text = "Build History : " + item.ToString();
            }
        }
	}
}
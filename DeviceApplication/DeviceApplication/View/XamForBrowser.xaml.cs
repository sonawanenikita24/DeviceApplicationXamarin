//--------------------------------------------------------------------------------------------------------------------
// <copyright file="XamForBrowser.cs" company="BridgeLabz">
// copyright @2019 
// </copyright>
// <creater name="Nikita Sonawane"/>
//------------------------------------------------------------------------------------------------------------------
namespace DeviceApplication.View
{
    using System;
    using Xamarin.Essentials;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;   

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class XamForBrowser : ContentPage
    {
        /// <summary>
        /// uri is reference of URI
        /// </summary>
        Uri uri;

        /// <summary>
        /// Initializes a new instance of the <see cref="XamForBrowser"/> class.
        /// </summary>
        public XamForBrowser()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When overridden, allows application developers to customize behavior immediately prior to the <see cref="T:Xamarin.Forms.Page" /> becoming visible.
        /// </summary>
        /// <remarks>
        /// To be added.
        /// </remarks>
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        /// <summary>
        /// Handles the browse event of the Clicked control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        void Clicked_browse(object sender, EventArgs e)
        {
            uri = new Uri(entURL.Text);

            OpenBrowser(uri);

            /* var uri = new Uri(entURL.Text);
             await Browser.OpenAsync(uri, new BrowserLaunchOptions
             {
                 LaunchMode = BrowserLaunchMode.SystemPreferred,
                 TitleMode = BrowserTitleMode.Show,
                 PreferredToolbarColor = Color.AliceBlue,
                 PreferredControlColor = Color.Beige

             });*/
        }

        /// <summary>
        /// Opens the browser.
        /// </summary>
        /// <param name="uri">The URI.</param>
        public async void OpenBrowser(Uri uri)
        {
            await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
    }
}
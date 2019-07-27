//--------------------------------------------------------------------------------------------------------------------
// <copyright file="XamShareData.cs" company="BridgeLabz">
// copyright @2019 
// </copyright>
// <creater name="Nikita Sonawane"/>
//------------------------------------------------------------------------------------------------------------------
namespace DeviceApplication.View
{
    using System;
    using System.Threading.Tasks;
    using Xamarin.Essentials;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;    

    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class XamShareData : ContentPage
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="XamShareData"/> class.
        /// </summary>
        public XamShareData()
		{
			InitializeComponent();
		}

        /// <summary>
        /// Shares the text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns></returns>
        public async Task ShareText(string text)
        {
            await Share.RequestAsync(new ShareTextRequest
            {
                Text = text,
                Title = "Share Text"
            });
        }

        /// <summary>
        /// Shares the URI.
        /// </summary>
        /// <param name="uri">The URI.</param>
        /// <returns></returns>
        public async Task ShareUri(string uri)
        {
            await Share.RequestAsync(new ShareTextRequest
            {
                Uri = uri,
                Title = "Share Web Link"
            });
        }

        /// <summary>
        /// Handles the clicked event of the share button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private async void Btnshare_clicked(object sender, EventArgs e)
        {
            await ShareText(txtText.Text);
        }

        /// <summary>
        /// Handles the clicked event of the share url button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private async void Btnshareurl_clicked(object sender, EventArgs e)
        {
            await ShareUri(txtURL.Text);
        }        
    }
}
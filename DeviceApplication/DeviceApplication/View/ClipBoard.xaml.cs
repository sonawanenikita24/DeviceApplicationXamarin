//--------------------------------------------------------------------------------------------------------------------
// <copyright file="ClipBoard.cs" company="BridgeLabz">
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
	public partial class ClipBoard : ContentPage
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="ClipBoard"/> class.
        /// </summary>
        public ClipBoard()
		{
			InitializeComponent();

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += async (s, e) => {
                Clipboard.SetTextAsync(lblCopy.Text);
                if (Clipboard.HasText)
                {
                    var text = await Clipboard.GetTextAsync();
                    DisplayAlert("Success", string.Format("Your copied text is({0})", text), "OK");
                }
            };

            //// add an event on label
            lblCopy.GestureRecognizers.Add(tapGestureRecognizer);
        }
    }
}
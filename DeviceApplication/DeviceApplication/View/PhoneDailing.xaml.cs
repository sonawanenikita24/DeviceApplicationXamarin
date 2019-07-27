//--------------------------------------------------------------------------------------------------------------------
// <copyright file="MainPage.cs" company="BridgeLabz">
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
	public partial class PhoneDailing : ContentPage
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneDailing"/> class.
        /// </summary>
        public PhoneDailing()
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
        /// Calls the specified number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns></returns>
        public async Task Call(string number)
        {
            try
            {
                PhoneDialer.Open(number);
            }
            catch (ArgumentNullException arex)
            {
                Console.WriteLine(arex.Message);
            }
            catch (FeatureNotSupportedException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Handles the Clicked event of the Call_Button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private async void Call_Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNumber.Text))
            {
                await Call(txtNumber.Text);
            }
        }
    }
}
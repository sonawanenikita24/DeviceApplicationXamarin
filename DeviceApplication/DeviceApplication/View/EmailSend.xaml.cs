//--------------------------------------------------------------------------------------------------------------------
// <copyright file="EmailSend.cs" company="BridgeLabz">
// copyright @2019 
// </copyright>
// <creater name="Nikita Sonawane"/>
//------------------------------------------------------------------------------------------------------------------
namespace DeviceApplication.View
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Xamarin.Essentials;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;    
    
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EmailSend : ContentPage
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailSend"/> class.
        /// </summary>
        public EmailSend()
		{
			InitializeComponent();
		}

        /// <summary>
        /// Sends the email.
        /// </summary>
        /// <param name="subject">The subject.</param>
        /// <param name="body">The body.</param>
        /// <param name="recipients">The recipients.</param>
        /// <returns></returns>
        public async Task sendEmail(string subject, string body, List<string> recipients)
        {
            try
            {
                var message = new EmailMessage
                {
                    Subject = subject,
                    Body = body,
                    To = recipients
                };
                await Email.ComposeAsync(message);
            }
            catch (FeatureNotSupportedException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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
        /// Handles the Clicked event of the button_Send control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private async void Button_Send_Clicked(object sender, EventArgs e)
        {
            List<string> toAddress = new List<string>
            {
                txtTo.Text
            };
            await sendEmail(txtSubject.Text, txtBody.Text, toAddress);
        }        
    }
}
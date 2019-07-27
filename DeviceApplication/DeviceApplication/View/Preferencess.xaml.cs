//--------------------------------------------------------------------------------------------------------------------
// <copyright file="Preferencess.cs" company="BridgeLabz">
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
	public partial class Preferencess : ContentPage
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="Preferencess"/> class.
        /// </summary>
        public Preferencess()
		{
			InitializeComponent();
		}

        /// <summary>
        /// Adds the value.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        public void AddValue(string key, string value)
        {
            Preferences.Set(key, value);
        }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        public string GetValue(string key)
        {
            return Preferences.Get(key, string.Empty);
        }

        /// <summary>
        /// Deletes the value.
        /// </summary>
        /// <param name="key">The key.</param>
        public void DeleteValue(string key)
        {
            Preferences.Remove(key);
        }

        /// <summary>
        /// Clears this instance.
        /// </summary>
        public void Clear()
        {
            Preferences.Clear();
        }              

        /// <summary>
        /// Handles the Clicked event of the Get Button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Get_Button_Clicked(object sender, EventArgs e)
        {
            string value = GetValue("mykey");
            DisplayAlert("Success", "Your value is " + value, "ok");
        }

        /// <summary>
        /// Handles the Clicked event of the Remove Button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Remove_Button_Clicked(object sender, EventArgs e)
        {
            DeleteValue("mykey");
            DisplayAlert("success", "Removed key", "ok");
        }

        /// <summary>
        /// Handles the Clicked event of the Clear Button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Clear_Button_Clicked(object sender, EventArgs e)
        {
            Clear();
            DisplayAlert("Success", "All values are cleared", "ok");
        }

        /// <summary>
        /// Handles the clicked event of the Add button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Add_button_clicked(object sender, EventArgs e)
        {
            AddValue("mykey", AddButton.Text);
            AddButton.Text = string.Empty;
            DisplayAlert("Success", "Value stored", "ok");
        }
    }
}
//--------------------------------------------------------------------------------------------------------------------
// <copyright file="MainPage.cs" company="BridgeLabz">
// copyright @2019 
// </copyright>
// <creater name="Nikita Sonawane"/>
//------------------------------------------------------------------------------------------------------------------
namespace DeviceApplication
{
    using System;
    using System.Collections.Generic;
    using DeviceApplication.View;
    using Xamarin.Forms;       
   
    public partial class MainPage : MasterDetailPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainPage"/> class.
        /// </summary>
        public MainPage()
        {
            InitializeComponent();

            //// to add item in master menu
            MenuItems.ItemsSource = GetMenuList();
            Detail = new NavigationPage(new HomePage());
            IsPresented = false;
       }

        /// <summary>
        /// Gets the menu list.
        /// </summary>
        /// <returns></returns>
        public List<MasterMenuItems> GetMenuList()
        {
            var list = new List<MasterMenuItems>();
            try
            {
                list.Add(new MasterMenuItems()
                {
                    Text = "App info",
                    ImagePath = "info.png",
                    TargetPage = typeof(AppInformation)
                });

                list.Add(new MasterMenuItems()
                {
                    Text = "About Phone",
                    ImagePath = "deviceinfo.png",
                    TargetPage = typeof(DeviceInformation)
                });

                list.Add(new MasterMenuItems()
                {
                    Text = "Clipboard",
                    ImagePath = "clipboard.png",
                    TargetPage = typeof(ClipBoard)
                });

                list.Add(new MasterMenuItems()
                {
                    Text = "Network",
                    ImagePath = "network.png",
                    TargetPage = typeof(CheckNetwork)
                });

                list.Add(new MasterMenuItems()
                {
                    Text = "Camera",
                    ImagePath = "camera.png",
                    TargetPage = typeof(Camera)
                });

                list.Add(new MasterMenuItems()
                {
                    Text = "Email",
                    ImagePath = "email.png",
                    TargetPage = typeof(EmailSend)
                });

                list.Add(new MasterMenuItems()
                {
                    Text = "Phone Dialer",
                    ImagePath = "phone.png",
                    TargetPage = typeof(PhoneDailing)
                });

                list.Add(new MasterMenuItems()
                {
                    Text = "browser",
                    ImagePath = "chrome.png",
                    TargetPage = typeof(XamForBrowser)
                });

                list.Add(new MasterMenuItems()
                {
                    Text = "Share",
                    ImagePath = "share.png",
                    TargetPage = typeof(XamShareData)
                });

                list.Add(new MasterMenuItems()
                {
                    Text = "Version Tracking",
                    ImagePath = string.Empty,
                    TargetPage = typeof(XamVersionTracking)

                });

                list.Add(new MasterMenuItems()
                {
                    Text = "Prefernces",
                    ImagePath = "preferences.png",
                    TargetPage = typeof(Preferencess)
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
              
            return list;
        }

        /// <summary>
        /// Indicates that the <see cref="T:Xamarin.Forms.Page" /> has been assigned a size.
        /// </summary>
        /// <param name="width">The width allocated to the <see cref="T:Xamarin.Forms.Page" />.</param>
        /// <param name="height">The height allocated to the <see cref="T:Xamarin.Forms.Page" />.</param>
        /// <remarks>
        /// To be added.
        /// </remarks>
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
        }

        /// <summary>
        /// Called when [menu item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="SelectedItemChangedEventArgs"/> instance containing the event data.</param>
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            try
            {
                var selectedMenuItem = (MasterMenuItems)e.SelectedItem;
                Type selectedPage = selectedMenuItem.TargetPage;
                Detail = new NavigationPage((Page)Activator.CreateInstance(selectedPage));
                IsPresented = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

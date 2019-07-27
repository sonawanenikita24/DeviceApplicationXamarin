//--------------------------------------------------------------------------------------------------------------------
// <copyright file="Camera.cs" company="BridgeLabz">
// copyright @2019 
// </copyright>
// <creater name="Nikita Sonawane"/>
//------------------------------------------------------------------------------------------------------------------
namespace DeviceApplication.View
{
    using System;
    using Plugin.Media;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;   

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Camera : ContentPage
    {
        /// <summary>
        /// constructor
        /// </summary>
        public Camera()
        {
            InitializeComponent();

        }

        /// <summary>
        /// to pick photo from gallery
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Pick_photo_button_clicked(object sender, EventArgs e)
        {
            try
            {
                //// cheking for permission
                if (!CrossMedia.Current.IsPickPhotoSupported)
                {
                    await DisplayAlert("Photos Not Supported", ":( Permission not granted to photos.", "OK");
                    return;
                }

                //// choose photos from default file location
                var file = await Plugin.Media.CrossMedia.Current.PickPhotoAsync(new Plugin.Media.Abstractions.PickMediaOptions
                {
                    PhotoSize = Plugin.Media.Abstractions.PhotoSize.Medium
                });

                //// if file null then return true otherwise take it from file
                if (file == null)
                    return;

                image.Source = ImageSource.FromStream(() =>
                {
                    var stream = file.GetStream();
                    file.Dispose();
                    return stream;
                });
            }
            catch (Exception)
            {
                Console.WriteLine();
            }
        }

        /// <summary>
        /// to take photo from camera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Take_video_button_clicked(object sender, EventArgs e)
        {
            try
            {
                //// checking for camera is available or not
                if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakeVideoSupported)
                {
                    await DisplayAlert("No Camera", ":( No camera avaialble.", "OK");
                    return;
                }

                var file = await CrossMedia.Current.TakeVideoAsync(new Plugin.Media.Abstractions.StoreVideoOptions
                {
                    Name = "video.mp4",
                    Directory = "DefaultVideos",
                });

                if (file == null)
                    return;

                await DisplayAlert("Video Recorded", "Location: " + file.Path, "OK");

                file.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// to pick video from gallery
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Pick_video_button_clicked(object sender, EventArgs e)
        {
            try
            {
                //// checking for video supoorted or not
                if (!CrossMedia.Current.IsPickVideoSupported)
                {
                    await DisplayAlert("Videos Not Supported", ":( Permission not granted to videos.", "OK");
                    return;
                }
                var file = await CrossMedia.Current.PickVideoAsync();

                if (file == null)
                    return;

                await DisplayAlert("Video Selected", "Location: " + file.Path, "OK");
                file.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// to take photo from camera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void TakeAPhotoButton_OnClicked(object sender, EventArgs e)
        {
            try
            {
                if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
                {
                    await DisplayAlert("No Camera", ":( No camera avaialble.", "OK");
                    return;
                }

                var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
                {
                    SaveToAlbum = true,
                    //// PhotoSize = Plugin.Media.Abstractions.PhotoSize.Medium,
                    ////Directory = "DeviceApplication",
                    ////Name = "test.png"
                });

                if (file == null)
                    return;

                await DisplayAlert("File Location", file.Path, "OK");

                Image.Source = ImageSource.FromStream(() =>
                {
                    var stream = file.GetStream();
                    file.Dispose();
                    return stream;
                });
            }
            catch (Exception)
            {
                Console.WriteLine();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Media;
using Plugin.Media.Abstractions;
using PocketCloset.Controller;
using PocketCloset.Models;
using PocketCloset.Util;
using Xamarin.Forms;
using System.Drawing.Imaging;
using Xamarin.Forms.PlatformConfiguration;

using Xamarin.Forms.Xaml;
using System.Diagnostics;
using PocketCloset.ViewModels;

namespace PocketCloset.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        private UserController userController;
        private ClothController clothController;
        private PostController postController;
        private PostRecordController postRecordController;

        private User user;
        private string imagePath;
        

        public HomePage(){
            InitializeComponent();
            Init();
            boxViewFollowing1.Color = Constants.logoColor;
            boxViewFollowing2.Color = Constants.logoColor;
        }
        protected async override void OnAppearing() //populate feed with user posts
        {
            base.OnAppearing();
            user = Application.Current.Properties[CommonSettings.GLOBAL_USER] as User;
            List<FeedViewModel> feeds = await postController.getAllFeeds(user.userId);
            feedListView.ItemsSource = feeds;
           // isActivitySpinnerShowing(false);
        }
        public void Init() //initilize screen components
        {
            BackgroundColor = Constants.backgroundColor;
            userController = new UserController();
            clothController = new ClothController();
            postController = new PostController();
            postRecordController = new PostRecordController();         

        }

        private void addPostForm(object sender, EventArgs e) // button to add new post
         {
            feedPage.IsVisible = false;
            addpostLayout.IsVisible = true;
         }
        
        public async void createPost(object sender, EventArgs e) // creation of a new post with required fields
        {
            try {
                string todayDate = DateTime.Now.ToString("yyyy-MM-dd");
                string imageString = imageToBase64();
                Cloth cloth = new Cloth(user.userId, pickerCLothType.SelectedItem.ToString(), imageString, entryColor.Text, entryMaterial.Text, pickerSeason.SelectedItem.ToString());
                Cloth newCloth = await clothController.createCloth(cloth);
                if (newCloth != null)
                {
                    Post post = new Post(user.userId, newCloth.clothId, Double.Parse(entryPrice.Text), entryUrl.Text, switchModel.IsToggled);
                    Post newPost = await postController.createPost(post);
                    if (newPost != null)
                    {
                        PostRecord postRecord = new PostRecord(user.userId, newPost.postId, todayDate);
                        bool flag = await postRecordController.createModel(postRecord);
                        if (flag) {
                            await DisplayAlert("Message", "Post Create Successfully!", "Okay");
                            App.Current.MainPage = new HomePage();
                        }
                        else
                        {
                            await DisplayAlert("Message", "Error Occured!", "Okay");
                        }
                    }
                    
                }
            } catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }            
        }
        public string imageToBase64() // converting image to base64
        {
           
            using (var image = File.OpenRead(imagePath))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    
                    image.CopyTo(m);
                    byte[] imageBytes = m.ToArray();
                    string base64String = Convert.ToBase64String(imageBytes);
                    return base64String;
                }
            }
        } 

        public interface CameraInterface //interface for selecting picture
        {
            void BringUpPhotoGallery();
        }
        public async void pickPhotoButton(object sender, EventArgs e) // selecting picture from camera roll
        {
            feedLayout.IsVisible = false;
            feedLayout.IsEnabled = false;
            addpostLayout.IsVisible = true;
            addpostLayout.IsEnabled = true;
            {
                if (!CrossMedia.Current.IsPickPhotoSupported)
                {
                    await DisplayAlert("no upload", "picking a photo is not supported", "ok");
                    return;
                }

                MediaFile file = await CrossMedia.Current.PickPhotoAsync();
                if (file == null)
                    return;


                Stream photoStream = file.GetStream();
               
                pickPhotoImage.Source = ImageSource.FromStream(() => photoStream);
                imagePath = file.Path;
                


            };
        }
        

    }
}
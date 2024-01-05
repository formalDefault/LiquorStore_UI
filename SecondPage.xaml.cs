using CommunityToolkit.Maui.Extensions;

namespace MauiAndroidApp
{
    public partial class SecondPage : ContentPage
    { 

        public SecondPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing(); 
        }

        private void SwipeGestureRecognizer_Swiped(object sender, SwipedEventArgs e)
        {
            Navigation.PopAsync();
        }

        private void SwipeGestureRecognizer_Swiped_1(object sender, SwipedEventArgs e)
        {  
            Navigation.PushAsync(new ThirdPage());
        }
    }

}

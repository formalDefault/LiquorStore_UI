using CommunityToolkit.Maui.Extensions;

namespace MauiAndroidApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent(); 
              
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing(); 
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SecondPage());
        }

        private void SwipeGestureRecognizer_Swiped(object sender, SwipedEventArgs e)
        {
            Navigation.PushAsync(new SecondPage());
        }
         
    }

}

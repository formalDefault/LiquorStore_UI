using CommunityToolkit.Maui.Extensions;

namespace MauiAndroidApp
{
    public partial class ThirdPage : ContentPage
    { 

        public ThirdPage()
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

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Home());
        }
    }

}

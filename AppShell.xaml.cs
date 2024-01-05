namespace MauiAndroidApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            
            SetNavBarIsVisible(this, false);

            NavigationPage.SetHasNavigationBar(this, false);

        }
    }
}

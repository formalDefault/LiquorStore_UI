using System.Collections.ObjectModel;

namespace MauiAndroidApp;

public partial class Home : ContentPage
{
    public ObservableCollection<Brand> Brands { get; set; }
    public ObservableCollection<Product> Products { get; set; }
    public ObservableCollection<Product> BestPrices { get; set; }

    public Home()
    {
        InitializeComponent();

        Brands = new ObservableCollection<Brand>()
        {

            new Brand()
            {
                groupId = 1,
                description = "WHISKEY",
                backGroundColor = "#D99D60",
                textColor = "#FFFFFF",
                selected = true,
            },
            new Brand()
            {
                groupId = 3,
                description = "LIQUERS",
                backGroundColor = "Transparent",
                textColor = "#5B5F62",
            },
            new Brand()
            {
                groupId = 4,
                description = "VODKA",
                backGroundColor = "Transparent",
                textColor = "#5B5F62",
            },
            new Brand()
            {
                groupId = 5,
                description = "WINE",
                backGroundColor = "Transparent",
                textColor = "#5B5F62",
            },
            new Brand()
            {
                groupId = 2,
                description = "BEER",
                backGroundColor = "Transparent",
                textColor = "#5B5F62",
            },
        };

        Products = new ObservableCollection<Product>()
        {

            new Product()
            {
                image = "octomore101.png",
                description = "Bruichladdich Octomore 10.1",
                rating = 4.5,
                weight = 750,
                price = 199.99
            },
            new Product()
            {
                image = "ardbeg.png",
                description = "Ardbeg An Oa",
                rating = 5,
                weight = 750,
                price = 85.99
            },
            new Product()
            {
                image = "jack_daniels.png",
                description = "Jack Daniel's Old No. 7 Tennessee",
                rating = 4.7,
                weight = 1.75,
                price = 45.99
            }
        };

        BestPrices = new ObservableCollection<Product>()
        {

            new Product()
            {
                image = "dalmore.png",
                description = "The Dalmore 12 Year",
                weight = 750,
                price = 64.99
            },
            new Product()
            {
                image = "charlotte.png",
                description = "Bruichladdich Port Charlotte Scotch",
                weight = 700,
                price = 63.99
            }
        };

        BindingContext = this;
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        Navigation.PopModalAsync();
    }
}


public class Product
{
    public string description { get; set; }
    public double rating { get; set; }
    public double price { get; set; }
    public double weight { get; set; }
    public string image { get; set; }
}

public struct Brand
{
    public int groupId { get; set; }
    public string description { get; set; }

    public string backGroundColor { get; set; }

    public string textColor { get; set; }

    public bool selected { get; set; }
}
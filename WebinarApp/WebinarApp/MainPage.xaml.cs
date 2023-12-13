using Windows.Phone.Notification.Management;

namespace WebinarApp;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();
        this.DataContext = new MainViewModel();
    }
}

public class MainViewModel : ObservableObject
{
    private int _productId;
    public int ProductId
    {
        get => _productId;
        set => SetProperty(ref _productId, value);

    }

    private string _brand;
    public string Brand
    {
        get => _brand;
        set => SetProperty(ref _brand, value);
    }

    private string _name;
    public string Name
    {
        get => _name;
        set => SetProperty(ref _name, value);
    }

    private string _longName;
    public string LongName
    {
        get => _longName;
        set => SetProperty(ref _longName, value);
    }

    private string _category;
    public string Category
    {
        get => _category;
        set => SetProperty(ref _category, value);
    }

    private string _fullPrice;
    public string FullPrice
    {
        get => _fullPrice;
        set => SetProperty(ref _fullPrice, value);
    }

    private string _price;
    public string Price
    {
        get => _price;
        set => SetProperty(ref _price, value);
    }

    private string _discount;
    public string Discount
    {
        get => _discount;
        set => SetProperty(ref _discount, value);
    }

    private string _photo;
    public string Photo
    {
        get => _photo;
        set => SetProperty(ref _photo, value);
    }

    private string _desc;
    public string Description
    {
        get => _desc;
        set => SetProperty(ref _desc, value);
    }

    private string _rating;
    public string Rating
    {
        get => _rating;
        set => SetProperty(ref _rating, value);
    }

    private List<ReviewViewModel> _reviews;
    public List<ReviewViewModel> Reviews
    {
        get => _reviews;
        set => SetProperty(ref _reviews, value);
    }

    public MainViewModel()
    {
        Brand = "New Balance";
        Name = "Fresh Foam Hierro v6";
        LongName = "Fresh Foam Hierro v6 Trail Running Shoes";
        Category = "Accessories";
        FullPrice = "$134.99";
        Price = "$134.99";
        Discount = "Save 25%";
        Photo = "ms-appx:///WebinarApp/Assets/Products/fresh-foam-hierro-v6.png";
        Description = "Rack up some miles out on the trails in our rugged Fresh Foam Hierro v6. The men’s running shoe features a lightweight Fresh Foam midsole that helps to provide a soft landing on rough terrain. A proven Vibram® outsole provides traction and durability.";
        Rating = "4";
        Reviews = [
            new ReviewViewModel{ Name = "John Doe", Message = "True to size and great stability and support on the trails! Certainly won’t disappoint!!" },
            new ReviewViewModel { Name = "Jane Doe", Message = "The runners arrived faster than i thought.Fit absolutely true to size. very comfortable"},
            new ReviewViewModel { Name = "John Smith", Message = "I love these shoes. They are very comfortable and fit perfectly. I would recommend them to anyone." },
        ];
    }
}

public class ReviewViewModel : ObservableObject
{
    public ReviewViewModel()
    {
        Photo = "ms-appx:///WebinarApp/Assets/Products/me.png";
    }
    private string _name;
    public string Name
    {
        get => _name;
        set => SetProperty(ref _name, value);
    }

    private string _photo;
    public string Photo
    {
        get => _photo;
        set => SetProperty(ref _photo, value);
    }

    private string _message;
    public string Message
    {
        get => _message;
        set => SetProperty(ref _message, value);
    }
}
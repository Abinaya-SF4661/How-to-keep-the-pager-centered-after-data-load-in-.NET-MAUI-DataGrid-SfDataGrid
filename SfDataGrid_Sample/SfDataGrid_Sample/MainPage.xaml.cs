using System.Collections.ObjectModel;

namespace SfDataGrid_Sample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }

    public class OrderInfo
    {
        public string OrderID { get; set; }
        public string CustomerID { get; set; }
        public string Customer { get; set; }
        public string ShipCity { get; set; }
        public string ShipCountry { get; set; }
        public string Gender { get; set; }
        public double Price { get; set; }

        public OrderInfo(string orderId, string customerId, string country, string customer, string shipCity, string gender = "", double price = 0)
        {
            OrderID = orderId;
            CustomerID = customerId;
            Customer = customer;
            ShipCountry = country;
            ShipCity = shipCity;
            Gender = gender;
            Price = price;
        }
    }

    public class DataGridViewModel
    {
        private ObservableCollection<OrderInfo> _orderInfoCollection;

        public ObservableCollection<OrderInfo> OrderInfoCollection
        {
            get => _orderInfoCollection;
            set => _orderInfoCollection = value;
        }

        public DataGridViewModel()
        {
            _orderInfoCollection = new ObservableCollection<OrderInfo>();
            GenerateOrders();
        }

        private void GenerateOrders()
        {
            _orderInfoCollection.Clear();

            var random = new Random(0);

            string[] names =
            {
                "Maria Anders", "Ana Trujillo", "Ant Fuller", "Thomas Hardy", "Tim Adams",
                "Hanna Moos", "Andrew Fuller", "Martin King", "Lenny Lin", "John Carter",
                "Laura King", "Anne Wilson", "Gina Irene", "Paul Lee", "Samantha Fox"
            };

            string[] countries = { "Germany", "Mexico", "UK", "Sweden", "France", "Spain", "Canada", "USA" };
            string[] cities = { "Berlin", "Mexico D.F.", "London", "Mannheim", "Strasbourg", "Madrid", "Toronto", "New York" };
            string[] genders = { "Male", "Female", "Other" };

            for (int i = 0; i < 100; i++)
            {
                string orderId = (1001 + i).ToString();
                string customerId = "C" + (1001 + i).ToString();
                string customer = names[random.Next(names.Length)];
                string country = countries[random.Next(countries.Length)];
                string shipCity = cities[random.Next(cities.Length)];
                string gender = genders[random.Next(genders.Length)];
                double price = Math.Round(random.NextDouble() * 990.0 + 10.0, 2);

                _orderInfoCollection.Add(new OrderInfo(orderId, customerId, country, customer, shipCity, gender, price));
            }
        }
    }
}

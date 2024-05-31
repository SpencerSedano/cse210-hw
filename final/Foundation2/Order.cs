
class Order
{
  private List<Product> _products = new List<Product>();
  private Customer _customer;

  

  public Order(Customer customer)
  {
    _customer = customer;
  }

  // Add product to order
  public void AddProduct(string productName, string productId, double productPrice, int productQuantity)
  {
    _products.Add(new Product { Name = productName, Id = productId, Price = productPrice, Quantity = productQuantity });  
  }

  // Get total price (including shipping)
  public double TotalPrice()
  {
    double totalPrice = 0;
    foreach (Product product in _products)
    {
      totalPrice += product.CalcCost();
    }
    if (_customer.IsCustomerInUSA())
    {
      return totalPrice + 5;  
    }
    else
    {
      return totalPrice + 35;
    }
    
  }

  // Display packing laabel
  public void DisplayPackingLabel()
  {
    foreach (Product product in _products)
    {
      Console.WriteLine($"{product.Id} - {product.Name}");
    }
  }

  // Display shipping label
  public void DisplayShippingLabel()
  {
    Console.WriteLine($"{_customer.Name}\n {_customer.Address.Street}\n {_customer.Address.City}, {_customer.Address.StateProv}, {_customer.Address.GetCountry()}");
  }
}
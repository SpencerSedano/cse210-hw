class Product
{
    private string _name;
    private string _id;
    private double _price;
    private int _quantity;


    public Product()
    {

    }
    public Product(string name, string id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    // Calculate Cost
    public double CalcCost()
    {
        _price = _price * _quantity;
        return _price;
    }


    // Getters and Setters
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public string Id
    {
        get { return _id; }
        set { _id = value; }
    }
    public double Price
    {
        get { return _price; }
        set { _price = value; }
    }
    public int Quantity
    {
        get { return _quantity; }
        set { _quantity = value; }
    }
}
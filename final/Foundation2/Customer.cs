class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Is Customer in the USA? 
    public bool IsCustomerInUSA() 
    {
        if (_address.GetCountry() == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    // Maybe some Getters and Setters
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public Address Address
    {
        get { return _address; }
        set { _address = value; }
    }
}
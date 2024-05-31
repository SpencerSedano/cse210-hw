class Address
{
    private string _street;
    private string _city;
    private string _stateProv;
    private string _country;

    public Address(string street, string city, string Stateprov, string country)
    {
        _street = street;
        _city = city;
        _stateProv = Stateprov;
        _country = country;
    }

    // Is Address in the USA? 



    // Get string containing the multiline version of the address
    public string DisplayAddress()
    {
        return $"{_street}\n {_city}, {_country}, {_stateProv}";
    }


    // Some Getters and Setters

    public string GetCountry()
    {
        return _country;
    }
    
    public string Street
    {
        get { return _street; }
        set { _street = value; }
    }
    public string City
    {
        get { return _city; }
        set { _city = value; }
    }
    public string StateProv
    {
        get { return _stateProv; }
        set { _stateProv = value; }
    }

}
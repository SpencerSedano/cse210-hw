class Program
{
    static void Main(string[] args)
    {
        Address addressOne = new Address("283 Great Street", "Sao Paulo", "Curitiba", "BRA");
        Customer customerOne = new Customer("Spencer Sedano", addressOne);
        Order orderOne = new Order(customerOne);
        

        orderOne.AddProduct("soap", "AO23", 200, 2);
        orderOne.AddProduct("ham", "EAT02", 15, 5);

        Console.WriteLine($"Order1 total cost: ${orderOne.TotalPrice():f2}");

        Console.WriteLine("Packing Label");
        Console.WriteLine("-----------------");
        orderOne.DisplayPackingLabel();

        Console.WriteLine("");

        Console.WriteLine("Shipping Label");
        Console.WriteLine("-----------------");
        orderOne.DisplayShippingLabel();

        Console.WriteLine("");
        
        Address addressTwo = new Address("222 Main Street", "Lima", "Lima", "PE");
        Customer customerTwo = new Customer("Luis Collantes", addressTwo);
        Order orderTwo = new Order(customerTwo);
        

        orderTwo.AddProduct("rice", "OOO2", 100, 4);
        orderTwo.AddProduct("chicken wings", "EAT055", 80, 2);

        Console.WriteLine($"Order2 total cost: ${orderTwo.TotalPrice():f2}");

        Console.WriteLine("Packing Label");
        Console.WriteLine("-----------------");
        orderTwo.DisplayPackingLabel();

        Console.WriteLine("");

        Console.WriteLine("Shipping Label");
        Console.WriteLine("-----------------");
        orderTwo.DisplayShippingLabel();

        Console.WriteLine("");

        Address addressThree = new Address("100 Brigham Young", "Salt Lake", "Utah", "USA");
        Customer customerThree = new Customer("Peter Holland", addressThree);
        Order orderThree = new Order(customerThree);
        

        orderThree.AddProduct("glasses", "SEE01", 1000, 1);
        orderThree.AddProduct("pants", "WEAR04", 300, 2);

        Console.WriteLine($"Order3 total cost: ${orderThree.TotalPrice():f2}");

        Console.WriteLine("Packing Label");
        Console.WriteLine("-----------------");
        orderThree.DisplayPackingLabel();

        Console.WriteLine("");

        Console.WriteLine("Shipping Label");
        Console.WriteLine("-----------------");
        orderOne.DisplayShippingLabel();




    }
}
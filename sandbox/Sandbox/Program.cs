using System;
using System.Collections.Generic;

class Address
{
    private string StreetAddress { get; set; }
    private string City { get; set; }
    private string StateOrProvince { get; set; }
    private string Country { get; set; }

    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        StreetAddress = streetAddress;
        City = city;
        StateOrProvince = stateOrProvince;
        Country = country;
    }

    public bool IsInUSA()
    {
        return Country.ToLower() == "usa";
    }

    public string GeTFullAddress()
    {
        return $"{StreetAddress}\n{City}, {StateOrProvince}";
    }
}

class Customer
{
    private string Name { get; set; }
    private Address Address { get; set; }

    public Customer(string name, Address address)
    {
        Name = name;
        Address = address;
    }

    public bool IsInUSA()
    {
        return Address.IsInUSA();
    }

    public string GetName() => Name;
    public Address GetAddress() => Address;
}

class Product
{
    private string Name { get; set; }
    private string ProductId { get; set; }
    private double Price { get; set; }
    private int Quantity { get; set; }

    public Product(string name, string productId, double price, int quantity)
    {
        Name = name;
        ProductId = productId;
        Price = price;
        Quantity = quantity;
    }

    public string GetName() => Name;
    public string GetProductId() => ProductId;

    public double GetTotalCost()
    {
        return Price * Quantity;
    }
}

class Order
{
    private List<Product> Products { get; set; }
    private Customer Customer { get; set; }

    public Order(Customer customer)
    {
        Customer = customer;
        Products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (var product in Products)
        {
            totalCost += product.GetTotalCost();
        }
        totalCost += Customer.IsInUSA() ? 5 : 35;
        return totalCost;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in Products)
        {
            label += $" - {product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{Customer.GetName()}\n{Customer.GetAddress().GeTFullAddress()}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create customer and address
        Address address1 = new Address("123 Main Street", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Address address2 = new Address("456 Elm Street", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create products
        Product product1 = new Product("Laptop", "L123", 1000, 1);
        Product product2 = new Product("Mouse", "M456", 20, 2);
        Product product3 = new Product("Keyboard", "K789", 50, 1);
        Product product4 = new Product("Monitor", "M101", 200, 1);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Display order details
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost()}\n");

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost()}");
    }
}
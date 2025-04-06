
// Customer class to be a customer with their name and an address.
public class Customer
{
    private string name; 
    private Address address;

    // Constructor
    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }
// Checks to see if they lives in the USA by calling IsInUSA
    public bool LivesInUSA()
    {
        return address.IsInUSA();
    }

    // Gets their name and returns it as string

    public string GetName()
    {
        return name;
    }

    public Address GetAddress()
    {
        return address;
    }
}

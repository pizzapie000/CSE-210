// Address class to store information about address, street, city, state, and country
public class Address
{
    private string street;
    private string city;
    private string state;
    private string country;

    // Constructor
    public Address(string street, string city, string state, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    // Checks for if the country is in the US. Boolean to choose true or false
    public bool IsInUSA()
    {
        return country.ToLower() == "usa";
    }



    /// Makes this a single string like for a shipping label
    public string FullAddress()
    {
        return $"{street}\n{city}, {state}\n{country}";
    }
}

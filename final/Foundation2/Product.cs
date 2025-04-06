//The Product class is to make a product with its name, product ID,price per unit,quantity
public class Product
{
    private string name; 
    private string productId; 
    private decimal pricePerUnit; 
    private int quantity;

    // Constructor
    public Product(string name, string productId, decimal pricePerUnit, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.pricePerUnit = pricePerUnit;
        this.quantity = quantity;
    }

    //Calculates the total cost of the product
    public decimal TotalCost()
    {
        return pricePerUnit * quantity;
    }

        public string GetName()
    {
        return name;
    }

    public string GetProductId()
    {
        return productId;
    }
}

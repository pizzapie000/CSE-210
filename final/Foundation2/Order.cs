// ORder class for an entire order
using System.Collections.Generic;

public class Order
{
    private List<Product> products;
    private Customer customer; 

    // Constructor
    public Order(Customer customer)
    {
        this.products = new List<Product>();
        this.customer = customer;
    }

   //(Adds a product to the order)
    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    // total cost of the order and shipping fee depending on where the customer lives.
    public decimal TotalCost()
    {
        decimal total = 0;
        foreach (var product in products)
        {
            total += product.TotalCost();
        }
        // Add shipping cost based on location
        total += customer.LivesInUSA() ? 5 : 35;
        return total;
    }

    /// Makes packing label
    public string PackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    // Generates a shipping label
    public string ShippingLabel()
    {
        return $"Shipping Label:\n{customer.GetName()}\n{customer.GetAddress().FullAddress()}";
    }
}

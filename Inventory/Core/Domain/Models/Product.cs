namespace Inventory.Core.Domain.Models;

public class Product
{
    public int Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public string? Description { get; private set; }
    public decimal Price { get; private set; }

    private Product() { } // For EF Core

    public Product(string name, string? description, decimal price)
    {
        SetName(name);
        SetDescription(description);
        SetPrice(price);
    }

    public void SetName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name cannot be empty.", nameof(name));
        if (name.Length > 100)
            throw new ArgumentException("Name cannot exceed 100 characters.", nameof(name));

        Name = name;
    }
    public void SetDescription(string? description)
    {
        if (description?.Length > 500)
            throw new ArgumentException("Description cannot exceed 500 characters.", nameof(description));

        Description = description;
    }
    public void SetPrice(decimal price)
    {
        if (price < 0)
            throw new ArgumentException("Price cannot be negative.", nameof(price));
        Price = price;
    }
}

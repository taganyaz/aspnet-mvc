using System.ComponentModel.DataAnnotations;

namespace Inventory.Core.Application.DTOs;

public class ProductDto
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is required")]
    [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters")]
    public string Name { get; set; } = string.Empty;

    [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters")]
    public string? Description { get; set; }

    [Range(0.01, 1000, ErrorMessage = "Price must be between 0.01 and 1000")]
    public decimal Price { get; set; }
}

using Inventory.Core.Application.DTOs;

namespace Inventory.Core.Application.Interfaces;

public interface IProductService
{
    Task<ProductDto> GetByIdAsync(int id);
    Task<IEnumerable<ProductDto>> GetAllAsync();
    Task<ProductDto> CreateAsync(ProductDto productDto);
    Task<ProductDto> UpdateAsync(ProductDto productDto);
    Task DeleteAsync(int id);
}

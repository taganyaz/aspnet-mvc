using AutoMapper;
using Inventory.Core.Application.DTOs;
using Inventory.Core.Application.Interfaces;
using Inventory.Core.Domain.Interfaces;
using Inventory.Core.Domain.Models;

namespace Inventory.Core.Application.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public ProductService(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<ProductDto> CreateAsync(ProductDto productDto)
    {
        try
        {
            var product = new Product(productDto.Name, productDto.Description, productDto.Price);
            await _productRepository.AddAsync(product);

            return _mapper.Map<ProductDto>(product);
        }
        catch(ArgumentException ex)
        {
            throw new ArgumentException("Invalid Product data: " + ex.Message);
        }
    }

    public async Task DeleteAsync(int id)
    {
        var product = _productRepository.GetByIdAsync(id);
        if(product == null)
            throw new ArgumentException("Product not found.");

        await _productRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<ProductDto>> GetAllAsync()
    {
        var products = await _productRepository.GetAllAsync();
        return  _mapper.Map<IEnumerable<ProductDto>>(products);
    }

    public async Task<ProductDto> GetByIdAsync(int id)
    {
        var product = await _productRepository.GetByIdAsync(id);

        if(product == null)
            throw new ArgumentException("Product not found.");

        return _mapper.Map<ProductDto>(product);
    }

    public async Task<ProductDto> UpdateAsync(ProductDto productDto)
    {
        try
        {
            var product = await _productRepository.GetByIdAsync(productDto.Id);

            if( product == null)
                throw new ArgumentException("Product not found.");

            product.SetName(productDto.Name);
            product.SetDescription(productDto.Description);
            product.SetPrice(productDto.Price);

            await _productRepository.UpdateAsync(product);

            return _mapper.Map<ProductDto>(product);
        }
        catch(ArgumentException ex)
        {
            throw new ArgumentException("Invalid Product data: " + ex.Message);
        }
    }
}

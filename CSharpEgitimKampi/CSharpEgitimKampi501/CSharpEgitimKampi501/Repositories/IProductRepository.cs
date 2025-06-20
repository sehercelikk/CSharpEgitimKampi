using CSharpEgitimKampi501.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi501.Repositories
{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task CreateProductAsync(CreateProductdto dto);
        Task UpdateProductAsync(UpdateProductDto dto);
        Task DeleteProductAsync(int id);
        Task GetByIdAsync(int id);
    }
}
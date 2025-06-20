using CSharpEgitimCampi301.DataAccess.Abstract;
using CSharpEgitimCampi301.DataAccess.Context;
using CSharpEgitimCampi301.DataAccess.Repositories;
using CSharpEgitimCampi301.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimCampi301.DataAccess.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public List<object> GetProductsWithCategory()
        {
            var context = new KampContext();
            var values = context.Products.Select(x => new
            {
                ProductId = x.ProductId,
                ProductName = x.ProductName,
                Stock=x.Stock,
                Price=x.Price,
                Description=x.Description,
                CategoryName=x.Category.CategoryName
            }).ToList();
            return values.Cast<object>().ToList();
        }
    }
}

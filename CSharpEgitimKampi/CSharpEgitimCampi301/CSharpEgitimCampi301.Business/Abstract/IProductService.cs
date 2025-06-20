using CSharpEgitimCampi301.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimCampi301.Business.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        List<object> TGetProductsWithCategory();
    }
}

using CSharpEgitimCampi301.DataAccess.Abstract;
using CSharpEgitimCampi301.DataAccess.Repositories;
using CSharpEgitimCampi301.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimCampi301.DataAccess.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
    }
}

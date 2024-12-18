using CsharpEgitimKampi301.DataAccessLayer.Abstract;
using CsharpEgitimKampi301.DataAccessLayer.Repositories;
using CsharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpEgitimKampi301.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal:GenericRepository<Category>,ICategoryDal
    {

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserControll.Domain;

namespace UserControll.Infrastructure
{
    internal sealed class ProductFake : IProductRepository
    {
        public List<ProductEntity> GetAll()
        {
            var result = new List<ProductEntity>();
            result.Add(new ProductEntity(1, "p1", 100));
            result.Add(new ProductEntity(2, "p2", 200));
            result.Add(new ProductEntity(3, "p3", 300));
            return result;
        }
    }
}

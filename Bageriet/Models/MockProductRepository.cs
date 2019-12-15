using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bageriet.Models
{
    public class MockProductRepository:IProductRepository
    {
        public IEnumerable<Product> AllProducts =>
            new List<Product> { new Product{ProductId = 1, Name ="Ljust matbröd", Price=25.00M, Description="Lorem ipsum"},
                                new Product{ProductId = 2, Name = "Surdegsbröd", Price =26.00M, Description="Lorem ipsum" },
                                new Product{ProductId = 3, Name = "Rågbröd", Price = 28.00M, Description = "Lorem ipsum"},
                                new Product{ProductId = 4, Name = "Kaffebröd",Price = 27.00M, Description = "Lorem ipsum" }

            };
    }
}

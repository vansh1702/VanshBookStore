using System;
using System.Collections.Generic;
using System.Text;
using VanshBooks.Models;

namespace VanshBooks.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
    }
}
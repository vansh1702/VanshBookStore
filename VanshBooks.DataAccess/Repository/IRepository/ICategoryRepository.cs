using VanshBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace VanshBooks.DataAccess.Repository.IRepository
{
  public interface ICategoryRepository : IRepository<Category>                               //removed class and modified
    {
        void Update(Category category);
    }
}

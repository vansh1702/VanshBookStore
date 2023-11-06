using VanshBooks.DataAccess.Repository.IRepository;
using VanshBooks.Models;
using VanshBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace VanshBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}

using VanshBooks.DataAccess.Repository.IRepository;
using VanshBookStore.DataAccess.Data;
using System;

namespace VanshBooks.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork // Make the method public to access the class
    {
        private readonly ApplicationDbContext _db; // The using statement

        public UnitOfWork(ApplicationDbContext db) // Constructor to use DI and inject into the repositories
        {
            _db = db;
            Category = new CategoryRepository(_db);
            SP_Call = new SP_Call(_db);
            CoverType = new CoverTypeRepository(_db); // Instantiate the CoverType repository
        }

        public ICategoryRepository Category { get; private set; }
        public ISP_Call SP_Call { get; private set; }
        public ICoverTypeRepository CoverType { get; private set; } // Ensure this is set in the constructor

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save() // All changes will be saved when the Save method is called at the 'parent' level
        {
            _db.SaveChanges();
        }
    }
}
 
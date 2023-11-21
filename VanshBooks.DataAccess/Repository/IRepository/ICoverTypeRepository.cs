using System;
using System.Collections.Generic;
using System.Text;
using VanshBooks.Models;

namespace VanshBooks.DataAccess.Repository.IRepository
{
    public interface ICoverTypeRepository : IRepository<CoverType>
    {
        void Update(CoverType coverType);
    }
}
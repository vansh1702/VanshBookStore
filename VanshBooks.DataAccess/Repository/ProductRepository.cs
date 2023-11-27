﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VanshBooks.DataAccess.Repository.IRepository;
using VanshBooks.Models;
using VanshBookStore.DataAccess.Data;

namespace VanshBooks.DataAccess.Repository
{
    class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(Product product)
        {

            var objFromDb = _db.Products.FirstOrDefault(s => s.Id == product.Id);


            if (objFromDb != null)
            {
                if (product.ImageUrl != null)
                {
                    objFromDb.ImageUrl = product.ImageUrl;
                }
                objFromDb.Title = product.Title;
                objFromDb.Description = product.Description;
                objFromDb.ISBN = product.ISBN;
                objFromDb.Author = product.Author;
                objFromDb.Price = product.Price;
                objFromDb.CategoryId = product.CategoryId;
                objFromDb.CoverTypeId = product.CoverTypeId;


            }

        }

    }
}
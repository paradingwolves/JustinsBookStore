using JustinsBooks.DataAccess.Repository.IRepository;
using JustinsBooks.Models;
using JustinsBookStore.DataAccess.Data;
using JustinsBooks.DataAccess.Repository.IRepository;
using JustinsBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JustinsBooks.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Product product)
        {
            //throw new NotImplementedException();
            //use .NET LINQ to retrieve the first or default category object
            // then pass the id as a generic entity which matters the category ID
            var objFromDb = _db.Products.FirstOrDefault(s => s.Id == product.Id);
            if (objFromDb != null)//Save changes if not null
            {
                objFromDb.ImageUrl = product.ImageUrl;
            }
            objFromDb.Title = product.Title;
            objFromDb.Description = product.Description;
            objFromDb.ISBN = product.ISBN;
            objFromDb.Author = product.Author;
            objFromDb.ListPrice = product.ListPrice;
            objFromDb.Price = product.Price;
            objFromDb.Price50 = product.Price50;
            objFromDb.Price100 = product.Price100;
            objFromDb.CategoryId = product.CategoryId;
            objFromDb.CoverTypeId = product.CoverTypeId;
        }
    }
}

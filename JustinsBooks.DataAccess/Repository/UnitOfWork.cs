using JustinsBooks.DataAccess.Repository.IRepository;
using JustinsBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace JustinsBooks.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            SP_Call = new SP_Call(_db);
            Cover = new CoverTypeRepository(_db);
            Product = new ProductRepository(_db);
            
        }

        public ICategoryRepository Category { get; private set; }
        public ISP_Call SP_Call { get; private set; }
        public ICoverTypeRepository Cover { get; private set; }
        public IProductRepository Product { get; private set; }
        

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}

using JustinsBooks.DataAccess.Repository.IRepository;
using JustinsBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace JustinsBooks.DataAccess.Repository
{
    public class UnitOfWork: IUnitOfWork // make class public
    {
        private readonly ApplicationDbContext _db; // using statement
        public UnitOfWork(ApplicationDbContext db) // constructor method
        {
            _db = db;
            Category = new CategoryRepository(_db);
            SP_Call = new SP_Call(_db);
        }
        public ICategoryRepository Category { get; private set; }
        public ISP_Call SP_Call { get; private set; }

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

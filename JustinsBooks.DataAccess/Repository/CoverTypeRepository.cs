using JustinsBooks.DataAccess.Repository.IRepository;
using JustinsBooks.Models;
using JustinsBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JustinsBooks.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CoverType coverType)
        {
            //throw new NotImplementedException();
            //use .NET LINQ to retrieve the first or default category object
            // then pass the id as a generic entity which matters the category ID
            var objFromDb = _db.CoverType.FirstOrDefault(s => s.Id == coverType.Id);
            if (objFromDb != null)//Save changes if not null
            {
                objFromDb.Name = coverType.Name;
                // _db.SaveChanges();
            }
        }
    }
}

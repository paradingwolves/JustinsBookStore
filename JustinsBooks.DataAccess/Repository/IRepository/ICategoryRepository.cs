using JustinsBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JustinsBooks.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<CategoryRepository>
    {
        void Update(Category category);
    }
}

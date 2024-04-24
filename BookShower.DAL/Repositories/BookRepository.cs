using BookShower.DAL.Entities;
using BookShower.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShower.DAL.Repositories
{
    public class BookRepository : GenericRepository<Books>, IBookRepository
    {
        public BookRepository(BookShowerDBContext _context) : base(_context)
        {
        }
    }
}

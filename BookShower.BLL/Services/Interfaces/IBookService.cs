using BookShower.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShower.BLL.Services.Interfaces
{
    public interface IBookService
    {
        IEnumerable<BookModel> GetAll();
        BookModel? GetById(int id);
        void Insert(BookModel model);
        void Update(BookModel model);
        void Delete(int id);

    }
}

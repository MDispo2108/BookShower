using AutoMapper;
using BookShower.BLL.Models;
using BookShower.BLL.Services.Interfaces;
using BookShower.DAL.Entities;
using BookShower.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShower.BLL.Services
{
    public class BookService : IBookService
    {
        private readonly IMapper _mapper;
        private readonly IBookRepository _bookRepository;
        public BookService(IMapper mapper, IBookRepository bookRepository)
        {
            _mapper = mapper;
            _bookRepository = bookRepository;
        }

        public void Delete(int id)
        {
            _bookRepository.Delete(id);
            _bookRepository.Save();
        }

        public IEnumerable<BookModel> GetAll()
        {
            return _mapper.Map<IEnumerable<BookModel>>(_bookRepository.GetAll());
        }

        public BookModel? GetById(int id)
        {
            return _mapper.Map<BookModel>(_bookRepository.GetById(id));
        }

        public void Insert(BookModel model)
        {
            _bookRepository.Insert(_mapper.Map<Books>(model));
            _bookRepository.Save();
        }

        public void Update(BookModel model)
        {
            _bookRepository.Update(_mapper.Map<Books>(model));
            _bookRepository.Save();
        }
    }
}

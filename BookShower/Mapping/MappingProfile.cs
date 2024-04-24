using AutoMapper;
using BookShower.BLL.Models;
using BookShower.DAL.Entities;

namespace BookShower.PL.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Books, BookModel>().ReverseMap();
        }
    }
}

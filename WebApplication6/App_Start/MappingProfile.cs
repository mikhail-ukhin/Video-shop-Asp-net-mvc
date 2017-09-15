using AutoMapper;
using WebApplication6.Dtos;
using WebApplication6.Models;

namespace WebApplication6
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>();
            CreateMap<Movie, MovieDto>();
            CreateMap<MembershipType, MembershipTypeDto>();

            CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, opt => opt.Ignore()); // игнорируем Id при выполнении привязки к доменной модели
            CreateMap<MovieDto, Movie>().ForMember(m => m.Id, opt => opt.Ignore());
        }
    }
}
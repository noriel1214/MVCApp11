using AutoMapper;
using MVCApp11.Models;
using MVCApp11.Dtos;

namespace MVCApp11.App_Start
{
        public class MappingProfile : Profile
        {
            public MappingProfile()
            {
                Mapper.CreateMap<Customer, CustomerDto>();
                Mapper.CreateMap<CustomerDto, Customer>();
            }
        }
    }

using AutoMapper;
using QuickKartDataAccessLayer.Models;
using QuickKartWebServices.Models;

namespace QuickKartWebServices
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Map Products (data layer) to Product (API model)
            CreateMap<Products, Product>();
        }
    }
}

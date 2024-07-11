using AutoMapper;
using TiendaMicroservicios.Api.Cupon.Models.Dto;

namespace TiendaMicroservicios.Api.Cupon.Aplications
{
    public class CuponProfile : Profile
    {
        public CuponProfile() 
        {
            CreateMap<CuponDto, Cupon.Models.Cupon>().ReverseMap();
        }
    }
}

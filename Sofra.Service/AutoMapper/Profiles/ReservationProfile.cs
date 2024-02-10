using AutoMapper;
using Sofra.Data.Domain;
using Sofra.Service.DTOs.Reservation;

namespace Sofra.Service.AutoMapper.Profiles
{
    public class ReservationProfile : Profile
    {
        public ReservationProfile()
        {
            CreateMap<ReservationCreateDTO, Reservation>().ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(x => DateTime.Now));
            //CreateMap<ReservationCreateDTO, Reservation>().ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<Reservation, ReservationCreateDTO>();
        }
    }
}

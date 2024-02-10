using AutoMapper;
using Sofra.DAL.Abstract;
using Sofra.Data.Domain;
using Sofra.Service.Abstract;
using Sofra.Service.DTOs.Reservation;
using Sofra.Service.Results;
using Sofra.Service.Validation;

namespace Sofra.Service.Concrete
{
    public class ReservationService : ServiceBase, IReservationService
    {
        public ReservationService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) {}

        public async Task<IResult> CreateReservation(ReservationCreateDTO reservationCreateDTO)
        {
            var entity = Mapper.Map<Reservation>(reservationCreateDTO);
            await UnitOfWork.Reservations.AddAsync(entity);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, Messages.Reservation.Add(reservationCreateDTO.Date));
        }
    }
}

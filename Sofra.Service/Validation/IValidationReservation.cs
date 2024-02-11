using Sofra.Service.DTOs.Reservation;

namespace Sofra.Service.Validation
{
    public interface IValidationReservation
    {
        List<ValidationError> IsReservationValid(ReservationCreateDTO reservationCreateDTO);
    }
}

using Sofra.Service.DTOs.Reservation;

namespace Sofra.Service.Validation
{
    public class ValidationReservation : IValidationReservation
    {
        public List<ValidationError> IsReservationValid(ReservationCreateDTO reservationCreateDTO)
        {
            List<ValidationError> errors = new();
            if (reservationCreateDTO.Date <= DateTime.Now.AddHours(1))
            {
                errors.Add(new ValidationError
                {
                    PropertyName = "Date",
                    Message = "Rezervasyon tarihi en az 1 saat sonrası için yapılabilir."
                });
            }
            if (reservationCreateDTO.CustomerCount < 1 || reservationCreateDTO.CustomerCount > 6)
            {
                errors.Add(new ValidationError
                {
                    PropertyName = "CustomerCount",
                    Message = "Müşteri sayısı 1 ile 6 arasında olmalıdır."
                });
            }
            return errors;
        }
    }
}

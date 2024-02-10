using Sofra.Service.DTOs.Reservation;
using Sofra.Service.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sofra.Service.Abstract
{
    public interface IReservationService
    {
        Task<IResult> CreateReservation(ReservationCreateDTO reservationCreateDTO);
    }
}

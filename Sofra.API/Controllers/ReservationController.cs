using Microsoft.AspNetCore.Mvc;
using Sofra.Service.Abstract;
using Sofra.Service.DTOs.Reservation;
using Sofra.Service.Results;

namespace Sofra.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReservationController(IReservationService reservationService) : ControllerBase
    {
        private readonly IReservationService _reservationService = reservationService;

        [HttpPost(Name = "CreateReservation")]
        public async Task<IActionResult> CreateReservation([FromForm] ReservationCreateDTO reservationCreateDTO)
        {
            if (ModelState.IsValid)
            {
                var result = await _reservationService.CreateReservation(reservationCreateDTO);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
            return BadRequest(ModelState);
        }
    }
}

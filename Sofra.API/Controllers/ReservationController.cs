using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Sofra.Service.Abstract;
using Sofra.Service.DTOs.Reservation;
using Sofra.Service.Results;

namespace Sofra.API.Controllers
{
    [DisableCors]
    [ApiController]
    [Route("[controller]")]
    [AllowAnonymous]
    public class ReservationController(IReservationService reservationService, IMailService mailService) : ControllerBase
    {
        private readonly IReservationService _reservationService = reservationService;
        private readonly IMailService _mailService = mailService;

        [HttpPost(Name = "CreateReservation")]
        [AllowAnonymous]
        public async Task<IActionResult> CreateReservation([FromForm] ReservationCreateDTO reservationCreateDTO)
        {
            if (ModelState.IsValid)
            {
                var result = await _reservationService.CreateReservation(reservationCreateDTO);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    _ = _mailService.SendMail("müşteri@mail.com", reservationCreateDTO.Date); // TODO: Get customer's mail from token or session
                    return Ok(result);
                }
                return BadRequest(result);
            }
            return BadRequest(ModelState);
        }
    }
}

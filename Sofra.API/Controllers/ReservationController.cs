using Microsoft.AspNetCore.Mvc;
using Sofra.Service.Abstract;
using Sofra.Service.Results;
using System.Text.Json.Serialization;
using System.Text.Json;
using Sofra.Service.DTOs.Reservation;

namespace Sofra.API.Controllers
{
    public class ReservationController : Controller
    {
        private readonly IReservationService _reservationService;
        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpPost]
        public async Task<JsonResult> CreateReservation(ReservationCreateDTO reservationCreateDTO)
        {
            if (ModelState.IsValid)
            {
                var result = await _reservationService.CreateReservation(reservationCreateDTO);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    //var ResarvationAddAjaxViewModel = JsonSerializer.Serialize(new ResarvationAddAjaxViewModel
                    //{
                    //    ResarvationDto = result.Data,
                    //    ResarvationAddPartial = await this.RenderViewToStringAsync("_ResarvationAddPartial", reservationCreateDTO)
                    //}, new JsonSerializerOptions
                    //{
                    //    ReferenceHandler = ReferenceHandler.Preserve
                    //});
                    //return Json(ResarvationAddAjaxViewModel);
                }
                ModelState.AddModelError("", result.Message);
            }
            //var ResarvationAddAjaxErrorModel = JsonSerializer.Serialize(new ResarvationAddAjaxViewModel
            //{
            //    reservationCreateDTO = reservationCreateDTO,
            //    ResarvationAddPartial = await this.RenderViewToStringAsync("_ResarvationAddPartial", reservationCreateDTO)
            //});
            return Json("x");
        }
    }
}

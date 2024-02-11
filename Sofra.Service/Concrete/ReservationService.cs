using AutoMapper;
using Sofra.DAL.Abstract;
using Sofra.Data.Domain;
using Sofra.Service.Abstract;
using Sofra.Service.DTOs.Reservation;
using Sofra.Service.Results;
using Sofra.Service.Validation;

namespace Sofra.Service.Concrete
{
    public class ReservationService(IUnitOfWork unitOfWork, IMapper mapper, IValidationReservation validate) : ServiceBase(unitOfWork, mapper, validate), IReservationService
    {
        public async Task<IResult> CreateReservation(ReservationCreateDTO reservationCreateDTO)
        {
            try
            {
                List<ValidationError> validationErrorList = new List<ValidationError>();
                if (!await Validate())
                {
                    Exception exception = new("Validasyon Hatası");
                    return new Result(ResultStatus.Error, "Validasyon Hatası", exception, validationErrorList);
                }
                var entity = Mapper.Map<Reservation>(reservationCreateDTO);
                entity.CustomerId = 1; // TODO: Get current user id from token or session
                entity.Duration = 1; // TODO: Set a value according to the restaurant's standart
                entity.TableId = await GetSuitableTableId();

                await UnitOfWork.Reservations.AddAsync(entity);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.Reservation.Add(reservationCreateDTO.Date));


                #region Validation
                async Task<bool> Validate()
                {
                    var tableIds = await UnitOfWork.Tables.GetAllAsync(x => x.Capacity > reservationCreateDTO.CustomerCount); // Get tables that have enough capacity
                    if (await UnitOfWork.Reservations.AnyAsync(x => x.Date.AddHours(x.Duration) <= reservationCreateDTO.Date && tableIds.Select(x => x.Id).Contains(x.TableId))) // If there is a suitable table for that date
                    {
                        validationErrorList.Add(new() { Message = "Seçilen tarih ve kişi sayısı için uygun masa bulunamadı." });
                        return false;
                    }
                    return true;
                }
                #endregion

                #region Helper Methods
                async Task<int> GetSuitableTableId()
                {
                    var tableIds = await UnitOfWork.Tables.GetAllAsync(x => x.Capacity > reservationCreateDTO.CustomerCount);
                    return tableIds.OrderBy(x => x.Capacity).Select(x => x.Id).FirstOrDefault();
                }
                #endregion
            }
            catch
            {
                return new Result(ResultStatus.Error, Messages.Reservation.AddError(reservationCreateDTO.Date));
            }

        }
    }
}

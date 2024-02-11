using AutoMapper;
using Moq;
using Sofra.DAL.Abstract;
using Sofra.Data.Domain;
using Sofra.Service.Concrete;
using Sofra.Service.DTOs.Reservation;
using Sofra.Service.Results;
using Sofra.Service.Validation;
using System.Linq.Expressions;

namespace Sofra.Tests
{
    public class CreateReservation
    {
        [Fact]
        public async Task CreateReservation_ValidInput_ReturnsSuccess()
        {
            var mockUnitOfWork = new Mock<IUnitOfWork>();
            var mockMapper = new Mock<IMapper>();
            var mockValidator = new Mock<IValidationReservation>();

            var reservationDTO = new ReservationCreateDTO
            {
                Date = DateTime.Now.AddDays(1),
                CustomerCount = 4
            };

            mockUnitOfWork.Setup(u => u.Reservations.AnyAsync(It.IsAny<Expression<Func<Reservation, bool>>>()))
                          .ReturnsAsync(false);
            mockUnitOfWork.Setup(u => u.Tables.GetAllAsync(It.IsAny<Expression<Func<Table, bool>>>()))
                          .ReturnsAsync(new List<Table>());

            mockMapper.Setup(m => m.Map<Reservation>(reservationDTO)).Returns(new Reservation());

            var reservationService = new ReservationService(mockUnitOfWork.Object, mockMapper.Object, mockValidator.Object);

            var result = await reservationService.CreateReservation(reservationDTO);

            Assert.True(result.ResultStatus == ResultStatus.Success);
            mockUnitOfWork.Verify(u => u.Reservations.AddAsync(It.IsAny<Reservation>()), Times.Once);
            mockUnitOfWork.Verify(u => u.SaveAsync(), Times.Once);
        }
    }
}
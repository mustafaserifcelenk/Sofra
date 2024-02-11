using AutoMapper;
using Sofra.DAL.Abstract;
using Sofra.Service.Abstract;
using Sofra.Service.Validation;

namespace Sofra.Service.Concrete
{
    public class ServiceBase(IUnitOfWork unitOfWork, IMapper mapper, IValidationReservation validate, IMailService mailService)
    {
        protected IUnitOfWork UnitOfWork { get; } = unitOfWork;
        protected IMapper Mapper { get; } = mapper;
        protected IValidationReservation Validate { get; } = validate;
        protected IMailService MailService { get; } = mailService;
    }
}
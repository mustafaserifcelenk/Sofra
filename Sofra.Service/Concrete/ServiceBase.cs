using AutoMapper;
using Sofra.DAL.Abstract;

namespace Sofra.Service.Concrete
{
    public class ServiceBase
    {
        protected IUnitOfWork UnitOfWork { get; }
        protected IMapper Mapper { get; }

        public ServiceBase(IUnitOfWork unitOfWork, IMapper mapper)
        {
            UnitOfWork = unitOfWork;
            Mapper = mapper;
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Sofra.DAL.Abstract;
using Sofra.DAL.EntityFramework;
using Sofra.DAL.EntityFramework.Context;
using Sofra.Service.Abstract;
using Sofra.Service.Concrete;
using Sofra.Service.Validation;

namespace Sofra.Service.Extension
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollection, string? connectionString)
        {
            serviceCollection.AddDbContext<SofraContext>(options => options.UseSqlServer(connectionString).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            serviceCollection.AddScoped<IValidationReservation, ValidationReservation>();
            serviceCollection.AddScoped<IReservationService, ReservationService>();
            //serviceCollection.AddSingleton<IMailService, MailManager>();
            return serviceCollection;
        }
    }
}

using System.Reflection;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace University.Business;

public static class BusinessExtensions
{
    public static void AddBusiness(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(UniversityProfile).Assembly);
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
   }
}

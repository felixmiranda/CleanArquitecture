using System;
using CleanArchitecture.Domain;
using CleanArchitecture.Domain.Alquileres;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(config => config.RegisterServicesFromAssemblies(typeof(DependencyInjection).Assembly));
        services.AddTransient<PrecioService>();
        return services;
    }
}

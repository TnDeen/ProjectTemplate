using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace ProjectTemplate.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplications(this IServiceCollection services)
        {
            services.AddMediatR(typeof(DependencyInjection).Assembly);
            return services;
        }
    }
}
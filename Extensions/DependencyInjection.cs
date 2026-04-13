using Microsoft.Extensions.DependencyInjection;
using Platform.BuildingBlocks.Abstractions;
using Platform.BuildingBlocks.DateTimes;

namespace Platform.BuildingBlocks.Extensions;

public static class DependencyInjection
{
    public static IServiceCollection AddBuildingBlocks(this IServiceCollection services)
    {
        services.AddSingleton<IDateTimeProvider, SystemDateTimeProvider>();
        return services;
    }
}

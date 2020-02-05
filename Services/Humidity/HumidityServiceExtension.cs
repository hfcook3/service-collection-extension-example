using System;
using Microsoft.Extensions.DependencyInjection;

public static class HumidityServiceExtension
{
    public static void AddHumidityService(this IServiceCollection collection, Action<HumidityServiceOptions> optionsDelegate)
    {
        collection.Configure<HumidityServiceOptions>(optionsDelegate);
        collection.AddSingleton<IHumidityService, HumidityService>();
    }
}
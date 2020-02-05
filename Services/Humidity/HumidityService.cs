using System;
using Microsoft.Extensions.Options;

public class HumidityService : IHumidityService
{
    private readonly bool _returnsPercentForm;

    public HumidityService(IOptions<HumidityServiceOptions> options)
    {
        _returnsPercentForm = options.Value.ReturnsPercentForm;
    }

    public float GetHumidityIndex(double longitude, double latitude)
    {
        var rng = new Random();

        var humidity = (float)Math.Round(rng.Next(99) + rng.NextDouble(), 2);
        return _returnsPercentForm ? humidity : humidity / 100.0f;
    }
}
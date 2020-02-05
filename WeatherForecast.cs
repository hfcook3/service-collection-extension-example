using System;

namespace service_collection_extension_example
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public float HumidityIndex { get; set; }

        public string Summary { get; set; }
    }
}
